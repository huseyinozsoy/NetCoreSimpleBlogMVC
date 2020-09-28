using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public bool IsApproved { get; set; }
        public ICollection<BlogCategory> BlogCategories { get; set; }
    }
}