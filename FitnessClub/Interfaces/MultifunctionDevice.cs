namespace FitnessClub.Interfaces
{
    public class MultifunctionDevice : IPrinter, IScanner, IFax
    {
        public void Print()
        {
            Console.WriteLine("Печать");
        }

        public void Scan()
        {
            Console.WriteLine("Сканирование");
        }

        public void Fax()
        {
            Console.WriteLine("Отправка факса");
        }
    }
}