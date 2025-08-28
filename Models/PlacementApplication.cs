using System.ComponentModel.DataAnnotations;

namespace PlacementApp.Models
{
    public class PlacementApplication
    {
        public int Id { get; set; }

        [Display(Name = "Student ID")]
        public string StudentID { get; set; }

        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Display(Name = "Placement Role")]
        public string PlacementRole { get; set; }
    }
}