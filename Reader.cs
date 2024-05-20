using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_CS_GUI
{
    internal class Reader
    {
        private BoundedBuffer buffer;
        private RichTextBox rtxtDest;
        private ListBox lstStatus;

        public Reader(BoundedBuffer buffer, RichTextBox rtxtDest, ListBox lstStatus)
        {
            this.buffer = buffer;
            this.rtxtDest = rtxtDest;
            this.lstStatus = lstStatus;
        }

        public void Read()
        {
            while (true)
            {
                string data = buffer.Read();
                rtxtDest.Invoke((MethodInvoker)delegate {
                    rtxtDest.AppendText(data + "\n");
                });
                lstStatus.Invoke((MethodInvoker)delegate {
                    lstStatus.Items.Add("Reader read a line.");
                });
            }
        }
    }
}
