namespace FitnessClub.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Type { get; set; } = "";
        public int ClientId { get; set; }
    }
}