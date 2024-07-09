using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement_6.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name = "Start Date")]

        public DateTime? StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        [DisplayName("Leave Type")]
        public SelectList? LeaveTypes { get; set; }
        [Required]
        public int LeaveTypeId { get; set; }
        [Display(Name = "Request comments")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //List<ValidationResult> result = new List<ValidationResult>();
            //if (StartDate > EndDate)
            //{

            //    result.Add(new ValidationResult("Start date should be lesser than end date"));
            //}

            //return result;

            if (StartDate > EndDate)
            {

                yield return new ValidationResult("Start date should be lesser than end date");
            }

        }
    }
}
