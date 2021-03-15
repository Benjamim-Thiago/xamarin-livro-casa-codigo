using CC_Food.dao;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CC_Food.Pages.Waiters
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WaitersListViewPage : ContentPage
    {
        private WaiterDAL waiterDAL = WaiterDAL.GetInstance();
        public WaitersListViewPage()
        {
            InitializeComponent();
            lvItems.ItemsSource = waiterDAL.GetAll();
        }

    }
}
