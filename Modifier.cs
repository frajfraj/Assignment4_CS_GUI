using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_CS_GUI
{
    internal class Modifier
    {
        private BoundedBuffer buffer;
        private string findText;
        private string replaceText;
        private ListBox lstStatus;
        private int id;

        public Modifier(BoundedBuffer buffer, string findText, string replaceText, ListBox lstStatus, int id)
        {
            this.buffer = buffer;
            this.findText = findText;
            this.replaceText = replaceText;
            this.lstStatus = lstStatus;
            this.id = id;
        }

        public void Modify()
        {
            while (true)
            {
                buffer.Modify(findText, replaceText);
                lstStatus.Invoke((MethodInvoker)delegate {
                    lstStatus.Items.Add($"Modifier {id} modified a line.");
                });
            }
        }
    }
}
