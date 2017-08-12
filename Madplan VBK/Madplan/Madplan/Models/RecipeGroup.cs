using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madplan.Models
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
