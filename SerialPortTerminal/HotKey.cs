using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortTerminal
{
    public class HotKeyClass
    {
        public string IniName;
        public int ID;
        public Keys keyModifiers;
        public Keys keys;
        public string ControlName;

        public HotKeyClass(string IniName, int ID, Keys keyModifiers, Keys keys, string ControlName)
        {
            this.IniName = IniName;
            this.ID = ID;
            this.keyModifiers = keyModifiers;
            this.keys = keys;
            this.ControlName = ControlName;
        }

    };
}
