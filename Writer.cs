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

        public Writer(BoundedBuffer buffer, List<string> lines)
        {
            this.buffer = buffer;
            this.lines = lines;
        }

        public void WriteToBuffer()
        {
            foreach (string line in lines)
            {
                buffer.Write(line);
            }
        }
    }
}
