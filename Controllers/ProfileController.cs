using Microsoft.AspNetCore.Mvc;
using VeriEye.Models;
using VeriEye.Services;

namespace VeriEye.Controllers
{
    public class ProfileController : Controller
    {
        private readonly AppDataService _data;

        public ProfileController(AppDataService data)
        {
            _data = data;
        }

        public IActionResult Index()
        {
            return View(_data.UserProfiles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserProfile profile)
        {
            profile.UserProfileId = _data.UserProfiles.Any()
                ? _data.UserProfiles.Max(x => x.UserProfileId) + 1
                : 1;

            _data.UserProfiles.Add(profile);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var profile = _data.UserProfiles.FirstOrDefault(x => x.UserProfileId == id);

            if (profile == null)
                return NotFound();

            return View(profile);
        }

        [HttpPost]
        public IActionResult Edit(UserProfile updatedProfile)
        {
            var profile = _data.UserProfiles
                .FirstOrDefault(x => x.UserProfileId == updatedProfile.UserProfileId);

            if (profile == null)
                return NotFound();

            profile.FullName = updatedProfile.FullName;
            profile.Email = updatedProfile.Email;
            profile.Phone = updatedProfile.Phone;
            profile.Address = updatedProfile.Address;
            profile.Income = updatedProfile.Income;
            profile.Status = updatedProfile.Status;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var profile = _data.UserProfiles.FirstOrDefault(x => x.UserProfileId == id);

            if (profile == null)
                return NotFound();

            return View(profile);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var profile = _data.UserProfiles.FirstOrDefault(x => x.UserProfileId == id);

            if (profile != null)
            {
                _data.UserProfiles.Remove(profile);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}