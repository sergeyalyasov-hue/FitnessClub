namespace FitnessClub.Interfaces
{
    public class Circle : IDrawable, IShape
    {
        public double Radius = 5;

        public void Draw()
        {
            Console.WriteLine("Рисуем круг");
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}