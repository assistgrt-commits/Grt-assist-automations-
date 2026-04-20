using Microsoft.AspNetCore.Mvc;
using NTSPLSite.Models;

namespace NTSPLSite.Controllers;

public class CareerController : Controller
{
    private static readonly List<JobListing> Jobs = new()
    {
        new() { Title = "Senior ASP.NET Core Developer", Department = "Engineering", Location = "Bhubaneswar / Remote", Type = "Full-Time", Experience = "4-7 years", Description = "We are looking for a skilled ASP.NET Core developer to build and maintain enterprise web applications. You will work closely with architects and product owners to deliver high-quality solutions.", Skills = new() { "ASP.NET Core", "C#", "SQL Server", "REST APIs", "Entity Framework", "Git" } },
        new() { Title = "React / Angular Frontend Developer", Department = "Engineering", Location = "Bhubaneswar", Type = "Full-Time", Experience = "3-5 years", Description = "Join our frontend team to craft exceptional user interfaces for enterprise and government applications using modern JavaScript frameworks.", Skills = new() { "React.js", "Angular", "TypeScript", "CSS3", "REST APIs", "Git" } },
        new() { Title = "Mobile App Developer (Flutter)", Department = "Engineering", Location = "Bhubaneswar / Remote", Type = "Full-Time", Experience = "2-4 years", Description = "Develop and maintain cross-platform mobile applications for iOS and Android using Flutter, with a focus on performance and user experience.", Skills = new() { "Flutter", "Dart", "Firebase", "REST APIs", "Android / iOS" } },
        new() { Title = "SQL Server / Database Administrator", Department = "Engineering", Location = "Bhubaneswar", Type = "Full-Time", Experience = "3-6 years", Description = "Manage and optimize SQL Server databases for performance, availability, and security across multiple enterprise client environments.", Skills = new() { "SQL Server", "T-SQL", "SSRS", "Performance Tuning", "Backup & Recovery" } },
        new() { Title = "Digital Marketing Specialist", Department = "Marketing", Location = "Bhubaneswar", Type = "Full-Time", Experience = "2-4 years", Description = "Drive organic and paid digital growth for our clients through SEO, SEM, social media campaigns, and data-driven content strategies.", Skills = new() { "SEO", "Google Ads", "Social Media", "Google Analytics", "Content Marketing" } },
        new() { Title = "Business Development Executive", Department = "Sales", Location = "Bhubaneswar / Pan India", Type = "Full-Time", Experience = "2-5 years", Description = "Generate new business opportunities by identifying prospects, conducting demos, and closing deals for our IT services and software products.", Skills = new() { "B2B Sales", "CRM", "Proposal Writing", "Client Relationship", "IT Services Knowledge" } },
        new() { Title = "UI / UX Designer", Department = "Design", Location = "Bhubaneswar", Type = "Full-Time", Experience = "2-4 years", Description = "Create intuitive, visually compelling interfaces through research, wireframing, prototyping, and close collaboration with development teams.", Skills = new() { "Figma", "Adobe XD", "User Research", "Prototyping", "HTML/CSS" } },
        new() { Title = "Python / AI-ML Engineer", Department = "Engineering", Location = "Bhubaneswar / Remote", Type = "Full-Time", Experience = "3-5 years", Description = "Design and deploy machine learning models, NLP pipelines, and AI-powered features integrated into enterprise software platforms.", Skills = new() { "Python", "TensorFlow / PyTorch", "NLP", "Azure AI / AWS ML", "REST APIs" } },
    };

    public IActionResult Index()
    {
        ViewBag.Jobs = Jobs;
        ViewBag.Departments = Jobs.Select(j => j.Department).Distinct().OrderBy(d => d).ToList();
        return View();
    }

    public IActionResult Detail(int id)
    {
        if (id < 0 || id >= Jobs.Count) return NotFound();
        ViewBag.Job = Jobs[id];
        ViewBag.JobId = id;
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Apply(string name, string email, string phone, string jobTitle, string coverLetter)
    {
        TempData["Success"] = $"Thank you {name}! Your application for <strong>{jobTitle}</strong> has been received. Our HR team will review and contact you within 5 business days.";
        return RedirectToAction("Index");
    }
}
