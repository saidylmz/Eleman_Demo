using Demo.CORE.Entity;
using Demo.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.MODEL.Entities
{
    public class User:BaseEntity
    {
        public User()
        {
            Adverts = new HashSet<Advert>();
        }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Advert> Adverts { get; set; }

    }
}
