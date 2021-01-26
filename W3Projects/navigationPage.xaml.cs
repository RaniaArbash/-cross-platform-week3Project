using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace W3Projects
{
    public partial class navigationPage : ContentPage
    {
        public navigationPage()
        {
            InitializeComponent();
        }

       async void Button_Clicked(System.Object sender, System.EventArgs e)
        {

            var contact = new Contact() { name= "mary",number ="8888"};
            //await Navigation.PushAsync(new nextPage(contact));

            await Navigation.PushModalAsync(new nextPage(contact));
            ///
            ///

        }
    }
}
