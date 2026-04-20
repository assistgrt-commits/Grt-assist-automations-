namespace NTSPLSite.Models;

public class ServiceItem
{
    public string Icon { get; set; } = "";
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Url { get; set; } = "#";
}

public class PortfolioItem
{
    public string Title { get; set; } = "";
    public string Category { get; set; } = "";
    public string Technology { get; set; } = "";
    public string Description { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public string Industry { get; set; } = "";
}

public class TeamMember
{
    public string Name { get; set; } = "";
    public string Designation { get; set; } = "";
    public string Department { get; set; } = "";
    public string LinkedIn { get; set; } = "#";
}

public class Testimonial
{
    public string Quote { get; set; } = "";
    public string Author { get; set; } = "";
    public string Designation { get; set; } = "";
    public string Company { get; set; } = "";
    public int Rating { get; set; } = 5;
}

public class JobListing
{
    public string Title { get; set; } = "";
    public string Department { get; set; } = "";
    public string Location { get; set; } = "";
    public string Type { get; set; } = "Full-Time";
    public string Experience { get; set; } = "";
    public string Description { get; set; } = "";
    public List<string> Skills { get; set; } = new();
}

public class BlogPost
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Category { get; set; } = "";
    public string Summary { get; set; } = "";
    public string Content { get; set; } = "";
    public string Author { get; set; } = "";
    public DateTime PublishedDate { get; set; }
    public string ImageUrl { get; set; } = "";
    public List<string> Tags { get; set; } = new();
}

public class ContactForm
{
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Company { get; set; } = "";
    public string Subject { get; set; } = "";
    public string Message { get; set; } = "";
    public string Service { get; set; } = "";
}

public class StatItem
{
    public string Value { get; set; } = "";
    public string Label { get; set; } = "";
    public string Icon { get; set; } = "";
}
