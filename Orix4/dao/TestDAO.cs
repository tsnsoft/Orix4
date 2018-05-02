using kz.tsnproff.Orix4.model;
using kz.tsnproff.Orix4.model.impl;

namespace kz.tsnproff.Orix4.dao
{
    /// <summary>
    /// ГЕНЕРАТОР ТЕСТОВОГО НАБОРА ДАННЫХ
    /// </summary>
    public static class TestDAO
    {
        public static CollectionEvents getEvents()
        {
            CollectionEvents events = new CollectionEvents();
            new HolidayEvent("05.10.1975", "день рождения 05.10.1975", events);
            new HolidayEvent("07.10.1975", "день рождения 07.10.1975", events);
            new HolidayEvent("08.10.1975", "день рождения 08.10.1975", events);

            new AnnualEvent(06, 10, "праздничное ежегодное событие 06/10", events);
            new AnnualEvent(07, 10, "праздничное ежегодное событие 07/10", events);
            new AnnualEvent(12, 10, "праздничное ежегодное событие 12/10", events);

            new MonthlyEvent(6, "ежемесячное событие 06", events);
            new MonthlyEvent(7, "ежемесячное событие 07", events);
            new MonthlyEvent(8, "ежемесячное событие 08", events);

            new Task("03.01.2015", "Дело 03/10/2015", true, events).setCompleted(!true);
            new Task("07.10.2015", "Дело 07/10/2015", true, events);
            new Task("16.10.2015", "Дело 16/10/2015", false, events).setCompleted(true);

            return events;
        }

    }
}
