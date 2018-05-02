using kz.tsnproff.Orix4.dao;
using kz.tsnproff.Orix4.forms;
using kz.tsnproff.Orix4.model;
using kz.tsnproff.Orix4.test;
using kz.tsnproff.Orix4.utils;
using kz.tsnproff.Orix4.utils.impl;
using System;
using System.IO;
using System.Windows.Forms;

namespace kz.tsnproff.Orix4
{
    public partial class FormMain : Form
    {
        FormWindowState formerState;
        Settings settings;
        String currentDate;

        public FormMain()
        {
            InitializeComponent();

            settings = new Settings(Const.DATA_SETTING_FILE_NAME,
                   numericUpDownDayAfter, numericUpDownOccurred, richTextBoxData);

            currentDate = DateCalc.currDate();
            this.richTextBoxView.ContextMenuStrip = new RichTextBoxContextMenu(this.richTextBoxView, true);
            this.richTextBoxData.ContextMenuStrip = new RichTextBoxContextMenu(this.richTextBoxData, false);
        }

        private void Form1_Load(object sender, EventArgs e)
        // Загрузка формы
        {
            LauncherTest.main();
            settings.loadRawDataFromFile();
            CreateViewData();
        }

        private void CreateViewData()
        // Сборка данных
        {
            richTextBoxView.Clear();
            settings.LoadSettingFromFile();

            CollectionEvents events = DAOFile.getEvents((int)numericUpDownDayAfter.Value, (int)numericUpDownOccurred.Value);

            events.publication(new RichTextBoxOutput(richTextBoxView));
            richTextBoxView.SelectionStart = 0;
        }

        private void tabPageData_Enter(object sender, EventArgs e)
        // Показ вкладки с исходными данными
        {
            settings.loadRawDataFromFile();
        }

        private void tabPageView_Enter(object sender, EventArgs e)
        // Показ вкладки с перспективой дел и событий
        {
            settings.saveRawDataInFile();
            settings.UpdateSettingInFile();
            CreateViewData();
        }

        private void tabPageData_Leave(object sender, EventArgs e)
        // Выход из вкладки редактирования данных
        {
            settings.saveRawDataInFile();
        }

        private void buttonSetDefaultValue_Click(object sender, EventArgs e)
        // Сброс настроек программы по-умолчанию
        {
            numericUpDownDayAfter.Value = Const.DAYS_VIEW;
            numericUpDownOccurred.Value = Const.DAYS_OCCURRED;
        }

        private void timerDateControl_Tick(object sender, EventArgs e)
        // Контроль наступления нового дня
        {
            if (DateCalc.currDate() != currentDate)
            {
                currentDate = DateCalc.currDate();
                tabPageView_Enter(sender, e);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        // Закрытие программы
        {
            settings.saveRawDataInFile();
            settings.UpdateSettingInFile();
            notifyIconMain.Visible = false;
        }

        private void buttonBak_Click(object sender, EventArgs e)
        // Резервирование данных
        {
            try
            {
                File.Copy(Const.DATA_FILE_NAME, Const.DATA_FILE_NAME + Const.DATA_BAK_EXT_FILE_NAME, true);
                File.Copy(Const.DATA_SETTING_FILE_NAME,
                    Const.DATA_SETTING_FILE_NAME + Const.DATA_BAK_EXT_FILE_NAME, true);
                MessageBox.Show("Выполнено успешно !", "Резервирование данных и настроек ");
            }
            catch
            {
                MessageBox.Show("ОШИБКА! Резерные копии не сделаны", "Резервирование данных и настроек ");
            }
        }

        private void buttonUnBak_Click(object sender, EventArgs e)
        // Восстановление данных из резерва
        {
            string message = "Восстановить данные и настройки из резервной копии ?";
            string caption = "Восстановление данных и настроек";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    try
                    {
                        File.Copy(Const.DATA_FILE_NAME + Const.DATA_BAK_EXT_FILE_NAME,
                            Const.DATA_FILE_NAME, true);
                        File.Copy(Const.DATA_SETTING_FILE_NAME + Const.DATA_BAK_EXT_FILE_NAME,
                            Const.DATA_SETTING_FILE_NAME, true);

                        settings.loadRawDataFromFile();
                        CreateViewData();

                        MessageBox.Show("Выполнено успешно !", "Восстановление данных и настроек ");
                    }
                    catch
                    {
                        MessageBox.Show("ОШИБКА! Восстановление данных не сделано",
                            "Восстановление данных и настроек ");
                    }
                    return;
            }
        }

 

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notifyIconMain_DoubleClick(object sender, EventArgs e)
        // Выход из трея по двойному щелчку на значке
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = formerState;
            this.Activate();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        // Обработка сворачивания в трей и разворачивания окна
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                formerState = this.WindowState;
            }
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIconMain.Visible = true;
                notifyIconMain.ShowBalloonTip(1000);
            }
            else
            {
                this.ShowInTaskbar = true;
                notifyIconMain.Visible = false;
            }
        }

        private void открытьПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIconMain_DoubleClick(sender, e);
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

    }
}
