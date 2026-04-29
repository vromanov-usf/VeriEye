using System.ComponentModel.DataAnnotations;

namespace VeriEye.Models
{
    public class LinkedAccount
    {
        public int LinkedAccountId { get; set; }

        [Display(Name = "Bank Name")]
        public string BankName { get; set; } = "";

        [Display(Name = "Account Nickname")]
        public string AccountNickname { get; set; } = "";

        [Display(Name = "Account Type")]
        public string AccountType { get; set; } = "";

        [Display(Name = "Masked Account Number")]
        public string MaskedAccountNumber { get; set; } = "";

        [Display(Name = "Routing Number")]
        public string RoutingNumber { get; set; } = "";

        [Display(Name = "Default Account")]
        public bool IsDefault { get; set; }
    }
}