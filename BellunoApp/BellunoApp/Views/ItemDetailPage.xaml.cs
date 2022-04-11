using BellunoApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BellunoApp.Views
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