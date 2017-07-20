using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodepad.DAO
{
    class SaveFileDocument
    {
        private static SaveFileDocument instance;

        public static SaveFileDocument Instance
        {
            get
            {
                if (instance == null) instance = new SaveFileDocument();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private SaveFileDocument() { }

        public void SaveFile(string fileName, Encoding encoding, string data)
        {
            StreamWriter writer = new StreamWriter(fileName, false, encoding);
            writer.Write(data);
            writer.Close();
        }
    }
}
