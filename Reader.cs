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

        public Reader(BoundedBuffer buffer, List<string> outputList)
        {
            this.buffer = buffer;
            this.outputList = outputList;
        }

        public void ReadFromBuffer()
        {
            while (true)
            {
                string data = buffer.Read();
                if (data == null)
                    break; // Exit the loop if buffer is empty
                outputList.Add(data); // Add the read data to the output list
            }
        }
    }
}
