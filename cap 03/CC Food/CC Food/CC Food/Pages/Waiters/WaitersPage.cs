using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CC_Food.Pages.Waiters
{
    public class WaitersPage : TabbedPage
    {
        public WaitersPage()
        {
            Children.Add(new WaitersListPage()
            {
                Title = "Listagem",
                // Icon = "icone_list.png"
                IconImageSource = ImageSource.FromFile("icone_list.png")
            });

            Children.Add(new NewWaitersPage()
            {
                Title = "Inserir Novo",
               // Icon = "icone_new.png"
                IconImageSource = ImageSource.FromFile("icone_new.png")
            });
        }
    }
}