using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace W3Projects
{
    public partial class nextPage : ContentPage
    {
        Contact contactFromFirstPage;

        public nextPage(Contact contact)
        {
            InitializeComponent();
            contactFromFirstPage = contact;
            BindingContext = contactFromFirstPage;

        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
          await  Navigation.PopModalAsync();
        }
    }
}
