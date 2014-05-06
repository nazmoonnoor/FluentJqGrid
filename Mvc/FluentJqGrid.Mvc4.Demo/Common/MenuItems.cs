using System.Collections.Generic;
using FluentJqGrid.Mvc4.Demo.Models;

namespace FluentJqGrid.Mvc4.Demo.Common
{
    public class MenuItems
    {
        public static List<SimpleVerticalMenuModel> GetMenuItems()
        {
            var menuItems = new List<SimpleVerticalMenuModel>();

            var simpleLoad = new SimpleVerticalMenuModel {Text = "Simple Load"};
            simpleLoad.MenuItems = new List<MenuItemModel>
                                          {
                                              new MenuItemModel{Action = "JsonLoad", Controller = "SimpleLoad", Text = "Json Load"},
                                              new MenuItemModel{Action = "StronglyTypedColumns", Controller = "SimpleLoad", Text = "Strongly Typed Columns"},
                                              new MenuItemModel{Action = "XmlLoad", Controller = "SimpleLoad", Text = "Xml Load"},
                                              new MenuItemModel{Action = "ColumnSettingLoad", Controller = "SimpleLoad", Text = "Column Setting Load"},
                                              new MenuItemModel{Action = "LoadOnce", Controller = "SimpleLoad", Text = "Load Once"},
                                              new MenuItemModel{Action = "GridOptions", Controller = "SimpleLoad", Text = "Grid Options"},
                                              new MenuItemModel{Action = "ColumnOptions", Controller = "SimpleLoad", Text = "Column Options"}
                                          };

            var inlineEdit = new SimpleVerticalMenuModel { Text = "Inline Edit" };
            inlineEdit.MenuItems = new List<MenuItemModel>
                                          {
                                              new MenuItemModel{Action = "UsingCustomButtons", Controller = "InlineEdit", Text = "Using Custom Buttons"},
                                              new MenuItemModel{Action = "UsingNavigators", Controller = "InlineEdit", Text = "Using Navigators"},
                                              new MenuItemModel{Action = "UsingEvents", Controller = "InlineEdit", Text = "Using Events"},
                                              new MenuItemModel{Action = "UsingActionButtons", Controller = "InlineEdit", Text = "Using Action Buttons"},
                                              new MenuItemModel{Action = "VariousInputTypes", Controller = "InlineEdit", Text = "Various Input Types"}
                                          };
            var formEdit = new SimpleVerticalMenuModel { Text = "Form Edit"};
            formEdit.MenuItems = new List<MenuItemModel>
                                          {
                                              new MenuItemModel{Action = "UsingExternalButtons", Controller = "FormEdit", Text = "Using External Buttons"},
                                              new MenuItemModel{Action = "UsingActionColumn", Controller = "FormEdit", Text = "Using Action Column"},
                                              new MenuItemModel{Action = "UsingAction", Controller = "FormEdit", Text = "Using Action"}
                                          };

            var searching = new SimpleVerticalMenuModel() {Text = "Searching"};
            searching.MenuItems = new List<MenuItemModel>
                                      {
                                          new MenuItemModel{Action="ToolbarSearching", Controller="Searching", Text="Toolbar Searching"},
                                          new MenuItemModel{Action="CustomSearching", Controller="Searching", Text="Custom Searching"},
                                          new MenuItemModel{Action="SingleColumnSearching", Controller="Searching", Text="Single Column Searching"},
                                          new MenuItemModel{Action="AdvancedSearching", Controller="Searching", Text="Advanced Searching"}
                                      };
            menuItems.Add(simpleLoad);
            menuItems.Add(inlineEdit);
            menuItems.Add(formEdit);
            menuItems.Add(searching);
            return menuItems;
        }
    }
}