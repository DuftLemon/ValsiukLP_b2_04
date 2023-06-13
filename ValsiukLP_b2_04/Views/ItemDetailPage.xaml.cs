using System.ComponentModel;
using ValsiukLP_b2_04.ViewModels;
using Xamarin.Forms;

namespace ValsiukLP_b2_04.Views
{
    public partial class ItemDetailPage :ContentPage
    {
        public ItemDetailPage ()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}