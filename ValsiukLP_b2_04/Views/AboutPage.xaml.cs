using System;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ValsiukLP_b2_04.Views
{
    public partial class AboutPage :ContentPage
    {
        public AboutPage ()
        {
            InitializeComponent();
            Preferences.Set("login", "ects");
            Preferences.Set("password", "ects2023");
        }

        private async void Button_Clicked (object sender, EventArgs e)
        {
            if (loginENT.Text == "" || passENT.Text == "")
            {
               
            }
            var login = Preferences.Get("login", "");
            var password = Preferences.Get("password", "");
            if (login == loginENT.Text && password == passENT.Text)
            {
                await Navigation.PushAsync(new Page1());
            } 
        }
    }
}