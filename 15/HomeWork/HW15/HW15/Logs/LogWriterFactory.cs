namespace HW15
{
    class LogWriterFactory
    {
        public ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
        {

            if (typeof(T) == typeof(ConsoleLogWriter))
                return new ConsoleLogWriter();

            if (typeof(T) == typeof(FileLogWriter))
               
                return new FileLogWriter("F:\\C#\\nordic-it-cs-q1\\15\\logs.log");

            if (typeof(T) == typeof(MultipleLogWriter))
                return new MultipleLogWriter(new ConsoleLogWriter(),new FileLogWriter("F:\\C#\\nordic-it-cs-q1\\15\\logs.log"));
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