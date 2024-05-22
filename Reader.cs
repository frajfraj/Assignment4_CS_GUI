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
        private List<string> outputList;
        RichTextBox rtxtDest;
        ListBox lstStatus;
        public bool isRunning { get; set; }

        public Reader(BoundedBuffer buffer, List<string> outputList, RichTextBox rtxtDest, ListBox lstStatus)
        {
            this.buffer = buffer;
            this.outputList = outputList;
            this.rtxtDest = rtxtDest;
            this.lstStatus = lstStatus;
        }

        public void Read()
        {
         
            while (isRunning)
            {
                string line = buffer.Read();
                if (line == null) break; // Adjust logic to stop reading as needed

                rtxtDest.Invoke((MethodInvoker)delegate {
                    rtxtDest.AppendText(line + Environment.NewLine);
                });

                lstStatus.Invoke((MethodInvoker)delegate {
                    lstStatus.Items.Add("Reader read a line.");
                });
                
            }
            isRunning = false;
        }
    }
}
