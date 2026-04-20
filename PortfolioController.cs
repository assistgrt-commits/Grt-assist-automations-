using Microsoft.AspNetCore.Mvc;
using NTSPLSite.Models;

namespace NTSPLSite.Controllers;

public class PortfolioController : Controller
{
    private static readonly List<PortfolioItem> AllProjects = new()
    {
        new() { Title = "Mining Operations Portal", Category = "Enterprise Web", Technology = "ASP.NET Core, SQL Server, Angular", Description = "Comprehensive operations management portal for large-scale mining enterprises with real-time monitoring, shift management, and production reporting.", Industry = "Mining & Resources", ImageUrl = "https://images.pexels.com/photos/1108101/pexels-photo-1108101.jpeg?w=600" },
        new() { Title = "Government e-Services Platform", Category = "Government", Technology = "ASP.NET MVC, Oracle, Bootstrap", Description = "Citizen-facing e-governance portal enabling online application, document submission, status tracking, and certificate delivery for state departments.", Industry = "Government", ImageUrl = "https://images.pexels.com/photos/3183150/pexels-photo-3183150.jpeg?w=600" },
        new() { Title = "Fleet GPS Tracking Dashboard", Category = "IoT & Tracking", Technology = "React, ASP.NET Core, GPS APIs", Description = "Real-time fleet management dashboard with live map tracking, geo-fencing alerts, driver behavior analysis, and maintenance scheduling.", Industry = "Logistics", ImageUrl = "https://images.pexels.com/photos/1427541/pexels-photo-1427541.jpeg?w=600" },
        new() { Title = "Digital Signature Integration Suite", Category = "PKI / Security", Technology = "C#, DSC SDK, REST API", Description = "Enterprise PKI solution enabling digital signing of official documents across multiple departments with audit trail and compliance reporting.", Industry = "Finance & Legal", ImageUrl = "https://images.pexels.com/photos/60504/security-protection-anti-virus-software-60504.jpeg?w=600" },
        new() { Title = "BI Analytics Platform", Category = "Business Intelligence", Technology = "Power BI, SQL Server, SSRS", Description = "Multi-dimensional analytics and reporting platform with interactive dashboards, KPI scorecards, and predictive forecasting for C-suite decision making.", Industry = "Manufacturing", ImageUrl = "https://images.pexels.com/photos/590041/pexels-photo-590041.jpeg?w=600" },
        new() { Title = "Hospital Management System", Category = "Healthcare IT", Technology = "ASP.NET Core, EF Core, React", Description = "Integrated hospital management covering OPD, IPD, pharmacy, billing, lab, and comprehensive patient records with HL7 compliance.", Industry = "Healthcare", ImageUrl = "https://images.pexels.com/photos/356040/pexels-photo-356040.jpeg?w=600" },
        new() { Title = "E-Commerce Retail Platform", Category = "E-Commerce", Technology = "ASP.NET Core, React, Stripe", Description = "Full-featured B2C e-commerce platform with product catalog, cart, payment gateway, order tracking, and seller dashboard.", Industry = "Retail", ImageUrl = "https://images.pexels.com/photos/5632371/pexels-photo-5632371.jpeg?w=600" },
        new() { Title = "Learning Management System", Category = "EdTech", Technology = "ASP.NET Core, Angular, SignalR", Description = "Comprehensive LMS with live classes, recorded content, assessments, certificates, and detailed learner progress analytics.", Industry = "Education", ImageUrl = "https://images.pexels.com/photos/4144923/pexels-photo-4144923.jpeg?w=600" },
        new() { Title = "Steel Plant ERP Module", Category = "ERP", Technology = "C#, WPF, SQL Server", Description = "Custom ERP modules for production planning, inventory control, quality management, and dispatch for a large steel manufacturing facility.", Industry = "Steel & Manufacturing", ImageUrl = "https://images.pexels.com/photos/162568/industrial-architecture-steel-structure-162568.jpeg?w=600" },
        new() { Title = "HR & Payroll Management", Category = "Enterprise Web", Technology = "ASP.NET Core, EF Core, Bootstrap", Description = "End-to-end HR management with recruitment, onboarding, attendance, leave, payroll processing, and statutory compliance modules.", Industry = "Corporate Services", ImageUrl = "https://images.pexels.com/photos/3184465/pexels-photo-3184465.jpeg?w=600" },
        new() { Title = "Port Authority Management System", Category = "Government", Technology = "ASP.NET MVC, SQL Server, JQuery", Description = "Vessel scheduling, cargo management, billing, and logistics coordination system for a major port authority.", Industry = "Maritime", ImageUrl = "https://images.pexels.com/photos/1426173/pexels-photo-1426173.jpeg?w=600" },
        new() { Title = "AI-Powered Chatbot Platform", Category = "AI / ML", Technology = "Python, ASP.NET Core, Azure AI", Description = "Enterprise chatbot platform with NLP, multi-channel support (web, WhatsApp, Teams), CRM integration, and analytics dashboard.", Industry = "Banking & Finance", ImageUrl = "https://images.pexels.com/photos/8386440/pexels-photo-8386440.jpeg?w=600" },
    };

    public IActionResult Index(string? filter = null)
    {
        var categories = AllProjects.Select(p => p.Category).Distinct().OrderBy(c => c).ToList();
        var projects = string.IsNullOrEmpty(filter)
            ? AllProjects
            : AllProjects.Where(p => p.Category.Equals(filter, StringComparison.OrdinalIgnoreCase)).ToList();

        ViewBag.Projects = projects;
        ViewBag.Categories = categories;
        ViewBag.ActiveFilter = filter ?? "All";
        return View();
    }
}
