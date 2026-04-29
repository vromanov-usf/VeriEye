using System.ComponentModel.DataAnnotations;

namespace VeriEye.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; } = "";

        [Display(Name = "Email Address")]
        public string Email { get; set; } = "";

        [Display(Name = "Phone Number")]
        public string Phone { get; set; } = "";

        [Display(Name = "Residential Address")]
        public string Address { get; set; } = "";

        [Display(Name = "Annual Income")]
        public decimal Income { get; set; }
        public string Status { get; set; } = "Verified";
    }
}