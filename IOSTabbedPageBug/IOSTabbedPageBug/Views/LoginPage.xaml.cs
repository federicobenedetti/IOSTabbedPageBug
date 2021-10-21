using IOSTabbedPageBug.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        public Command GoToTabCommand { get; set; }
        public LoginPage()
        {
            InitializeComponent();

            GoToTabCommand = new Command(() => Shell.Current.GoToAsync(nameof(TabbedExample)));

            BindingContext = this;
        }
    }
}