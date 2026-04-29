namespace VeriEye.Models
{
    public class VeriTransaction
    {
        public int Id { get; set; }
        public string Date { get; set; } = "";
        public string Merchant { get; set; } = "";
        public string Type { get; set; } = "";
        public string Amount { get; set; } = "";
        public string Status { get; set; } = "";
        public string RiskLevel { get; set; } = "";
    }
}