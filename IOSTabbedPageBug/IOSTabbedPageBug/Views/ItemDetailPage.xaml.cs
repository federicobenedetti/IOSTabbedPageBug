using IOSTabbedPageBug.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace IOSTabbedPageBug.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}