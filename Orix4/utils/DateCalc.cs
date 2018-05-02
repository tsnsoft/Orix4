using kz.tsnproff.Orix4.model;
using System;

namespace kz.tsnproff.Orix4.utils
{
    /// <summary>
    /// Работа с датами
    /// </summary>
    public class DateCalc
    {
        public const string _DATEFORMAT = "dd.MM.yyyy";
        public const string _EDATEFORMAT = "dd.MM.yyyy (ddd)";
        public const string _DAYFORMATONLY = "dd";
        public const string _MONTHFORMATONLY = "MM";
        public const string _YEARFORMATONLY = "yyyy";
        public const string _CHARDATEFORMAT = ".";
        public const int START_MONTH = 1;
        public const int END_MONTH = 12;

        /// <summary>
        /// Преобразование даты в расширенный формат (с днем недели)
        /// </summary>
        /// <param name="date">дата</param>
        /// <returns>дата с днем недели</returns>
        public static string DateToExtDate(string date)
        {
            DateTime _date = DateTime.ParseExact(date, _DATEFORMAT, null);
            return string.Format("{0:" + _EDATEFORMAT + "}", _date);
        }

        /// <summary>
        /// Вычисление количество дней между датами
        /// </summary>
        /// <param name="st_date">начальная дата</param>
        /// <param name="en_date">конечная дата</param>
        /// <returns>количество дней</returns>
        public static int? diffDatesDay(string st_date, string en_date)
        {
            try
            {
                DateTime stdate = DateTime.ParseExact(st_date, _DATEFORMAT, null);
                DateTime enddate = DateTime.ParseExact(en_date, _DATEFORMAT, null);
                return (enddate - stdate).Days;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Вычисление количество лет между датами
        /// </summary>
        /// <param name="st_date">начальная дата</param>
        /// <param name="en_date">конечная дата</param>
        /// <returns>количество дней</returns>
        public static int? diffDatesYears(string st_date, string en_date)
        {
            try
            {
                DateTime stdate = DateTime.ParseExact(st_date, _DATEFORMAT, null);
                DateTime enddate = DateTime.ParseExact(en_date, _DATEFORMAT, null);
                return (enddate.Year - stdate.Year);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Возвращает текущую дату
        /// </summary>
        /// <returns>текущая дата</returns>
        public static string currDate()
        {
            return DateTime.Now.ToString(_DATEFORMAT);
        }

        /// <summary>
        /// Возвращает текущий день
        /// </summary>
        /// <returns>текущий день</returns>
        public static string currDay()
        {
            return DateTime.Now.ToString(_DAYFORMATONLY);
        }

        /// <summary>
        /// Возвращает текущий месяц
        /// </summary>
        /// <returns>текущий месяц</returns>
        public static string currMonth()
        {
            return DateTime.Now.ToString(_MONTHFORMATONLY);
        }

        /// <summary>
        /// Возвращает текущий год
        /// </summary>
        /// <returns>текущий год</returns>
        public static string currYear()
        {
            return DateTime.Now.ToString(_YEARFORMATONLY);
        }

        /// <summary>
        /// Возвращает текущий год в виде числа
        /// </summary>
        /// <returns></returns>
        public static int curYear()
        {
            return int.Parse(DateTime.Now.ToString(_YEARFORMATONLY));
        }

        /// <summary>
        /// Проверка даты
        /// </summary>
        /// <param name="date">дата</param>
        /// <returns>да/нет</returns>
        public static bool checkDate(string date)
        {
            try
            {
                DateTime dt = DateTime.ParseExact(date, _DATEFORMAT, null);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Возвращает год даты
        /// </summary>
        /// <param name="_date"></param>
        /// <returns>год</returns>
        public static int? getYear(string date)
        {
            try
            {
                DateTime _date = DateTime.ParseExact(date, _DATEFORMAT, null);
                return _date.Year;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Сборка строки даты 
        /// </summary>
        /// <param name="day">день</param>
        /// <param name="month">месяц</param>
        /// <param name="dYear">прирощение года относительно текущего</param>
        /// <returns>готовая дата формата дд.мм.гггг</returns>
        public static string assemblyDate(int day, int month, int dYear)
        {
            var _dt = (string.Format(Const.PATTERN_TWO_DIGITS, day)
                                + DateCalc._CHARDATEFORMAT
                                + string.Format(Const.PATTERN_TWO_DIGITS, month)
                                + DateCalc._CHARDATEFORMAT
                                + string.Format(Const.PATTERN_FOUR_DIGITS, (DateCalc.curYear() + dYear).ToString()));
            return _dt;
        }

        /// <summary>
        /// Сборка строки даты 
        /// </summary>
        /// <param name="date">дата формата дд.мм.гггг</param>
        /// <param name="dYear">прирощение года относительно текущего</param>
        /// <returns>готовая дата формата дд.мм.гггг</returns>
        public static string assemblyDate(string date, int dYear)
        {
            var _dt = date.Substring(0, Const.NUMBER_CHARACTERS_DAY_AND_MONTH)
                + DateCalc._CHARDATEFORMAT +
                string.Format(Const.PATTERN_FOUR_DIGITS, (DateCalc.curYear() + dYear).ToString());
            return _dt;
        }

        /// <summary>
        /// Расчет количества лет для анализа
        /// </summary>
        /// <param name="daysCount">количество дней</param>
        /// <returns>количество лет</returns>
        public static int getProcessingYear(int daysCount)
        {
            int year = (daysCount / 365) + 1;
            return year;
        }
    }
}
