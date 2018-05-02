using kz.tsnproff.Orix4.utils;
using System;

namespace kz.tsnproff.Orix4.model.impl
{
    /// <summary>
    /// ЕЖЕМЕСЯЧНОЕ СОБЫТИЕ
    /// </summary>
    class MonthlyEvent : Event
    {
        private int dayMonthlyEvent;
        public int getDayMonthlyEvent() { return dayMonthlyEvent; }

        public MonthlyEvent(int day, string description, ICollectionEvents collectionEvents)
            : base(description)
        {
            this.dayMonthlyEvent = day;
            this.setTypeEvents(Const.TYPE_EVENTS.Monthly);
            for (int dYear = -collectionEvents.getProccessinMinYears();
                dYear <= collectionEvents.getProccessinMaxYears(); dYear++)
            {
                for (int month = DateCalc.START_MONTH; month <= DateCalc.END_MONTH; month++)
                {
                    var _dt = DateCalc.assemblyDate(day, month, dYear);
                    if (DateCalc.checkDate(_dt) == true)
                    {
                        this.setDate(_dt);
                        collectionEvents.addEventOrTask((Event)this.MemberwiseClone());
                    }
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {{м}}", base.ToString());
        }

    }
}
