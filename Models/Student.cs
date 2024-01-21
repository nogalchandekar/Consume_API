using System.ComponentModel.DataAnnotations;

namespace ConsumeAPI.Models

{
    public class Student
    {

        [Key]
        public int id { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]

        public string lastName { get; set; }
        [Required]

        public int rollNo { get; set; }
        [Required]

        public string gender { get; set; }
        [Required]

        public string email { get; set; }
        [Required]

        public string password { get; set; }
        [Required]

        public string department { get; set; }

    }
}
