using MyXamarinApp.Pages;
using MyXamarinApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyXamarinApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemListPage : ContentPage
    {
        ItemListViewModel viewModel;
        public ItemListPage()
        {
            InitializeComponent();
            viewModel = new ItemListViewModel();
            BindingContext = viewModel;
        }

        private void NavigateToItemPage(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new ItemPage(new ItemViewModel { Item = (sender as ListView).SelectedItem.ToString() }));
        }
    }
}
