namespace HW15
{
    class LogWriterFactory
    {
        
        public ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
        {
            
            if (typeof(T) == typeof(ConsoleLogWriter))
                return new ConsoleLogWriter();

            if (typeof(T) == typeof(FileLogWriter))
              
                return new FileLogWriter(parameters.ToString());

            if (typeof(T) == typeof(MultipleLogWriter))
                return new MultipleLogWriter(new ConsoleLogWriter(), new FileLogWriter(parameters.ToString()));

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