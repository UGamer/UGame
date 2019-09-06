using System;
using System.Collections.Generic;
using System.Text;

namespace UGame.Models
{
    public enum MenuItemType
    {
        Library,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
