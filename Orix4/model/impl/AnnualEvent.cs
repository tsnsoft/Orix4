using kz.tsnproff.Orix4.utils;
using System;

namespace kz.tsnproff.Orix4.model.impl
{
    /// <summary>
    /// ЕЖЕГОДНОЕ СОБЫТИЕ
    /// </summary>
    class AnnualEvent : Event
    {
        private int dayAnnualEvent;
        private int monthAnnualEvent;

        public int getDayAnnualEvent() { return dayAnnualEvent; }
        public int getmonthAnnualEvent() { return monthAnnualEvent; }

        public AnnualEvent(int day, int month, string description, ICollectionEvents collectionEvents)
            : base(description)
        {
            this.dayAnnualEvent = day;
            this.monthAnnualEvent = month;
            this.setTypeEvents(Const.TYPE_EVENTS.Annual);
            for (int dYear = -collectionEvents.getProccessinMinYears();
                dYear <= collectionEvents.getProccessinMaxYears(); dYear++)
            {
                var _dt = DateCalc.assemblyDate(day, month, dYear);
                if (DateCalc.checkDate(_dt) == true)
                {
                    this.setDate(_dt);
                    collectionEvents.addEventOrTask((Event)this.MemberwiseClone());
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {{г}}", base.ToString());
        }
    }

}
