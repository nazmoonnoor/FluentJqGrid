using System.Collections.Generic;

namespace FluentJqGrid.Mvc4.Demo.Models
{
    public class MenuItemModel
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Text { get; set; }
        public bool Selected { get; set; }
    }

    public class SimpleVerticalMenuModel
    {
        public string Text { get; set; }
        public bool Active { get; set; }
        public List<MenuItemModel> MenuItems { get; set; } 
    }
}