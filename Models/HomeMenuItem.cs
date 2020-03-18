using System;
using System.Collections.Generic;
using System.Text;

namespace HappinessFoundation.Models
{
    public enum MenuItemType
    {
        Questions,
        About, 
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
