using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortTerminal
{
    public partial class UnderLineTextBox : TextBox
    {
        public UnderLineTextBox()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            AutoSize = false;
            this.Controls.Add(new Label()
            {
                Height = 3,
                Dock = DockStyle.Bottom,
                BackColor = Color.Gray,
            });
        }
    }
}
