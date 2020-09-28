using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryNName { get; set; }

        public ICollection<BlogCategory> BlogCategories { get; set; }
    }
}