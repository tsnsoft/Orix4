namespace kz.tsnproff.Orix4
{
    /// <summary>
    /// КОНСТАНТЫ ПРОГРАММЫ
    /// </summary>
    public class Const
    {
        public enum TYPE_EVENTS : int
        {
            Annual = 5, Holiday = 10, Monthly = 2, Task = 11, CompletedTask = 12
        };
        public enum EElementType
        {
            Occurred, Today, After, Task, CompletedTask, Default
        };
        public enum TYPE_TIME_INTERVAL : byte { Occurred, Today, After, TodayAndAfter, All };
        public enum OCCURRENCE_EVENT : byte { Occurred, Today, After };
        public const int NUMBER_CHARACTERS_DAY_AND_MONTH = 5;
        public const int DAYS_VIEW = 15;
        public const int DAYS_OCCURRED = 7;
        public const string PATTERN_TWO_DIGITS = "{0:00}";
        public const string PATTERN_FOUR_DIGITS = "{0:0000}";
        public const string DATA_FILE_NAME = "Orix4.dat";
        public const string DATA_SETTING_FILE_NAME = "Orix4.ini";
        public const string DATA_BAK_EXT_FILE_NAME = ".bak";
    }
}
