using Microsoft.AspNetCore.Mvc;
using VeriEye.Models;
using VeriEye.Services;

namespace VeriEye.Controllers
{
    public class MFAController : Controller
    {
        private readonly AppDataService _data;

        public MFAController(AppDataService data)
        {
            _data = data;
        }

        public IActionResult Index()
        {
            return View(_data.MFAMethods);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MFAMethod method)
        {
            method.MFAMethodId = _data.MFAMethods.Any()
                ? _data.MFAMethods.Max(x => x.MFAMethodId) + 1
                : 1;

            method.DateAdded = DateTime.Now;

            _data.MFAMethods.Add(method);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var method = _data.MFAMethods.FirstOrDefault(x => x.MFAMethodId == id);

            if (method == null)
                return NotFound();

            return View(method);
        }

        [HttpPost]
        public IActionResult Edit(MFAMethod method)
        {
            var existing = _data.MFAMethods.FirstOrDefault(x => x.MFAMethodId == method.MFAMethodId);

            if (existing == null)
                return NotFound();

            existing.MethodName = method.MethodName;
            existing.MethodType = method.MethodType;
            existing.IsEnabled = method.IsEnabled;
            existing.IsDefault = method.IsDefault;
            existing.DateAdded = method.DateAdded;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var method = _data.MFAMethods.FirstOrDefault(x => x.MFAMethodId == id);

            if (method == null)
                return NotFound();

            return View(method);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var method = _data.MFAMethods.FirstOrDefault(x => x.MFAMethodId == id);

            if (method != null)
            {
                _data.MFAMethods.Remove(method);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}