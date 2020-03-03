using Demo.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.MODEL.Entities
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Adverts = new HashSet<Advert>();
        }
        public string Name { get; set; }
        public string FavImage { get; set; }
        public virtual ICollection<Advert> Adverts { get; set; }
    }
}
