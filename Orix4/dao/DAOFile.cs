using kz.tsnproff.Orix4.model;
using kz.tsnproff.Orix4.model.impl;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace kz.tsnproff.Orix4.dao
{
    /// <summary>
    /// ДЕКОДЕР ТЕКСТОВОГО ФАЙЛА С ДАННЫМИ
    /// </summary>
    public static class DAOFile
    {
        public static CollectionEvents getEvents()
        {
            return getEvents(Const.DAYS_VIEW, Const.DAYS_OCCURRED);
        }

        public static CollectionEvents getEvents(int daysView, int daysOccurred)
        {
            CollectionEvents events = new CollectionEvents(daysView, daysOccurred);

            var date = new List<string>();
            var desc = new List<string>();
            int countLine = 0;
            try
            {
                File.ReadAllLines(Const.DATA_FILE_NAME).ToList().ForEach(ss =>
                {
                    try
                    {
                        var s = ss.Trim();
                        var k = s.IndexOf(' ');
                        if (k >= 0)
                        {
                            var _date = s.Substring(0, k).Trim();
                            var _desc = s.Substring(k, s.Length - k).Trim();
                            countLine++;
                            _date = _date.Replace('/', '.');
                            switch (_date.Length)
                            {
                                case (int)Const.TYPE_EVENTS.Annual:
                                    new AnnualEvent(int.Parse(_date.Substring(0, 2)),
                                        int.Parse(_date.Substring(3, 2)), _desc, events);
                                    break;
                                case (int)Const.TYPE_EVENTS.Holiday:
                                    new HolidayEvent(_date, _desc, events);
                                    break;
                                case (int)Const.TYPE_EVENTS.Monthly:
                                    new MonthlyEvent(int.Parse(_date.Substring(0, 2)), _desc, events);
                                    break;
                                case (int)Const.TYPE_EVENTS.Task:
                                    _date = _date.Substring(1, _date.Length - 1);
                                    new Task(_date, _desc, false, events);
                                    break;
                                case (int)Const.TYPE_EVENTS.CompletedTask:
                                    _date = _date.Substring(2, _date.Length - 2);
                                    new Task(_date, _desc, true, events);
                                    break;
                            }
                        };
                    }
                    catch { };
                }
                    );
            }
            catch { };
            return events;
        }
    }
}



