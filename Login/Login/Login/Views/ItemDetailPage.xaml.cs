using Login.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Login.Views
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