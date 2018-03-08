using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.Controls;

namespace WebApp.Helpers
{
    public static class ControlExtensions
    {
        public static HtmlString CtrlTable(this HtmlHelper html, string id, string title,
            string columnsTitle, string ColumnsDataName)
        {
            var ctrl = new CtrlTableModel
            {
                Id = id,
                Title = title,
                Columns = columnsTitle,
                ColumnsDataName = ColumnsDataName  
            };

            return new HtmlString(ctrl.GetHtml());
        }

    }
}