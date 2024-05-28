using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement_6.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default number of days")]
        [Required]
        public int DefaultDays { get; set; }
    }
}
