using Microsoft.AspNetCore.Mvc;
using VeriEye.Models;
using System.Collections.Generic;

namespace VeriEye.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var transactions = new List<VeriTransaction>
            {
                new VeriTransaction
                {
                    Id = 1,
                    Date = "Today, 9:42 AM",
                    Merchant = "VeriEye Pay",
                    Type = "Login Authentication",
                    Amount = "$0.00",
                    Status = "Approved",
                    RiskLevel = "Low"
                },
                new VeriTransaction
                {
                    Id = 2,
                    Date = "Yesterday, 6:18 PM",
                    Merchant = "Whole Foods Market",
                    Type = "Iris Payment",
                    Amount = "$48.72",
                    Status = "Approved",
                    RiskLevel = "Low"
                }
            };

            return View(transactions);
        }
    }
}