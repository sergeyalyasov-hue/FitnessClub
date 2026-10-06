namespace FitnessClub.Interfaces
{
    public class PaymentService
    {
        public void ProcessPayment(IPayable method, decimal amount)
        {
            method.Pay(amount);
        }
    }
}