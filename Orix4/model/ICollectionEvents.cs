using kz.tsnproff.Orix4.utils;
using System.Collections.Generic;

namespace kz.tsnproff.Orix4.model
{
    /// <summary>
    /// ИНТЕРФЕЙС РАБОТЫ С НАБОРОМ ДАННЫХ
    /// </summary>
    public interface ICollectionEvents
    {
        void addEventOrTask(IEvent eventOrTask);
        void removeEventOrTask(IEvent eventOrTask);
        void clearAll();
        List<IEvent> getRawData(bool isSort);
        List<IEvent> getEventsOccurred(int daysCount);
        List<IEvent> getEventsToday();
        List<IEvent> getEventsAfter(int daysCount);
        List<IEvent> getEventsTodayAndAfter(int daysCount);
        List<IEvent> getEventsAll(int daysCount);
        void publication(IOutput output);
        int getProccessinMinYears();
        int getProccessinMaxYears();
    }
}
