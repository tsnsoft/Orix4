using kz.tsnproff.Orix4.dao;
using kz.tsnproff.Orix4.model;
using kz.tsnproff.Orix4.utils.impl;

namespace kz.tsnproff.Orix4.test
{
   /// <summary>
   /// Класс для теста
   /// </summary>
    class LauncherTest
    {
        public static void main()
        {
            CollectionEvents events = TestDAO.getEvents();
            events.publication(new ConsoleOutput());

            CollectionEvents events2 = DAOFile.getEvents(15, 7);
            events2.publication(new ConsoleOutput());
        }
    }
}
