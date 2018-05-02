using kz.tsnproff.Orix4.model;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace kz.tsnproff.Orix4.utils
{
    public class Settings
    {
        const string C_CONFIG = "config";
        const string C_SETTINGS = "settings";
        const string C_DAYS_VIEW = "daysView";
        const string C_DAY_OCCURRED = "daysOccurred";
        const string C_TCOLUMNS = "System.String";

        string nameFile;
        NumericUpDown numericUpDownDayAfter;
        NumericUpDown numericUpDownOccurred;
        RichTextBox richTextBoxData;

        public Settings(string nameFile, NumericUpDown numericUpDownDayAfter,
            NumericUpDown numericUpDownOccurred, RichTextBox richTextBoxData)
        {
            this.nameFile = nameFile;
            this.numericUpDownDayAfter = numericUpDownDayAfter;
            this.numericUpDownOccurred = numericUpDownOccurred;
            this.richTextBoxData = richTextBoxData;
        }

        /// <summary>
        /// Загрузка настроек из файла настроек
        /// </summary>
        public void LoadSettingFromFile()
        {
            try
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.ReadXml(nameFile, XmlReadMode.Auto);
                System.Data.DataTable table = ds.Tables[C_SETTINGS];
                System.Data.DataRow row = table.Rows[0];
                string daysView = (string)row[C_DAYS_VIEW];
                string daysOccurred = (string)row[C_DAY_OCCURRED];
                numericUpDownDayAfter.Value = decimal.Parse(daysView);
                numericUpDownOccurred.Value = decimal.Parse(daysOccurred);
            }
            catch
            {
                numericUpDownDayAfter.Value = Const.DAYS_VIEW;
                numericUpDownOccurred.Value = Const.DAYS_OCCURRED;
            }
        }

        /// <summary>
        /// Сохранение настроек в файле настроек
        /// </summary>
        private void SaveSettingInFile()
        {
            try
            {
                System.Data.DataSet ds = new System.Data.DataSet(C_CONFIG);
                System.Data.DataTable table = ds.Tables.Add(C_SETTINGS);
                DataTable dtb = ds.Tables[C_SETTINGS];
                dtb.Columns.Add(C_DAYS_VIEW, System.Type.GetType(C_TCOLUMNS));
                dtb.Columns.Add(C_DAY_OCCURRED, System.Type.GetType(C_TCOLUMNS));
                DataRow row = dtb.NewRow();
                row[C_DAYS_VIEW] = numericUpDownDayAfter.Value;
                row[C_DAY_OCCURRED] = numericUpDownOccurred.Value;
                dtb.Rows.Add(row);
                ds.WriteXml(Const.DATA_SETTING_FILE_NAME);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Обновление настроек в файле настроек
        /// </summary>
        public void UpdateSettingInFile()
        {
            try
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.ReadXml(nameFile, XmlReadMode.Auto);
                System.Data.DataTable table = ds.Tables[C_SETTINGS];
                System.Data.DataRow row = table.Rows[0];
                row[C_DAYS_VIEW] = numericUpDownDayAfter.Value;
                row[C_DAY_OCCURRED] = numericUpDownOccurred.Value;
                ds.WriteXml(Const.DATA_SETTING_FILE_NAME);
            }
            catch
            {
                SaveSettingInFile();
            }
        }

        /// <summary>
        /// Сохранение исходных данных в файле
        /// </summary>
        public void saveRawDataInFile()
        {
            try
            {
                File.WriteAllText(Const.DATA_FILE_NAME, richTextBoxData.Text);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Загрузка исходных данных из файла
        /// </summary>
        public void loadRawDataFromFile()
        {
            try
            {
                richTextBoxData.Text = File.ReadAllText(Const.DATA_FILE_NAME);
            }
            catch
            {
                richTextBoxData.Text = "";
            }
        }
    }
}
