using System.ComponentModel.DataAnnotations;

namespace BIgBangAssessment3.models
{
  
        public class Hotel
        {
            [Key]
            public int Hotel_Id { get; set; }
            public string? Hotel_Name { get; set; }

            [DataType(DataType.PhoneNumber)]
            public string? Contact { get; set; }
            public string? Hotel_Location { get; set; }
            public ICollection<Room>? Rooms { get; set; }
        }
    }

