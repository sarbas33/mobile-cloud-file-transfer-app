using SyncToCloud.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SyncToCloud.Views
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