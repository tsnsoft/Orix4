namespace kz.tsnproff.Orix4
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.richTextBoxView = new System.Windows.Forms.RichTextBox();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.richTextBoxData = new System.Windows.Forms.RichTextBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUnBak = new System.Windows.Forms.Button();
            this.buttonBak = new System.Windows.Forms.Button();
            this.buttonSetDefaultValue = new System.Windows.Forms.Button();
            this.numericUpDownOccurred = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDayAfter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timerDateControl = new System.Windows.Forms.Timer(this.components);
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPageView.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOccurred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDayAfter)).BeginInit();
            this.tabPageAbout.SuspendLayout();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageView);
            this.tabControlMain.Controls.Add(this.tabPageData);
            this.tabControlMain.Controls.Add(this.tabPageSettings);
            this.tabControlMain.Controls.Add(this.tabPageAbout);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(894, 418);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.richTextBoxView);
            this.tabPageView.Location = new System.Drawing.Point(4, 29);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(886, 385);
            this.tabPageView.TabIndex = 0;
            this.tabPageView.Text = "Перспектива";
            this.tabPageView.UseVisualStyleBackColor = true;
            this.tabPageView.Enter += new System.EventHandler(this.tabPageView_Enter);
            // 
            // richTextBoxView
            // 
            this.richTextBoxView.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBoxView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBoxView.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxView.Name = "richTextBoxView";
            this.richTextBoxView.ReadOnly = true;
            this.richTextBoxView.Size = new System.Drawing.Size(880, 379);
            this.richTextBoxView.TabIndex = 3;
            this.richTextBoxView.Text = "";
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.richTextBoxData);
            this.tabPageData.Location = new System.Drawing.Point(4, 29);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(886, 385);
            this.tabPageData.TabIndex = 1;
            this.tabPageData.Text = "Данные";
            this.tabPageData.UseVisualStyleBackColor = true;
            this.tabPageData.Enter += new System.EventHandler(this.tabPageData_Enter);
            this.tabPageData.Leave += new System.EventHandler(this.tabPageData_Leave);
            // 
            // richTextBoxData
            // 
            this.richTextBoxData.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBoxData.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxData.Name = "richTextBoxData";
            this.richTextBoxData.Size = new System.Drawing.Size(880, 379);
            this.richTextBoxData.TabIndex = 0;
            this.richTextBoxData.Text = "";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPageSettings.Controls.Add(this.panel1);
            this.tabPageSettings.Controls.Add(this.buttonSetDefaultValue);
            this.tabPageSettings.Controls.Add(this.numericUpDownOccurred);
            this.tabPageSettings.Controls.Add(this.numericUpDownDayAfter);
            this.tabPageSettings.Controls.Add(this.label2);
            this.tabPageSettings.Controls.Add(this.label1);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 29);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(886, 385);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Настройки";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonUnBak);
            this.panel1.Controls.Add(this.buttonBak);
            this.panel1.Location = new System.Drawing.Point(109, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 160);
            this.panel1.TabIndex = 8;
            // 
            // buttonUnBak
            // 
            this.buttonUnBak.Location = new System.Drawing.Point(78, 88);
            this.buttonUnBak.Name = "buttonUnBak";
            this.buttonUnBak.Size = new System.Drawing.Size(514, 34);
            this.buttonUnBak.TabIndex = 7;
            this.buttonUnBak.Text = "Восстановить данные и настройки из резервной копии";
            this.buttonUnBak.UseVisualStyleBackColor = true;
            this.buttonUnBak.Click += new System.EventHandler(this.buttonUnBak_Click);
            // 
            // buttonBak
            // 
            this.buttonBak.Location = new System.Drawing.Point(116, 31);
            this.buttonBak.Name = "buttonBak";
            this.buttonBak.Size = new System.Drawing.Size(439, 34);
            this.buttonBak.TabIndex = 6;
            this.buttonBak.Text = "Сделать резервную копию данных и настроек";
            this.buttonBak.UseVisualStyleBackColor = true;
            this.buttonBak.Click += new System.EventHandler(this.buttonBak_Click);
            // 
            // buttonSetDefaultValue
            // 
            this.buttonSetDefaultValue.Location = new System.Drawing.Point(239, 128);
            this.buttonSetDefaultValue.Name = "buttonSetDefaultValue";
            this.buttonSetDefaultValue.Size = new System.Drawing.Size(405, 38);
            this.buttonSetDefaultValue.TabIndex = 5;
            this.buttonSetDefaultValue.Text = "Установить настройки по умолчанию";
            this.buttonSetDefaultValue.UseVisualStyleBackColor = true;
            this.buttonSetDefaultValue.Click += new System.EventHandler(this.buttonSetDefaultValue_Click);
            // 
            // numericUpDownOccurred
            // 
            this.numericUpDownOccurred.BackColor = System.Drawing.Color.GhostWhite;
            this.numericUpDownOccurred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numericUpDownOccurred.Location = new System.Drawing.Point(566, 73);
            this.numericUpDownOccurred.Maximum = new decimal(new int[] {
            3650,
            0,
            0,
            0});
            this.numericUpDownOccurred.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOccurred.Name = "numericUpDownOccurred";
            this.numericUpDownOccurred.Size = new System.Drawing.Size(99, 27);
            this.numericUpDownOccurred.TabIndex = 4;
            this.numericUpDownOccurred.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // numericUpDownDayAfter
            // 
            this.numericUpDownDayAfter.BackColor = System.Drawing.Color.GhostWhite;
            this.numericUpDownDayAfter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numericUpDownDayAfter.Location = new System.Drawing.Point(566, 27);
            this.numericUpDownDayAfter.Maximum = new decimal(new int[] {
            3650,
            0,
            0,
            0});
            this.numericUpDownDayAfter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDayAfter.Name = "numericUpDownDayAfter";
            this.numericUpDownDayAfter.Size = new System.Drawing.Size(99, 27);
            this.numericUpDownDayAfter.TabIndex = 3;
            this.numericUpDownDayAfter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество дней для анализа прошедших событий и дел:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество дней для анализа будущих событий и дел:";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.richTextBox1);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 29);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(886, 385);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "Справка";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(880, 379);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // timerDateControl
            // 
            this.timerDateControl.Enabled = true;
            this.timerDateControl.Interval = 1000;
            this.timerDateControl.Tick += new System.EventHandler(this.timerDateControl_Tick);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconMain.BalloonTipText = "Программа свернута в трей";
            this.notifyIconMain.BalloonTipTitle = "ORIX4";
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "Orix4";
            this.notifyIconMain.DoubleClick += new System.EventHandler(this.notifyIconMain_DoubleClick);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьПрограммыToolStripMenuItem,
            this.toolStripMenuItem9,
            this.выходИзПрограммыToolStripMenuItem});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(229, 58);
            this.contextMenuStripNotifyIcon.Text = "ORIX4";
            // 
            // открытьПрограммыToolStripMenuItem
            // 
            this.открытьПрограммыToolStripMenuItem.Name = "открытьПрограммыToolStripMenuItem";
            this.открытьПрограммыToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.открытьПрограммыToolStripMenuItem.Text = "открыть программу";
            this.открытьПрограммыToolStripMenuItem.Click += new System.EventHandler(this.открытьПрограммыToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(225, 6);
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.выходИзПрограммыToolStripMenuItem.Text = "выход из программы";
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выходИзПрограммыToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(918, 440);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(746, 485);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORIX4 (ver. 6)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageView.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOccurred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDayAfter)).EndInit();
            this.tabPageAbout.ResumeLayout(false);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.RichTextBox richTextBoxView;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.RichTextBox richTextBoxData;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.NumericUpDown numericUpDownDayAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownOccurred;
        private System.Windows.Forms.Button buttonSetDefaultValue;
        private System.Windows.Forms.Timer timerDateControl;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem открытьПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.Button buttonBak;
        private System.Windows.Forms.Button buttonUnBak;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

