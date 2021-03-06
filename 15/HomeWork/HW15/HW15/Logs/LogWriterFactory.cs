﻿using System;
namespace HW15
{
    public class LogWriterFactory
    {
        public ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
        {
            if (typeof(T) == typeof(ConsoleLogWriter))
            {
                return new ConsoleLogWriter();
            }
            if (typeof(T) == typeof(FileLogWriter))
            {
                return new FileLogWriter((string)parameters);
            }
            if (typeof(T) == typeof(MultipleLogWriter))
            {
                return new MultipleLogWriter((ILogWriter[]) parameters); // вернуть массив ilogwriter с параметрами
            }
            throw new InvalidOperationException("Ошибка операции");
        }
        private static LogWriterFactory _instance;
        public static LogWriterFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LogWriterFactory();
                }
                return _instance;
            }
        }
        private LogWriterFactory()
        {
        }
    }
}