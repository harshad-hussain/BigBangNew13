using System.ComponentModel.DataAnnotations;

namespace BIgBangAssessment3.models
{
    public class Reservation
    {
        [Key]
        public int Reservation_Id { get; set; }
        public String? Hotel_Name { get; set; }
        public int? Room_Number { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
