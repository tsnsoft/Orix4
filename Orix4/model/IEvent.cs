namespace kz.tsnproff.Orix4.model
{
    /// <summary>
    /// ОБЩИЙ ИНТЕРФЕЙС СОБЫТИЯ И ЗАДАЧИ 
    /// </summary>
    public interface IEvent
    {
        string getDate();
        string getDescription();
        void setDate(string date);
        void setDescription(string description);
        int? getRemainingDays();
        bool isOccurred(int daysCount);
        bool isToday();
        bool isAfter(int daysCount);
        void setCompleted(bool? isCompleted);
        bool? isCompleted();
        Const.OCCURRENCE_EVENT? getOccurrence();
        Const.TYPE_EVENTS? getTypeEvent();
    }
}
