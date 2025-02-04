using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    public class TXTLog : ILog
    {
        private string FilePath;

        public TXTLog(string filePath)
        {
            FilePath = filePath;
        }

        public void WriteLog(string message)
        {
            File.AppendAllText(FilePath, message + Environment.NewLine);
        }

        void ILog.Write_Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}
