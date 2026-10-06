namespace FitnessClub.Interfaces
{
    public class Cube : I3DShape
    {
        public double Side = 3;

        public double GetArea()
        {
            return 6 * Side * Side;
        }

        public double GetPerimeter()
        {
            return 12 * Side;
        }

        public double GetVolume()
        {
            return Side * Side * Side;
        }
    }
}