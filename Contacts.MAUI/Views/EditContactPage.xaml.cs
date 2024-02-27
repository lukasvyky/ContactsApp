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
            contactName.Text = Contact?.Name;
        }
    }

    public EditContactPage()
    {
        InitializeComponent();
    }
}