using Contacts.MAUI.Models;
using Contact = Contacts.MAUI.Models.Contact;

namespace Contacts.MAUI.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    private void ContactCtrl_OnSave(object sender, EventArgs e)
    {
        ContactRepository.AddContact(new Contact
        {
            Name = contactCtrl.Name,
            Email = contactCtrl.Email,
            Address = contactCtrl.Address,
            Phone = contactCtrl.Phone,
        });

        Shell.Current.GoToAsync("..");
    }

    private void ContactCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Error", e, "Back");
    }
}