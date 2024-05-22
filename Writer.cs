using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment4_CS_GUI
{
    internal class Writer
    {
        private BoundedBuffer buffer;
        private List<string> lines;
        private ListBox lstStatus;
        
        public static int writerCounter = 0;
        private string name;

        public bool isRunning { get; set; }


        public Writer(BoundedBuffer buffer, List<string> lines, ListBox lstStatus, int writerIndex)
        {
            this.buffer = buffer;
            this.lines = lines;
            this.lstStatus = lstStatus;
            name = $"Writer {writerIndex}";

        }


        public void WriteToBuffer()
        {
            while (isRunning)
            {
                Thread.Sleep(1000);
                isRunning = buffer.Write(lines);

                lstStatus.Invoke((MethodInvoker)delegate {
                    lstStatus.Items.Add($"{name} wrote a line.");
                });

            }
        }

    }
}
