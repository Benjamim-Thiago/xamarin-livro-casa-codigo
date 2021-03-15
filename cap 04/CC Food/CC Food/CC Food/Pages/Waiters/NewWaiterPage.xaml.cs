using CC_Food.dao;
using CC_Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CC_Food.Pages.Waiters
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewWaiterPage : ContentPage
    {
        private WaiterDAL waitersDAL =  WaiterDAL.GetInstance();
        public NewWaiterPage()
        {
            InitializeComponent();
            PrepareNewWaiter();
        }
        private void PrepareNewWaiter()
        {
            var novoId = waitersDAL.GetAll().Max(x => x.id)
            + 1;

            id.Text = novoId.ToString().Trim();
            name.Text = string.Empty;
        }

        public void BtnGravarClick(object sender, EventArgs e)
        {
            if (name.Text.Trim() == string.Empty)
            {
                this.DisplayAlert("Erro", "Você precisa informar o nome para o novo garçon.", "Ok");
            }
            else
            {
                waitersDAL.Add(new Waiter()
                {
                    id = Convert.ToUInt32(id.Text),
                    name = name.Text
                });
                PrepareNewWaiter();
            }
        }
    }
}