using System.ComponentModel.DataAnnotations;

namespace HRMS.DataAccess.Models
{
    public class Candidate : HRMSBase
    {
        public long Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Candidate FirstName is required")]
        public string? FirstName { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Candidate LastName is required")]
        public string? LastName { get; set; }

        [StringLength(300)]
        [Required(ErrorMessage = "Candidate EmailAddress is required")]
        [EmailAddress]
        public string? EmailAddress { get; set; }

        [MaxLength(10)]
        [Required(ErrorMessage = "Candidate MobileNumber is required")]
        public int? MobileNumber { get; set; }

        [Required(ErrorMessage = "Candidate TotalExperience is required")]
        public string? TotalExperience { get; set; }

        [Required(ErrorMessage = "Candidate RelevantExperience is required")]
        public string? RelevantExperience { get; set; }

        [Required(ErrorMessage = "Candidate CurrentSalary is required")]
        public long? CurrentSalary { get; set; }

        [Required(ErrorMessage = "Candidate ExpectedSalary is required")]
        public long? ExpectedSalary { get; set; }

        [Required(ErrorMessage = "Candidate NoticePeriod is required")]
        public int? NoticePeriod { get; set; }
    }
}
