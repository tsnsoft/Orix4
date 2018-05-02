using kz.tsnproff.Orix4.utils;
using System;

namespace kz.tsnproff.Orix4.model.impl
{
    /// <summary>
    /// КЛАСС ЗАДАЧИ
    /// </summary>
    class Task : Event
    {
        public Task(string date, string description, bool completed, ICollectionEvents collectionEvents)
            : base(date, description)
        {
            this.setCompleted(completed);
            if (DateCalc.checkDate(date) == true)
            {
                collectionEvents.addEventOrTask(this);
            }
        }

        public override bool isOccurred(int daysCount)
        {
            if (isCompleted() == false)
                return (getRemainingDays() < 0);
            else return base.isOccurred(daysCount);
        }

        public override void setCompleted(bool? isCompleted)
        {
            if (isCompleted == false) this.setTypeEvents(Const.TYPE_EVENTS.Task);
            else this.setTypeEvents(Const.TYPE_EVENTS.CompletedTask);
            base.setCompleted(isCompleted);
        }

        public override string ToString()
        {
            string completedText = "";
            if (this.isCompleted() == false) completedText = "НЕ ВЫПОЛНЕНО";
            else completedText = "ГОТОВО";
            return string.Format("{0} - {1}", base.ToString(), completedText);
        }

    }
}
