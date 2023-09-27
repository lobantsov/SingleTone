using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.ComTypes;


namespace lab10.Class
{
    internal class DocumentSaver
    {
        private static DocumentSaver _instance;
        private string path;
        private string Name;
        DocumentSaver(string Name)
        {
            path = @"Repository\"+Name+".txt";
            this.Name = Name;
        }
        public static DocumentSaver GetInstance(string Name)
        {
            return _instance ?? (_instance = new DocumentSaver(Name));
        }

        public void Save(StringBuilder log)
        {
            Stream stream;
            if (File.Exists(path))
            {
                 stream = File.Open(path, FileMode.Append, FileAccess.Write);
            }
            else
            {
                 stream = File.Open(path, FileMode.Create, FileAccess.Write);
            }
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(log.ToString());
            writer.Close();
        }

    }
}
