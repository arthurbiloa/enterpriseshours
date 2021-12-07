using App6.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App6.Views
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