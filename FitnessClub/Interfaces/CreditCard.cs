namespace FitnessClub.Interfaces
{
    public class CreditCard : IPayable
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Оплата картой: " + amount);
        }
    }
}