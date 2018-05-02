using kz.tsnproff.Orix4.utils;
using System;

namespace kz.tsnproff.Orix4.model
{
    /// <summary>
    /// ОБЩИЙ АБСТРАКТНЫЙ КЛАСС СОБЫТИЯ И ЗАДАЧИ
    /// </summary>
    abstract class Event : IEvent
    {
        private string _date;
        private string _description;
        private bool? _isCompleted;
        private Const.TYPE_EVENTS? typeEvent;

        public Event(string description)
        {
            this._description = description;
            this._isCompleted = null;
            this.typeEvent = null;
        }

        public Event(string date, string description)
            : this(description)
        {
            this._date = date;
        }

        public int? getRemainingDays()
        {
            return DateCalc.diffDatesDay(DateCalc.currDate(), _date);
        }

        public virtual bool isOccurred(int daysCount)
        {
            return ((getRemainingDays() < 0) && (getRemainingDays() >= -daysCount));
        }

        public bool isToday()
        {
            return getRemainingDays() == 0;
        }

        public bool isAfter(int daysCount)
        {
            return (getRemainingDays() > 0) && (getRemainingDays() <= daysCount);
        }

        public virtual void setCompleted(bool? isCompleted)
        {
            this._isCompleted = isCompleted;
        }

        public bool? isCompleted()
        {
            return _isCompleted;
        }

        public Const.TYPE_EVENTS? getTypeEvent()
        {
            return typeEvent;
        }

        protected void setTypeEvents(Const.TYPE_EVENTS? typeEvent)
        {
            this.typeEvent = typeEvent;
        }

        public string getDate()
        {
            return _date;
        }

        public void setDate(string date)
        {
            this._date = date;
        }

        public void setDescription(string description)
        {
            this._description = description;
        }

        public string getDescription()
        {
            return _description;
        }

        public Const.OCCURRENCE_EVENT? getOccurrence()
        {
            if (getRemainingDays() > 0) return Const.OCCURRENCE_EVENT.After;
            if (getRemainingDays() < 0) return Const.OCCURRENCE_EVENT.Occurred;
            if (getRemainingDays() == 0) return Const.OCCURRENCE_EVENT.Today;
            return null;
        }

        public override string ToString()
        {
            string remainingDaysText = "";
            int? remainingDays = this.getRemainingDays();
            if (remainingDays < 0)
                remainingDaysText = "(" + (Math.Abs((decimal)remainingDays).ToString())
                    + " дн. назад)";
            if (remainingDays > 0)
                remainingDaysText = "(через " + remainingDays + " дн.)";
            return string.Format("{0}     {1} {2}", DateCalc.DateToExtDate(this.getDate()), this.getDescription(),
                remainingDaysText);
        }

    }

}
