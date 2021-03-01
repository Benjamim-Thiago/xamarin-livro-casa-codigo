using CC_Food.Pages.Waiters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CC_Food.Pages
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {

            Title = "Menu de opções";

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Button() {
                        Text = "Garçons",
                        //Image = "icone_garcons.png",
                        ImageSource = ImageSource.FromFile("icone_garcons.png"),
                        Command = new Command(() => Navigation.PushAsync(new WaitersPage()))
                    }
                }
            };
        }
    }
}