using System;
using System.Windows.Forms;

namespace kz.tsnproff.Orix4.forms
{
    /// <summary>
    /// RichTextBox с контекстным меню
    /// </summary>
    class RichTextBoxContextMenu : ContextMenuStrip
    {
        private RichTextBox textBox;

        public RichTextBoxContextMenu(RichTextBox textBox, bool isInsertFromBuffer)
        {
            this.textBox = textBox;

            addMenuItem("в начало", InStartEventHandler);
            addMenuItem("в конец", InEndEventHandler);
            addMenuSeparator();
            addMenuItem("выделить все", SelectAllEventHandler);
            addMenuItem("скопировать выделение в буфер", CopyInBufferEventHandler);

            if (isInsertFromBuffer)
            {
                addMenuSeparator();
                addMenuItem("вставить данные из буфера", CopyFromBufferEventHandler);
            }
        }

        private void addMenuItem(string text, EventHandler eventHandler)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem();
            menuItem.Text = text;
            menuItem.Click += eventHandler;
            this.Items.Add(menuItem);
        }

        private void addMenuSeparator()
        {
            ToolStripSeparator menuItem = new ToolStripSeparator();
            this.Items.Add(menuItem);
        }

        private void InStartEventHandler(object sender, EventArgs e)
        {
            textBox.Focus();
            textBox.SelectionStart = 0;
        }

        private void InEndEventHandler(object sender, EventArgs e)
        {
            textBox.Focus();
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void SelectAllEventHandler(object sender, EventArgs e)
        {
            textBox.Focus();
            textBox.SelectAll();
        }

        private void CopyInBufferEventHandler(object sender, EventArgs e)
        {
            textBox.Focus();
            textBox.Copy();
        }

        private void CopyFromBufferEventHandler(object sender, EventArgs e)
        {
            textBox.Focus();
            textBox.SelectAll();
            textBox.Paste();
        }
    }
}
