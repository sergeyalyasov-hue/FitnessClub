namespace FitnessClub.Interfaces
{
    public class Rectangle : IDrawable, IShape
    {
        public double Width = 4;
        public double Height = 6;

        public void Draw()
        {
            Console.WriteLine("Рисуем прямоугольник");
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}