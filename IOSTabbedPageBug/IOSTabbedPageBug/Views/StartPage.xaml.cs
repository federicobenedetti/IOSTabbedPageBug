using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IOSTabbedPageBug.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public Command GoToTabCommand { get; set; }
        public StartPage()
        {
            InitializeComponent();

            GoToTabCommand = new Command(() => Shell.Current.GoToAsync(nameof(TabbedExample)));

            BindingContext = this;
        }
    }
}