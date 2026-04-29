namespace VeriEye.Models
{
    public class MFAMethod
    {
        public int MFAMethodId { get; set; }

        public string MethodName { get; set; } = "";

        public string MethodType { get; set; } = "";

        public bool IsEnabled { get; set; }

        public bool IsDefault { get; set; }

        public DateTime DateAdded { get; set; }
    }
}