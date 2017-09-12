using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Main.Models
{
    public class RecipeGroup : ObservableCollection<Recipe>
    {
        public string GroupTitle { get; set; }

        public RecipeGroup(string groupTitle)
        {
            GroupTitle = groupTitle;
        }
    }
}
