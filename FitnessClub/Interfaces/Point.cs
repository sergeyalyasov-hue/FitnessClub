namespace FitnessClub.Interfaces
{
    public class Point : IMovable
    {
        public int X;
        public int Y;

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}