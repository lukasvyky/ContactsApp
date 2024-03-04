using Contacts.MAUI.Models;
using Contact = Contacts.MAUI.Models.Contact;

namespace Contacts.MAUI.Views;

[QueryProperty(nameof(ContactId), "Id")]
public partial class EditContactPage : ContentPage
{
    private Contact? Contact { get; set; }
    public string ContactId
    {
        set
        {
            Contact = ContactRepository.GetContact(int.Parse(value));
            if (Contact is not null)
            {
                entryName.Text = Contact.Name;
                entryEmail.Text = Contact.Email;
                entryPhone.Text = Contact.Phone;
                entryAddress.Text = Contact.Address;
            }
        }
    }

    public EditContactPage()
    {
        InitializeComponent();
    }

    private void BtnUpdate_Clicked(object sender, EventArgs e)
    {
        if(nameValidator.IsNotValid)
        {
            DisplayAlert("Error", "Incorrect name format", "Back");
        }
        if (emailValidator.IsNotValid)
        {
            DisplayAlert("Error", String.Join("\n", emailValidator.Errors), "Back");
            return;
        }

        if (Contact is not null)
        {
            Contact.Name = entryName.Text;
            Contact.Email = entryEmail.Text;
            Contact.Phone = entryPhone.Text;
            Contact.Address = entryAddress.Text;
        }

        ContactRepository.EditContact(Contact.Id,Contact); // this is not needed in case of in-memory collection
        Shell.Current.GoToAsync("..");
    }
}