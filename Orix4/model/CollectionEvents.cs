using kz.tsnproff.Orix4.utils;
using System.Collections.Generic;

namespace kz.tsnproff.Orix4.model
{

    /// <summary>
    /// НАБОР ДАННЫХ С СОБЫТИЯМИ
    /// </summary>
    public class CollectionEvents : ICollectionEvents
    {
        protected List<IEvent> _eventsAndTasks;
        protected int _daysView;
        protected int _daysOccurred;
        private int _proccessinMinYears { set; get; }
        private int _proccessinMaxYears { set; get; }

        public CollectionEvents()
            : this(Const.DAYS_VIEW, Const.DAYS_OCCURRED)
        {
        }

        public CollectionEvents(int daysView, int daysOccurred)
        {
            this._daysView = daysView;
            this._daysOccurred = daysOccurred;
            this._proccessinMinYears = DateCalc.getProcessingYear(daysOccurred);
            this._proccessinMaxYears = DateCalc.getProcessingYear(daysView);
            _eventsAndTasks = new List<IEvent>();
        }

        public int getProccessinMinYears()
        {
            return _proccessinMinYears;
        }

        public int getProccessinMaxYears()
        {
            return _proccessinMaxYears;
        }

        public List<IEvent> getRawData(bool isSort)
        {
            if (isSort == true)
            {
                List<IEvent> list = new List<IEvent>(_eventsAndTasks);
                list.Sort(new EventOrJobComparator());
                return list;
            }
            else return _eventsAndTasks;
        }

        public void addEventOrTask(IEvent eventOrJob)
        {
            _eventsAndTasks.Add(eventOrJob);
        }

        public void removeEventOrTask(IEvent eventOrJob)
        {
            _eventsAndTasks.Remove(eventOrJob);
        }

        public void clearAll()
        {
            _eventsAndTasks.Clear();
        }

        private List<IEvent> getEvents(Const.TYPE_TIME_INTERVAL typeTimeInterval, int daysCount)
        {
            List<IEvent> list = new List<IEvent>();
            foreach (IEvent currItem in _eventsAndTasks)
            {
                switch (typeTimeInterval)
                {
                    case Const.TYPE_TIME_INTERVAL.Occurred:
                        if (currItem.isOccurred(daysCount) == true) list.Add(currItem);
                        break;
                    case Const.TYPE_TIME_INTERVAL.Today:
                        if (currItem.isToday() == true) list.Add(currItem);
                        break;
                    case Const.TYPE_TIME_INTERVAL.After:
                        if (currItem.isAfter(daysCount) == true) list.Add(currItem);
                        break;
                    case Const.TYPE_TIME_INTERVAL.TodayAndAfter:
                        if ((currItem.isToday() == true) || (currItem.isAfter(daysCount) == true))
                            list.Add(currItem);
                        break;
                    case Const.TYPE_TIME_INTERVAL.All:
                        if ((currItem.isOccurred(daysCount) == true) || (currItem.isToday() == true) ||
                            (currItem.isAfter(daysCount) == true))
                            list.Add(currItem);
                        break;
                }

            }
            if (typeTimeInterval != Const.TYPE_TIME_INTERVAL.Occurred)
                list.Sort(new EventOrJobComparator());
            else
                list.Sort(new EventOrJobComparatorDec());
            return list;
        }

        public List<IEvent> getEventsOccurred(int daysCount)
        {
            return getEvents(Const.TYPE_TIME_INTERVAL.Occurred, daysCount);
        }

        public List<IEvent> getEventsToday()
        {
            return getEvents(Const.TYPE_TIME_INTERVAL.Today, 0);
        }

        public List<IEvent> getEventsAfter(int daysCount)
        {
            return getEvents(Const.TYPE_TIME_INTERVAL.After, daysCount);
        }

        public List<IEvent> getEventsTodayAndAfter(int daysCount)
        {
            return getEvents(Const.TYPE_TIME_INTERVAL.TodayAndAfter, daysCount);
        }

        public List<IEvent> getEventsAll(int daysCount)
        {
            return getEvents(Const.TYPE_TIME_INTERVAL.All, daysCount);
        }

        void printData(List<IEvent> list, IOutput output, Const.EElementType elementType)
        {
            Const.EElementType color;
            IEnumerator<IEvent> iterator = list.GetEnumerator();
            while (iterator.MoveNext())
            {
                color = elementType;

                if (iterator.Current.getTypeEvent() == Const.TYPE_EVENTS.Task)
                    color = Const.EElementType.Task;
                if (iterator.Current.getTypeEvent() == Const.TYPE_EVENTS.CompletedTask)
                    color = Const.EElementType.CompletedTask;

                if (iterator.Current.getOccurrence() != null)
                    output.println(string.Format("{0}", iterator.Current),
                        color);
            }
        }


        public void publication(IOutput output)
        {
            if (this.getRawData(false).Count == 0)
            {
                output.println("Нет доступа к файлу с данными, либо в нем нет данных!");
                return;
            }

            List<IEvent> list;

            list = this.getEventsToday();
            if (list.Count > 0)
            {
                output.println("    Сегодня:", Const.EElementType.Default);
                this.printData(list, output, Const.EElementType.Today);
                output.println("");
            }

            list = this.getEventsAfter(_daysView);
            if (list.Count > 0)
            {
                output.println("    Скоро будет:", Const.EElementType.Default);
                this.printData(list, output, Const.EElementType.After);
                output.println("");
            }

            list = this.getEventsOccurred(_daysOccurred);
            if (list.Count > 0)
            {
                output.println("    Уже было:", Const.EElementType.Default);
                this.printData(list, output, Const.EElementType.Occurred);
                output.println("");
            }
        }

    }

    class EventOrJobComparator : IComparer<IEvent>
    {
        public int Compare(IEvent o1, IEvent o2)
        {
            int? oo1 = o1.getRemainingDays();
            int? oo2 = o2.getRemainingDays();
            if (oo1 > oo2) return 1;
            if (oo1 < oo2) return -1; else return 0;
        }
    }

    class EventOrJobComparatorDec : IComparer<IEvent>
    {
        public int Compare(IEvent o1, IEvent o2)
        {
            int? oo1 = o1.getRemainingDays();
            int? oo2 = o2.getRemainingDays();
            if (oo1 < oo2) return 1;
            if (oo1 > oo2) return -1; else return 0;
        }
    }

}
