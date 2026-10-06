namespace FitnessClub.Interfaces
{
    public class DrawingService
    {
        public void DrawAll(List<IDrawable> figures)
        {
            foreach (IDrawable figure in figures)
            {
                figure.Draw();
            }
        }
    }
}