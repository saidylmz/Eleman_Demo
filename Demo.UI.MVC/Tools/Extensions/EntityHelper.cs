using Demo.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.UI.MVC.Tools.Extensions
{
    public static class EntityHelper
    {
        public static string ToUrlString(this Advert advert) 
        {
            return advert.Name.ClearUrl() + "_" + advert.ID;
        }
        public static string ToUrlString(this Category cat)
        {
            return cat.Name.ClearUrl() + "-is-ilanlari";
        }

        public static string ToUrlString(this User usr)
        {
            return usr.Name.ClearUrl() + "-" + usr.ID;
        }
        private static string[] Iller = new string[] { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "K.maraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", " Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
        public static string CityString(this Advert advert)
        {
            return Iller[advert.CityID - 1];
        }
        public static string[] CityList(this HtmlHelper htmlHelper)
        {
            return Iller;
        }
    }
}