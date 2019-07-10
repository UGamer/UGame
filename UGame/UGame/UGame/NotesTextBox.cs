using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    public class NotesTextBox : TextBox
    {
        public NotesTextBox()
        {
            Location = new Point(12, 28);
            Size = new Size(775, 410);
            Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Multiline = true;
            ScrollBars = ScrollBars.Both;

            Font = new Font("Century Gothic", 12);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Tab || keyData == (Keys.Shift | Keys.Tab)) return true;
            return base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                base.OnKeyDown(e);
        }
    }
}
