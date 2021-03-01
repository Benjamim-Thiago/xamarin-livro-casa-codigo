using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CC_Food.Pages.Waiters
{
    public class NewWaitersPage : ContentPage
    {
        public NewWaitersPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello new Waiter" }
                }
            };
        }
    }
}