using Microsoft.AspNetCore.Mvc;
using NTSPLSite.Models;

namespace NTSPLSite.Controllers;

public class ContactController : Controller
{
    public IActionResult Index() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Submit(ContactForm form)
    {
        if (!ModelState.IsValid)
        {
            TempData["Error"] = "Please fill in all required fields.";
            return View("Index", form);
        }
        TempData["Success"] = "Thank you! Your message has been received. We will get back to you within 1 business day.";
        return RedirectToAction("Index");
    }
}
