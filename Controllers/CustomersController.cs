using Microsoft.AspNetCore.Mvc;
using VeriEye.Models;
using System.Collections.Generic;

namespace VeriEye.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Transactions()
        {
            var transactions = new List<VeriTransaction>
            {
                new VeriTransaction
{
    Id = 1,
    Date = "Today, 6:42 PM",
    Merchant = "Publix",
    Type = "VeriEyePay",
    Amount = "$83.29",
    Status = "Approved",
    RiskLevel = "Low"
                },
                new VeriTransaction
                {
                    Id = 2,
                    Date = "Yesterday, 6:18 PM",
                    Merchant = "Whole Foods Market",
                    Type = "VeriEyePay",
                    Amount = "$48.72",
                    Status = "Approved",
                    RiskLevel = "Low"
                },
                new VeriTransaction
                {
                    Id = 3,
                    Date = "Apr 22, 2026, 05:46 PM",
                    Merchant = "Chase ATM",
                    Type = "Cash Withdrawal Verification",
                    Amount = "$120.00",
                    Status = "Approved",
                    RiskLevel = "Low"
                },
                 new VeriTransaction
{
    Id = 4,
    Date = "Apr 21, 2026, 8:42 AM",
    Merchant = "Publix",
    Type = "VeriEyePay",
    Amount = "$3.29",
    Status = "Approved",
    RiskLevel = "Low"
                },
                new VeriTransaction
                {
                    Id = 5,
                    Date = "Apr 21, 2026, 03:20 AM",
                    Merchant = "Online Transfer",
                    Type = "Additional Verification Required",
                    Amount = "$950.00",
                    Status = "Review Required",
                    RiskLevel = "High"
                }
            };

            return View(transactions);
        }
    }
}