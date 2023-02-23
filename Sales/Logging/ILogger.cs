using System;

namespace Sales.Logging
{
    internal interface ILogger
    {
        void Log(String message);
        void Log(String message, LogLevel level);
        void Log(String message, LogLevel level, String className, String methodName);
        void Log(String message, LogLevel level, String className, String methodName, object? info);
    }
}
