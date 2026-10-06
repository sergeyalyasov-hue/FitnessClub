namespace FitnessClub.Interfaces
{
    public class WorkService
    {
        public void DoWork(ILogger logger)
        {
            logger.Log("Работа выполнена");
        }
    }
}