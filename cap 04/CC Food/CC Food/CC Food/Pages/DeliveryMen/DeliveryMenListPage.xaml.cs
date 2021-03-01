using CC_Food.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CC_Food.Pages.DeliveryMen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeliveryMenListPage : ContentPage
    {
        private DeliveryManDAL deliveryManDAL = DeliveryManDAL.GetInstance();
        public DeliveryMenListPage()
        {
            InitializeComponent();
            lvDeliveryMan.ItemsSource = deliveryManDAL.GetAll();
        }
    }
}