﻿using System;
namespace HW15
{
    public class LogWriterFactory
    {
        public ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
        {

            switch (typeof(T))
            {
                case ConsoleLogWriter():
                    return new ConsoleLogWriter();
                case FileLogWriter():
                    return new FileLogWriter((string)parameters);
                case MultipleLogWriter:
                    return new MultipleLogWriter(new ConsoleLogWriter(), new FileLogWriter((string)parameters));
                default:
                    throw new InvalidOperationException("Ошибка операции");
            }
            //if (typeof(T) == typeof(ConsoleLogWriter))
            //{
            //    return new ConsoleLogWriter();
            //}
            //if (typeof(T) == typeof(FileLogWriter))
            //{
            //    return new FileLogWriter((string)parameters);
            //}
            //if (typeof(T) == typeof(MultipleLogWriter))
            //{
            //    return new MultipleLogWriter(new ConsoleLogWriter(), new FileLogWriter((string)parameters));
            //}
            //throw new InvalidOperationException("Ошибка операции");
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