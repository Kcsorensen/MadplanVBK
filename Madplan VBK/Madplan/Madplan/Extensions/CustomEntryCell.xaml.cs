using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomEntryCell : ViewCell
    {
        public CustomEntryCell()
        {
            InitializeComponent();
        }
    }
}