namespace Bloggie.Web.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Heding { get; set; } // (?)mean it could be null
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string  ShortDescription { get; set; }
        public string FeatureImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedData { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }
        public ICollection<Tag>Tags { get; set; }
    }
}
