using Demo.BLL.Abstract;
using Demo.UI.MVC.Tools.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Demo.UI.MVC.Tools.Constraints
{
    public class AdvertConstraint:IRouteConstraint
    {
        public IAdvertService advertService { get; set; }
        public AdvertConstraint(IAdvertService advertService)
        {
            this.advertService = advertService;
        }
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var ads = advertService.GetAll();
            if (values[parameterName] != null)
            {
                return ads.Any(p => p.ToUrlString() == values[parameterName].ToString().ToLower());
            }
            return false;
        }
    }
}