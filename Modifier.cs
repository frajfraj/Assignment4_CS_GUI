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

        public Modifier(BoundedBuffer buffer) 
        { 
            this.buffer = buffer;
        }

        public void ModifyBuffer(string findText, string replaceText)
        {
            while (true)
            {
                string data = buffer.Read();
                if (data == null)
                    break; // går ur loopen om buffern är tom
                string modifiedData = ModifyData(data, findText, replaceText);
                buffer.Write(modifiedData); // skriver in den nya datan
            }
        }

        private string ModifyData(string data, string findText, string replaceText)
        {
            // hittar och ersätter. Retunerar den modifierade datan
            string modifiedData = data.Replace(findText, replaceText);
            return modifiedData;
        }
    }
}
