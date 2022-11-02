using AddressBook_InlämningsUppgift2.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AddressBook_InlämningsUppgift2
{

    public partial class MainWindow : Window
    {
        private ObservableCollection<ContactPerson> contacts; //Här ska finnas en lista!
        public MainWindow()
        {
            InitializeComponent();
            contacts = new ObservableCollection<ContactPerson>();
            lv_Contacts.ItemsSource = contacts; //vår listview ska läsa av vår lista "contacts"
        }
        private void btn_Add_Click(object sender, RoutedEventArgs e) //det är en metod lägga till en kontakt och gämför om det redan finns en kontakt med samma e-post.

        {
            var contact = contacts.FirstOrDefault(x => x.Email == tb_Email.Text);
            if (contact == null)
            {
                contacts.Add(new ContactPerson
                {
                    FirstName = tb_FirstName.Text,
                    LastName = tb_LastName.Text,
                    Email = tb_Email.Text,
                    StreetName = tb_StreetName.Text,
                    PostalCode = tb_PostalCode.Text,
                    City = tb_City.Text,

                });
            }
            else
            {
                MessageBox.Show("Det finns redan en kontakt med samma e-postadress.");
            }


            

            ClearFields();

        }
        private void ClearFields()//metod som tömmer fälten.
        {
            tb_FirstName.Text = "";
            tb_LastName.Text = "";
            tb_Email.Text = "";
            tb_StreetName.Text = "";
            tb_PostalCode.Text = "";
            tb_City.Text = "";
        }
        private void btn_Remove_Click(object sender, RoutedEventArgs e)// metod som tar bort kontakten. Jag gjorde try, catch så appen ska inte cracha.
        {
            try
            {
                var button = sender as Button;
                var contact = (ContactPerson)button!.DataContext;
                contacts.Remove(contact);
            }
            catch { }

        }

        private void lv_Contacts_SelectionChanged(object sender, SelectionChangedEventArgs e)  // när vi trycker på kontakten så visas all info om kontakten igen
        {
            var contact = (ContactPerson)lv_Contacts.SelectedItems[0]!;
            tb_FirstName.Text = contact.FirstName;
            tb_LastName.Text = contact.LastName;
            tb_Email.Text = contact.Email;
            tb_StreetName.Text = contact.StreetName;
            tb_PostalCode.Text = contact.PostalCode;
            tb_City.Text = contact.City;
        }
    }
}
