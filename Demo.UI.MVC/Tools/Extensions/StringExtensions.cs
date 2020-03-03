using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.UI.MVC.Tools.Extensions
{
    public static class StringExtensions
    {
        public static string ClearUrl(this string str)
        {
            char[] tr = "ığüşöçĞÜŞİÖÇI".ToCharArray();
            char[] en = "igusocgusioci".ToCharArray();
            for (int i = 0; i < tr.Length; i++)
            {
                str = str.Replace(tr[i], en[i]);
            }
            str = str.ToLower();
            const string chars = "!@#\"&()-_[{}]:;',?/*\\`~$^.+=<>“|";
            for (int i = 0; i < chars.Length; i++)
            {
                str = str.Replace(chars[i] + "", string.Empty);
            }
            str = str.Replace(" ", "-");
            str = str.Replace("--", "-");
            return str;
        }
    }
}