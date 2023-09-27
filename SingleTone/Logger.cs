using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Class
{
    public class Logger
    {
        private static Logger instance;
        private DocumentSaver docSave;
        StringBuilder sb;
        Logger(string Name)
        {
            sb = new StringBuilder();
            docSave = DocumentSaver.GetInstance(Name);
        }
        public static Logger GetInstance(string Name)
        {
            return instance ?? (instance = new Logger(Name));
        }

        public void AddLogg(string logg)
        {
            sb.Append(logg);
            sb.AppendLine();
        }

        public void Save()
        {
            docSave.Save(sb);
            sb.Clear();
        }
    }
}
