using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_CS_GUI
{
    internal class Writer
    {
        private BoundedBuffer buffer;
        private List<string> lines;
        private ListBox lstStatus;
        private int id;

        
        public int writerIndex;
        Random random = new Random();
        public bool isWriting = false;
        public static int writerCounter = 0;
        

        public Writer(BoundedBuffer buffer, List<string> lines, ListBox lstStatus, int writerIndex)
        {
            this.buffer = buffer;
            this.lines = lines;
            this.writerIndex = writerIndex;
            this.lstStatus = lstStatus;


        }


        public void WriteToBuffer()
        {
            {
                while (isWriting && writerCounter < lines.Count)
                {
                    Thread.Sleep(random.Next(1000, 2000));
                    if (writerCounter < lines.Count)
                    {
                        buffer.Write(lines[writerCounter]);
                        writerCounter++;
                    }
                    lstStatus.Invoke((MethodInvoker)delegate {
                        lstStatus.Items.Add($"Writer {writerIndex} wrote a line.");
                    });

                }
                isWriting = false;
            }

        }

    }
}
