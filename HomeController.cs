using Microsoft.AspNetCore.Mvc;
using NTSPLSite.Models;

namespace NTSPLSite.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var services = GetFeaturedServices();
        var portfolio = GetFeaturedPortfolio();
        var testimonials = GetTestimonials();
        var stats = GetStats();
        ViewBag.Services = services;
        ViewBag.Portfolio = portfolio;
        ViewBag.Testimonials = testimonials;
        ViewBag.Stats = stats;
        return View();
    }

    public IActionResult Privacy() => View();
    public IActionResult Error() => View();

    private static List<ServiceItem> GetFeaturedServices() => new()
    {
        new() { Icon = "globe", Title = "Web Development", Description = "Custom web applications built with modern frameworks and best practices for performance and scalability.", Url = "/Services/WebDevelopment" },
        new() { Icon = "mobile-alt", Title = "Mobile App Development", Description = "Native and cross-platform mobile solutions for iOS and Android with seamless user experiences.", Url = "/Services/MobileApps" },
        new() { Icon = "shield-alt", Title = "Cybersecurity & PKI", Description = "Digital signature solutions, PKI infrastructure, and enterprise-grade security implementations.", Url = "/Services/Cybersecurity" },
        new() { Icon = "chart-bar", Title = "Business Intelligence", Description = "Data analytics, dashboards, and BI solutions to transform your raw data into actionable insights.", Url = "/Services/BusinessIntelligence" },
        new() { Icon = "robot", Title = "AI / ML Development", Description = "Artificial intelligence and machine learning solutions to automate processes and enhance decision-making.", Url = "/Services/AiMl" },
        new() { Icon = "bullhorn", Title = "Digital Marketing", Description = "SEO, SEM, social media, and content marketing strategies to grow your online presence.", Url = "/Services/DigitalMarketing" },
        new() { Icon = "cloud", Title = "Cloud & Hosting", Description = "Managed cloud hosting, domain registration, and server infrastructure tailored to your needs.", Url = "/Services/CloudHosting" },
        new() { Icon = "paint-brush", Title = "UI / UX Design", Description = "User-centered design that combines aesthetics with functionality to deliver outstanding digital experiences.", Url = "/Services/UiUxDesign" },
        new() { Icon = "shopping-cart", Title = "E-Commerce Solutions", Description = "End-to-end e-commerce platforms with payment gateways, inventory, and customer management.", Url = "/Services/Ecommerce" },
        new() { Icon = "map-marker-alt", Title = "GPS Tracking Systems", Description = "Real-time fleet and asset tracking systems with live monitoring and reporting capabilities.", Url = "/Services/GpsTracking" },
        new() { Icon = "file-signature", Title = "Digital Signatures", Description = "DSC-based document signing solutions compliant with IT Act and eSign frameworks.", Url = "/Services/DigitalSignature" },
        new() { Icon = "cogs", Title = "ERP / Enterprise Solutions", Description = "Customized enterprise resource planning software to streamline and integrate business operations.", Url = "/Services/Erp" },
    };

    private static List<PortfolioItem> GetFeaturedPortfolio() => new()
    {
        new() { Title = "Mining Operations Portal", Category = "Enterprise Web", Technology = "ASP.NET Core, SQL Server, Angular", Description = "Comprehensive operations management portal for large-scale mining enterprises with real-time monitoring.", Industry = "Mining & Resources", ImageUrl = "https://images.pexels.com/photos/1108101/pexels-photo-1108101.jpeg?w=600" },
        new() { Title = "Government e-Services Platform", Category = "Government", Technology = "ASP.NET MVC, Oracle, Bootstrap", Description = "Citizen-facing e-governance portal enabling online application, tracking, and certificate delivery.", Industry = "Government", ImageUrl = "https://images.pexels.com/photos/3183150/pexels-photo-3183150.jpeg?w=600" },
        new() { Title = "Fleet GPS Tracking Dashboard", Category = "IoT & Tracking", Technology = "React, Node.js, GPS APIs", Description = "Real-time fleet management dashboard with live map tracking, alerts, and maintenance scheduling.", Industry = "Logistics", ImageUrl = "https://images.pexels.com/photos/1427541/pexels-photo-1427541.jpeg?w=600" },
        new() { Title = "Digital Signature Integration Suite", Category = "PKI / Security", Technology = "C#, DSC SDK, REST API", Description = "Enterprise PKI solution enabling digital signing of documents across multiple departments.", Industry = "Finance & Legal", ImageUrl = "https://images.pexels.com/photos/60504/security-protection-anti-virus-software-60504.jpeg?w=600" },
        new() { Title = "BI Analytics Platform", Category = "Business Intelligence", Technology = "Power BI, SQL Server, SSRS", Description = "Multi-dimensional analytics and reporting platform with interactive dashboards for C-suite decision making.", Industry = "Manufacturing", ImageUrl = "https://images.pexels.com/photos/590041/pexels-photo-590041.jpeg?w=600" },
        new() { Title = "Hospital Management System", Category = "Healthcare IT", Technology = "ASP.NET Core, EF Core, React", Description = "Integrated hospital management covering OPD, IPD, pharmacy, billing, and patient records.", Industry = "Healthcare", ImageUrl = "https://images.pexels.com/photos/356040/pexels-photo-356040.jpeg?w=600" },
    };

    private static List<Testimonial> GetTestimonials() => new()
    {
        new() { Quote = "The team delivered an exceptional enterprise portal that transformed our operations. Their technical expertise and project management approach were outstanding.", Author = "Rajesh Kumar", Designation = "General Manager - IT", Company = "Mining Corporation Ltd.", Rating = 5 },
        new() { Quote = "Highly professional and responsive team. They understood our government compliance requirements and delivered a robust e-governance platform on time.", Author = "Anita Sharma", Designation = "Director of Technology", Company = "State Government Department", Rating = 5 },
        new() { Quote = "The GPS tracking system developed has greatly improved our fleet efficiency. Real-time tracking and reporting has reduced operational costs significantly.", Author = "Mohan Rao", Designation = "Operations Head", Company = "National Logistics Pvt. Ltd.", Rating = 5 },
        new() { Quote = "Their digital signature solution seamlessly integrated with our existing systems. The team's knowledge of PKI and DSC frameworks is commendable.", Author = "Priya Mehta", Designation = "CTO", Company = "Financial Services Group", Rating = 5 },
    };

    private static List<StatItem> GetStats() => new()
    {
        new() { Value = "18+", Label = "Years of Experience", Icon = "calendar-alt" },
        new() { Value = "500+", Label = "Projects Delivered", Icon = "check-circle" },
        new() { Value = "200+", Label = "Clients Served", Icon = "handshake" },
        new() { Value = "50+", Label = "Technology Experts", Icon = "users" },
    };
}
