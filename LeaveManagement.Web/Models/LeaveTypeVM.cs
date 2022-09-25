using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        public string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        [Required(ErrorMessage = "Wartość jest wymagana")]
        [Range(1, 25, ErrorMessage = "Proszę podać prawidłową wartość")]
        public int? DefaultDays { get; set; }
    }
}
