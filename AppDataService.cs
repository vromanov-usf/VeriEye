using VeriEye.Models;

namespace VeriEye.Services
{
    public class AppDataService
    {
        public List<UserProfile> UserProfiles { get; set; } = new List<UserProfile>
        {
            new UserProfile
            {
                UserProfileId = 1,
                FullName = "Victoria Romanov",
                Email = "victoria@example.com",
                Phone = "727-123-4567",
                Address = "Clearwater, FL",
                Income = 1000000,
                Status = "Verified"
            }
        };

        public List<LinkedAccount> LinkedAccounts { get; set; } = new List<LinkedAccount>
        {
            new LinkedAccount
            {
                LinkedAccountId = 1,
                BankName = "Chase",
                AccountNickname = "Main Checking",
                AccountType = "Checking",
                MaskedAccountNumber = "****1234",
                RoutingNumber = "021000021",
                IsDefault = true
            },
            new LinkedAccount
            {
                LinkedAccountId = 2,
                BankName = "Bank of America",
                AccountNickname = "Savings",
                AccountType = "Savings",
                MaskedAccountNumber = "****5678",
                RoutingNumber = "026009593",
                IsDefault = false
            }
        };

        public List<MFAMethod> MFAMethods { get; set; } = new List<MFAMethod>
        {
            new MFAMethod
            {
                MFAMethodId = 1,
                MethodName = "SMS Verification",
                MethodType = "Phone",
                IsEnabled = true
            },
            new MFAMethod
            {
                MFAMethodId = 2,
                MethodName = "Email Verification",
                MethodType = "Email",
                IsEnabled = true
            }
        };
    }
}