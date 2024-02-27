namespace Contacts.MAUI.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
	}

    private void BtnEditContact_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditContactPage));
    }

    private void BtnAddContact_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactPage));
    }
}