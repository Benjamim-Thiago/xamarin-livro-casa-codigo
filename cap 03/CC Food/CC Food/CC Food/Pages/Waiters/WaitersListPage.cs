using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CC_Food.Pages.Waiters
{
    public class WaitersListPage : ContentPage
    {
        public WaitersListPage()
        {
            Content = GetWaiters();
        }

        private ListView GetWaiters()
        {
            var waiters = new ListView();

            waiters.ItemsSource = new string[] {
                "José", "Maria", "Alex", "Joselio", "Calisto", "Alfredo"
            };

            return waiters;
        }
    }
}