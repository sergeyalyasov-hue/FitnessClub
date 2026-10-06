namespace FitnessClub.Interfaces
{
    public class ShapeService
    {
        public void PrintShapeInfo(IShape shape)
        {
            Console.WriteLine("Площадь: " + shape.GetArea());
            Console.WriteLine("Периметр: " + shape.GetPerimeter());
        }
    }
}