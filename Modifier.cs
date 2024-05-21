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
        private string findText, replaceText, name;
        private ListBox lstStatus;
        public bool isRunning = false;

        public Modifier(BoundedBuffer buffer, string findText, string replaceText, ListBox lstStatus, int id)
        {
            this.buffer = buffer;
            this.findText = findText;
            this.replaceText = replaceText;
            this.lstStatus = lstStatus;
            name = $"Modifier {id}";
        }

        public void ModifyBuffer()
        {
            while (isRunning)
            {
                buffer.Modify(findText, replaceText);
                lstStatus.Invoke((MethodInvoker)delegate {
                    lstStatus.Items.Add($"{name} modified a line.");
                });

                Thread.Sleep(1000);
            }
            isRunning = false;
        }

    }
}
