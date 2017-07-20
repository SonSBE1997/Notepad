using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodepad.DAO
{
    class OpenFileDocument
    {

        private static OpenFileDocument instance;

        public static OpenFileDocument Instance
        {
            get
            {
                if (instance == null) instance = new OpenFileDocument();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private OpenFileDocument() { }

        public string OpenFile(string fileName, Encoding encoding)
        {
            StringBuilder data = new StringBuilder();
            StreamReader reader = new StreamReader(fileName, encoding);
            //string line = "";
            //while ((line = reader.ReadLine()) != null)
            //{
            //    data.Append(line);
            //    data.Append("\r\n");
            //}
            //data.Remove(data.Length - 2, 2);
            data.Append(reader.ReadToEnd());
            reader.Close();
            return data.ToString();
        }
    }
}
