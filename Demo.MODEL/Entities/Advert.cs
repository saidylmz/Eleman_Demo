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
    public class Advert : BaseEntity
    {
        public Advert()
        {
            Phones = new List<string>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public int CityID { get; set; }
        public Gender Gender { get; set; }
        public string PhoneList
        {
            get
            {
                return string.Join(",", Phones);
            }
            set
            {
                Phones = value.Split(',').ToList();
            }
        }

        [NotMapped]
        public List<string> Phones { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
    }
}
