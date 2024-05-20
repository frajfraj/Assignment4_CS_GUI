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

        public Writer(BoundedBuffer buffer, List<string> lines, ListBox lstStatus, int id)
        {
            this.buffer = buffer;
            this.lines = lines;
            this.lstStatus = lstStatus;
            this.id = id;
        }

        public void Write()
        {
            foreach (string line in lines)
            {
                buffer.Write(line);
                lstStatus.Invoke((MethodInvoker)delegate {
                    lstStatus.Items.Add($"Writer {id} wrote a line.");
                });
            }
        }
    }
}
