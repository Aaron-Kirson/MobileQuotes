using HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActionCreators : ContentPage
    {

        private ObservableCollection<Contact> _contact;
        public ActionCreators()
        {
            InitializeComponent();

            //this list type allows you to amend lists and have it show up on the UI.
           _contact = new ObservableCollection<Contact>
            {

                      new Contact {Name = "Aaron", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "online"},


                     new Contact {Name = "Daniel", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "online"},



                      new Contact {Name = "Naomi", ImageUrl = "http://lorempixel.com/100/100/people/3", Status = "online"}
            };

            listView.ItemsSource = _contact;
            
        }

        private void call_clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contact.Remove(contact);
        }
    }
}