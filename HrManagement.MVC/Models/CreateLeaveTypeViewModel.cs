using System.ComponentModel.DataAnnotations;

namespace HrManagement.MVC.Models
{
    public class CreateLeaveTypeViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Default Number of Days")]
        public int DefauletDay { get; set; }
    }
}
