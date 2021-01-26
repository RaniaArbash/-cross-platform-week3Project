using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace W3Projects
{
    public partial class listViewPage : ContentPage
    {
        ObservableCollection<Contact> contacts;
        public listViewPage()
        {
            InitializeComponent();

            contacts = new ObservableCollection<Contact>
            {
                new Contact(){name = "Stella", number="1234" , image="https://images.freeimages.com/images/small-previews/5da/coloured-paper-1421280.jpg"},
                new Contact(){name = "Nilan", number="33333", image="https://images.freeimages.com/images/small-previews/0cf/tulips-1-1377350.jpg"},
                new Contact(){name = "Irfan", number="4444" , image="https://images.freeimages.com/images/small-previews/48d/marguerite-1372118.jpg"}
            };
            mylist.ItemsSource = contacts;

        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
           
        }

        void Call_Clicked(System.Object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var call_contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Calling ", call_contact.name, "OK");


        }

        void Delete_Clicked(System.Object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var delete_contact = menuItem.CommandParameter as Contact;
            contacts.Remove(delete_contact);
        }

        void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Contanct", (e.SelectedItem as Contact).name, "OK");
        }
    }
}

        //    ObservableCollection<Contact> _contacts;
        //    public listViewPage()
        //    {

        //        InitializeComponent();

        //        _contacts = new ObservableCollection<Contact>() {
        //            new Contact { name = "Jone", number = "12234" , image="https://images.freeimages.com/images/small-previews/39a/no-grain-no-pain-1326753.jpg"},
        //             new Contact { name = "Mary", number = "334566" , image = "https://images.freeimages.com/images/small-previews/977/beach-1364350.jpg"}

        //        };
        //        mylist.ItemsSource = _contacts;
        //    }

        //    void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //    {
        //       var selectedContact = e.SelectedItem as Contact;
        //        DisplayAlert("Selected",selectedContact.name,"OK");
        //    }

        //    void Call_Clicked(System.Object sender, System.EventArgs e)
        //    {
        //        var menuItem = sender as MenuItem;
        //        var contact = menuItem.CommandParameter as Contact;
        //        DisplayAlert("Calling", contact.name , "OK");
        //    }

        //    void Delete_Clicked(System.Object sender, System.EventArgs e)
        //    {
        //        var menuItem = sender as MenuItem;
        //        var contact = menuItem.CommandParameter as Contact;
        //        _contacts.Remove(contact);


        //    }

        //    //void mylist_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        //    //{
        //    //    var tappedItem = e.Item as Contact;
        //    //    DisplayAlert("Tapped", tappedItem.name, "OK");

        //    //}
        //}
    
