using System.ComponentModel.DataAnnotations;

namespace Leave_Request_Application.Models
{
    public class LeaveTypeVM
    {
        public int id {  get; set; }

        [Display(Name = "Leave Type Name")]
        public string Name { get; set; }

        [Display(Name = "Default Number Of Days")]
        public int DefaultDays { get; set; }
    }
}
