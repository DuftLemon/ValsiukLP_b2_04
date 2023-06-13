using System;
using ValsiukLP_b2_04.Services;
using ValsiukLP_b2_04.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ValsiukLP_b2_04
{
    public partial class App :Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
