using IOSTabbedPageBug.Views;
using Xamarin.Forms;

namespace IOSTabbedPageBug
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TabbedExample), typeof(TabbedExample));
        }

    }
}
