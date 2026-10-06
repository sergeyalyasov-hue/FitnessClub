namespace FitnessClub.Interfaces
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Console: " + message);
        }
    }
}