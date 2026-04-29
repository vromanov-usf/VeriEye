using Microsoft.AspNetCore.Mvc;
using VeriEye.Models;

namespace VeriEye.Controllers
{
    public class LinkedAccountsController : Controller
    {
        private static List<LinkedAccount> accounts = new List<LinkedAccount>
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
        public IActionResult Index() => View(accounts);

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(LinkedAccount account)
        {
            account.LinkedAccountId = accounts.Any() ? accounts.Max(x => x.LinkedAccountId) + 1 : 1;
            accounts.Add(account);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var account = accounts.FirstOrDefault(x => x.LinkedAccountId == id);
            if (account == null) return NotFound();
            return View(account);
        }

        [HttpPost]
        public IActionResult Edit(LinkedAccount account)
        {
            var existing = accounts.FirstOrDefault(x => x.LinkedAccountId == account.LinkedAccountId);
            if (existing == null) return NotFound();

            existing.BankName = account.BankName;
            existing.AccountNickname = account.AccountNickname;
            existing.AccountType = account.AccountType;
            existing.MaskedAccountNumber = account.MaskedAccountNumber;
            existing.IsDefault = account.IsDefault;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var account = accounts.FirstOrDefault(x => x.LinkedAccountId == id);
            if (account == null) return NotFound();
            return View(account);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var account = accounts.FirstOrDefault(x => x.LinkedAccountId == id);
            if (account != null) accounts.Remove(account);
            return RedirectToAction(nameof(Index));
        }
    }
}