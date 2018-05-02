using System.Drawing;
using System.Windows.Forms;
using kz.tsnproff.Orix4.model;

namespace kz.tsnproff.Orix4.utils.impl
{
    class RichTextBoxOutput : IOutput
    {
        Color[] _COLORS = { Color.Black, Color.Green, Color.Blue, Color.DarkOliveGreen, Color.Red, 
                              Color.Maroon};
        RichTextBox richTextBox;

        public RichTextBoxOutput(RichTextBox richTextBox)
        {
            this.richTextBox = richTextBox;
        }

        public void println(string text)
        {
            richTextBox.AppendText(text + "\n");
        }

        private Color defineColor(Const.EElementType elementType)
        {
            switch (elementType)
            {
                case Const.EElementType.Default: return _COLORS[0];
                case Const.EElementType.Today: return _COLORS[1];
                case Const.EElementType.After: return _COLORS[2];
                case Const.EElementType.Occurred: return _COLORS[3];
                case Const.EElementType.CompletedTask: return _COLORS[5];
                case Const.EElementType.Task: return _COLORS[4];
                default: return _COLORS[0];
            }
        }

        public void println(string text, Const.EElementType elementType)
        {
            richTextBox.SelectionStart = richTextBox.TextLength;
            richTextBox.SelectionLength = 0;
            richTextBox.SelectionColor = defineColor(elementType);
            richTextBox.AppendText(text + "\n");
            richTextBox.SelectionColor = richTextBox.ForeColor;
        }

    }
}
