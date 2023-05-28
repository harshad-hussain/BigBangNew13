using System.ComponentModel.DataAnnotations;

namespace BIgBangAssessment3.models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? Password { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
    }
}
