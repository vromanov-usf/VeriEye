using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VeriEye.Models;

namespace VeriEye.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ExploreVeriEye()
        {
            var model = new ExploreViewModel
            {
                FbiHighlights = new List<string>
                {
                    "Iris recognition uses the unique texture of the iris to verify identity.",
                    "Modern systems use near-infrared imaging to capture detailed iris patterns.",
                    "Matching involves locating the iris, extracting features, and comparing templates."
                },
                ArticleHighlights = new List<string>
                {
                    "Iris recognition supports strong biometric verification and fraud prevention.",
                    "The process includes image capture, feature extraction, and identity matching.",
                    "This technology can support secure payments and KYC verification workflows."
                }
            };

            return View(model);
        }

        public IActionResult MerchantSolutions()
        {
            return View();
        }

        public IActionResult FinancialInstitutions()
        {
            return View();
        }

        public IActionResult AiAssistant()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Personal()
        {
            return View();
        }

        public IActionResult GetStarted()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}