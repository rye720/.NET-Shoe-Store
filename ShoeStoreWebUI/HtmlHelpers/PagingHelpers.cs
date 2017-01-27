using System;
using System.Text;
using System.Web.Mvc;
using ShoeStoreWebUI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeStoreWebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks (this
            HtmlHelper html, PagingInfo pi, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = pi.TotalPages; i >= 1; i--)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString() + " ";
                if (i == pi.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default label-danger pull-right");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}