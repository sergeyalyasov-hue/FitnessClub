namespace FitnessClub.Interfaces
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("File: " + message);
        }
    }
}