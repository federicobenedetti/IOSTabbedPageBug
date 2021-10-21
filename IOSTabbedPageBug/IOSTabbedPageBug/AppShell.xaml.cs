using IOSTabbedPageBug.ViewModels;
using IOSTabbedPageBug.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace IOSTabbedPageBug
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(TabbedExample), typeof(TabbedExample));
        }

    }
}
