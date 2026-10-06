namespace FitnessClub.Interfaces
{
    public class Cash : IPayable
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Оплата наличными: " + amount);
        }
    }
}