using Entities;

namespace ASPNetCoreWebApiBlogSiteProje.Models
{
    public class HomePageViewModel
    {
        public List<Post>? Posts { get; set; }
        public List<Category>? Categories { get; set; }
    }
}
