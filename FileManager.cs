using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_CS_GUI
{
    class FileManager
    {
        //Retrieve data from a textfile to arraylist
        //As an alternative, you can use TextReader 
        //1. open the file
        //2. get data from file
        //3. close file

        public List<string> ReadFromTextFile(string fileName, out string errMessage)
        {
            errMessage = string.Empty;

            StreamReader reader = null;
            List<string> lines = new List<string>();

            //Open file for reading -  File must exit - otherwise exception is thrown
            using (reader = new StreamReader(fileName, Encoding.UTF8))
            {
                try
                {
                    while (!reader.EndOfStream) //read to end of file
                    {
                        //read a line of text
                        string strLine = reader.ReadLine(); //read the whole row
                        lines.Add(strLine);
                    }

                }
                catch (Exception e)
                {
                    errMessage = e.Message;
                    return null;
                }
            }
            return lines;
        }
    }
     
}
