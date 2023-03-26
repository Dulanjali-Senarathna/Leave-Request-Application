using System.ComponentModel.DataAnnotations;

namespace Leave_Request_Application.Models
{
    public class LeaveTypeVM
    {
        public int id {  get; set; }

        
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please Enter a Valid Number")]
        public int DefaultDays { get; set; }
    }
}
