using kz.tsnproff.Orix4.utils;
using System;

namespace kz.tsnproff.Orix4.model.impl
{
    /// <summary>
    /// ПРАЗДНИЧНОЕ СОБЫТИЕ
    /// </summary>
    class HolidayEvent : Event
    {
        private string dateHolidayEvent;
        public string getDateHolidayEvent() { return dateHolidayEvent; }

        public HolidayEvent(string date, string description, ICollectionEvents collectionEvents)
            : base(date, description)
        {
            this.dateHolidayEvent = date;
            this.setTypeEvents(Const.TYPE_EVENTS.Holiday);
            for (int dYear = -collectionEvents.getProccessinMinYears();
                dYear <= collectionEvents.getProccessinMaxYears(); dYear++)
            {
                var _dt = DateCalc.assemblyDate(date, dYear);
                if (DateCalc.checkDate(_dt) == true)
                {
                    this.setDate(_dt);
                    collectionEvents.addEventOrTask((Event)this.MemberwiseClone());
                }
            }
        }

        public override string ToString()
        {
            int? dYear = (DateCalc.diffDatesYears(getDateHolidayEvent(), DateCalc.currDate())) +
            (DateCalc.getYear(getDate()) - DateCalc.curYear());

            if ((dYear > 0))
            {
                return string.Format("{0}  [{1}-я годовщина]", base.ToString(), dYear);
            }
            if (dYear < 0)
                return string.Format("{0}  [еще не настало]", base.ToString());
            if (dYear == 0)
                return string.Format("{0} [рождение]", base.ToString());
            return base.ToString();
        }


    }
}
