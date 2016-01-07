﻿using System;
using System.Linq;
using Sitecore.Modules.WeBlog.Data.Items;

namespace Sitecore.Modules.WeBlog.Layouts
{
    public partial class ThemeStylehseets : BaseSublayout
    {
        public ThemeItem ThemeItem
        {
            get
            {
                var rawThemeItem = CurrentBlog.Theme.Item;
                if (rawThemeItem == null)
                    return null;

                var theme = (ThemeItem)rawThemeItem;
                if (theme == null)
                    return null;

                return theme;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var theme = ThemeItem;
            if (theme != null)
            {
                //Stylesheets.DataSource = theme.Stylesheets.Select(x => x.Url);
                Stylesheets.DataSource = theme.Stylesheets;
                Stylesheets.DataBind();
            }
        }
    }
}