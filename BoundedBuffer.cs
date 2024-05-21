using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_CS_GUI
{
    internal class BoundedBuffer
    {
        private readonly string[] buffer;
        private readonly BufferStatus[] status;
        private int writePos = 0;
        private int readPos = 0;
        private int modifyPos = 0;

        private readonly object lockObject = new object();

        public BoundedBuffer(int capacity)
        {
            buffer = new string[capacity];
            status = new BufferStatus[capacity];
            for (int i = 0; i < capacity; i++)
            {
                status[i] = BufferStatus.Empty;
            }
        }

        public void Write(string data)
        {
            lock (lockObject)
            {
                while (status[writePos] != BufferStatus.Empty)
                {
                    Monitor.Wait(lockObject);
                }

                buffer[writePos] = data;
                status[writePos] = BufferStatus.New;
                writePos = (writePos + 1) % buffer.Length;
                Monitor.PulseAll(lockObject);
            }
        }

        public void Modify(string searchString, string replacementString)
        {
            lock (lockObject)
            {
                while (status[modifyPos] != BufferStatus.New)
                {
                    Monitor.Wait(lockObject);
                }

                buffer[modifyPos] = buffer[modifyPos].Replace(searchString, replacementString);
                status[modifyPos] = BufferStatus.Checked;
                modifyPos = (modifyPos + 1) % buffer.Length;
                Monitor.PulseAll(lockObject);
            }
        }

        public string Read()
        {
            lock (lockObject)
            {
                while (status[readPos] != BufferStatus.Checked)
                {
                    Monitor.Wait(lockObject);
                }

                string data = buffer[readPos];
                status[readPos] = BufferStatus.Empty;
                readPos = (readPos + 1) % buffer.Length;
                Monitor.PulseAll(lockObject);

                return data;
            }
        }
    }
}
