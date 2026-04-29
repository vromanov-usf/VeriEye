namespace VeriEye.Models
{
    public class DashboardViewModel
    {
        public string UserName { get; set; } = "";
        public int MfaMethodCount { get; set; }
        public int LinkedAccountCount { get; set; }
        public int ActiveBankAccessCount { get; set; }
        public List<VeriTransaction> RecentTransactions { get; set; } = new();
    }
}