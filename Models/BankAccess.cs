namespace VeriEye.Models
{
    public class BankAccess
    {
        public int BankAccessId { get; set; }
        public string InstitutionName { get; set; } = "";
        public string AccessLevel { get; set; } = "";
        public bool IsActive { get; set; }
    }
}