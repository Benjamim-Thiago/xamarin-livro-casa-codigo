using CC_Food.Pages.DeliveryMen;
using CC_Food.Pages.Waiters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CC_Food.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        private async void WaitersOnClickeds(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new WaitersPage());
        }
        private async void DeliveryMenOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new DeliveryManPage());
        }
    }
}