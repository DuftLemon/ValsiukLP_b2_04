using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValsiukLP_b2_04.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ValsiukLP_b2_04.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage :ContentPage
    {
        public LoginPage ()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}