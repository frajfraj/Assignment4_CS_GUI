using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_CS_GUI
{
    internal class BoundedBuffer
    {
        private List<string> buffer;
        private int maxsize;
        private object lockObject = new object();

        public BoundedBuffer(int maxsize)
        {
            this.maxsize = maxsize;
            buffer = new List<string>();
        }

        public void Write(string data)
        {
            Monitor.TryEnter(lockObject);
            
                //Väntar medans buffern är full
                while (buffer.Count >= maxsize)
                {
                    Monitor.Wait(lockObject);
                }
                buffer.Add(data);
                Monitor.PulseAll(lockObject);

            Monitor.Exit(lockObject);
        }

        public string Read()
        {
            lock (lockObject)
            {
                //Väntar medans buffern är tom
                while (buffer.Count == 0)
                {
                    Monitor.Wait(lockObject);
                }

                string data = buffer[0];
                buffer.RemoveAt(0);
                Monitor.PulseAll(lockObject);
                return data;
            }
        }
    }
}
