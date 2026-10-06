namespace FitnessClub.Api.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; } = "";

        public string PassHash { get; set; } = "";
    }
}