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
                contactCtrl.Name = Contact.Name;
                contactCtrl.Email = Contact.Email;
                contactCtrl.Phone = Contact.Phone;
                contactCtrl.Address = Contact.Address;
            }
        }
    }

    public EditContactPage()
    {
        InitializeComponent();
    }

    private void BtnSave_Clicked(object sender, EventArgs e)
    {
        if (Contact is not null)
        {
            Contact.Name = contactCtrl.Name;
            Contact.Email = contactCtrl.Email;
            Contact.Phone = contactCtrl.Phone;
            Contact.Address = contactCtrl.Address;
        }

        ContactRepository.EditContact(Contact.Id,Contact); // this is not needed in case of in-memory collection
        Shell.Current.GoToAsync("..");
    }

    private void ContactCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Error", e, "Back");
    }
}