using System;
using System.Collections.Generic;
using ValsiukLP_b2_04.ViewModels;
using ValsiukLP_b2_04.Views;
using Xamarin.Forms;

namespace ValsiukLP_b2_04
{
    public partial class AppShell :Xamarin.Forms.Shell
    {
        public AppShell ()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
