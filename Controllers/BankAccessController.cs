using Microsoft.AspNetCore.Mvc;
using VeriEye.Models;

namespace VeriEye.Controllers
{
    public class BankAccessController : Controller
    {
        private static List<BankAccess> _accessList = new()
        {
            new BankAccess { BankAccessId = 1, InstitutionName = "Chase", AccessLevel = "Full Access", IsActive = true },
            new BankAccess { BankAccessId = 2, InstitutionName = "Bank of America", AccessLevel = "Transaction Access", IsActive = true }
        };

        public IActionResult Index() => View(_accessList);

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(BankAccess access)
        {
            access.BankAccessId = _accessList.Any() ? _accessList.Max(x => x.BankAccessId) + 1 : 1;
            _accessList.Add(access);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var access = _accessList.FirstOrDefault(x => x.BankAccessId == id);
            if (access == null) return NotFound();
            return View(access);
        }

        [HttpPost]
        public IActionResult Edit(BankAccess access)
        {
            var existing = _accessList.FirstOrDefault(x => x.BankAccessId == access.BankAccessId);
            if (existing == null) return NotFound();

            existing.InstitutionName = access.InstitutionName;
            existing.AccessLevel = access.AccessLevel;
            existing.IsActive = access.IsActive;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var access = _accessList.FirstOrDefault(x => x.BankAccessId == id);
            if (access == null) return NotFound();
            return View(access);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var access = _accessList.FirstOrDefault(x => x.BankAccessId == id);
            if (access != null) _accessList.Remove(access);
            return RedirectToAction(nameof(Index));
        }
    }
}