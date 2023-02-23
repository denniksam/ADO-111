using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Logging
{
    internal class FileLogger : ILogger
    {
        private readonly String filename;

        public FileLogger()
        {
            String projectPath = AppContext.BaseDirectory
                .Substring(0, AppContext.BaseDirectory.IndexOf(@"\bin\"));

            filename = Path.Combine(projectPath, "logs.txt");
        }

        public void Log(string message)
        {
            this.Log(message, LogLevel.Debug);
        }

        public void Log(string message, LogLevel level)
        {
            this.Log(message, level, "", "");
        }

        public void Log(string message, LogLevel level, string className, string methodName)
        {
            this.Log(message,level, className, methodName, null);
        }

        public void Log(string message, LogLevel level, string className, string methodName, object? info)
        {
            File.AppendAllText(filename,
                $"{DateTime.Now} | {level} | {message} | {className}.{methodName} | {info}\r\n");
        }
    }
}
