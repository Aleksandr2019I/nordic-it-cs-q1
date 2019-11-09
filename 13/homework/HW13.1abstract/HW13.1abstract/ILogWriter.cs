namespace HW13._1abstract
{
    public interface ILogWriter

    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }

}
