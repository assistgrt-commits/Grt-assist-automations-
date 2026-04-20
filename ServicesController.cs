using Microsoft.AspNetCore.Mvc;
using NTSPLSite.Models;

namespace NTSPLSite.Controllers;

public class ServicesController : Controller
{
    private static readonly List<ServiceItem> AllServices = new()
    {
        new() { Icon = "globe", Title = "Web Development", Description = "Custom web applications built with ASP.NET Core, React, Angular, and modern frameworks. From corporate websites to complex enterprise portals, we deliver scalable and performant solutions.", Url = "/Services/WebDevelopment" },
        new() { Icon = "mobile-alt", Title = "Mobile App Development", Description = "Native iOS, Android, and cross-platform apps using Flutter and React Native. We build intuitive, high-performance mobile experiences that users love.", Url = "/Services/MobileApps" },
        new() { Icon = "shield-alt", Title = "Cybersecurity & PKI", Description = "End-to-end PKI infrastructure, digital certificates, SSL/TLS management, and enterprise security auditing. Compliant with IT Act 2000 and industry standards.", Url = "/Services/Cybersecurity" },
        new() { Icon = "chart-bar", Title = "Business Intelligence", Description = "Turn raw data into strategic decisions. We design SSRS, Power BI, and custom BI dashboards with real-time KPIs, forecasts, and executive-level reporting.", Url = "/Services/BusinessIntelligence" },
        new() { Icon = "robot", Title = "AI / ML Development", Description = "Custom AI and machine learning models for predictive analytics, natural language processing, computer vision, and process automation tailored to your domain.", Url = "/Services/AiMl" },
        new() { Icon = "bullhorn", Title = "Digital Marketing", Description = "360-degree digital marketing: SEO, Google Ads, social media management, content strategy, and performance analytics to grow your brand online.", Url = "/Services/DigitalMarketing" },
        new() { Icon = "cloud", Title = "Cloud & Hosting", Description = "Managed AWS, Azure, and Google Cloud deployments. Domain registration, Linux/Windows hosting, email hosting, and 24/7 infrastructure support.", Url = "/Services/CloudHosting" },
        new() { Icon = "paint-brush", Title = "UI / UX Design", Description = "Research-driven design thinking, wireframing, prototyping, and pixel-perfect UI development. We create interfaces that are both beautiful and highly usable.", Url = "/Services/UiUxDesign" },
        new() { Icon = "shopping-cart", Title = "E-Commerce Solutions", Description = "Custom-built and platform-based e-commerce stores with payment gateway integration, inventory management, and marketing automation.", Url = "/Services/Ecommerce" },
        new() { Icon = "map-marker-alt", Title = "GPS Tracking Systems", Description = "Real-time vehicle and asset tracking systems with geo-fencing, alerts, route optimization, and comprehensive fleet management dashboards.", Url = "/Services/GpsTracking" },
        new() { Icon = "file-signature", Title = "Digital Signatures", Description = "Class 2 and Class 3 DSC-based document signing, bulk signing solutions, and API integrations for seamless document workflow automation.", Url = "/Services/DigitalSignature" },
        new() { Icon = "cogs", Title = "ERP / Enterprise Solutions", Description = "Custom ERP modules for HR, payroll, inventory, procurement, finance, and manufacturing - all integrated on a unified enterprise platform.", Url = "/Services/Erp" },
        new() { Icon = "wordpress", Title = "WordPress Development", Description = "Custom WordPress themes, plugins, WooCommerce stores, and multi-site networks. We build fast, secure, and SEO-optimized WordPress solutions.", Url = "/Services/WordPress" },
        new() { Icon = "envelope", Title = "Email & Office 365", Description = "Business email hosting, Microsoft 365 licensing, migration services, and ongoing support to keep your team connected and productive.", Url = "/Services/Email" },
        new() { Icon = "lock", Title = "SSL Certificates", Description = "DV, OV, and EV SSL certificate provisioning, installation, and renewal management for websites and APIs across all major certificate authorities.", Url = "/Services/Ssl" },
    };

    public IActionResult Index()
    {
        ViewBag.Services = AllServices;
        return View();
    }

    public IActionResult Detail(string id)
    {
        var service = AllServices.FirstOrDefault(s => s.Url.EndsWith(id, StringComparison.OrdinalIgnoreCase));
        if (service == null) return NotFound();
        ViewBag.Service = service;
        ViewBag.RelatedServices = AllServices.Where(s => s.Url != service.Url).Take(4).ToList();
        return View();
    }
}
