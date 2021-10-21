using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IOSTabbedPageBug.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedExample : TabbedPage
    {
        public TabbedExample()
        {
            InitializeComponent();
        }
    }
}