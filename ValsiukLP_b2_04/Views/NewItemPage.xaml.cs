using System;
using System.Collections.Generic;
using System.ComponentModel;
using ValsiukLP_b2_04.Models;
using ValsiukLP_b2_04.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ValsiukLP_b2_04.Views
{
    public partial class NewItemPage :ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage ()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}