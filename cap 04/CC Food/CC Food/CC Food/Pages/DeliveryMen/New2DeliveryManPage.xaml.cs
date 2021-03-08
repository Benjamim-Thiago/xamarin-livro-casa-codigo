using CC_Food.dao;
using CC_Food.Models;
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
    public partial class New2DeliveryManPage : ContentPage
    {
        private DeliveryManDAL deliveryMen = DeliveryManDAL.GetInstance();
        public New2DeliveryManPage()
        {
            InitializeComponent();
            PrepareNewDeliveryMan();
        }

        public void BtnGravarClick(object sender, EventArgs e)
        {
            if (name.Text.Trim() == string.Empty || phoneNumber.Text == string.Empty)
            {
                this.DisplayAlert("Erro", "Você precisa informar o nome e telefone para o novo entregador.", "Ok");
            }
            else
            {
                deliveryMen.Add(new DeliveryMan()
                {
                    id = Convert.ToUInt32(id.Text),
                    name = name.Text,
                    phoneNumber = phoneNumber.Text
                });
                PrepareNewDeliveryMan();
            }
        }

        private void PrepareNewDeliveryMan()
        {
            var novoId = deliveryMen.GetAll().Max(x => x.id)
            + 1;
            id.Text = novoId.ToString().Trim();
            name.Text = string.Empty;
            phoneNumber.Text = string.Empty;
        }
    }
}