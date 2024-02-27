namespace Contacts.MAUI.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();

        List<dynamic> contacts =
        [
            new { Name = "Pepa", Email = "Pepa@ehm.cz"},
            new { Name = "Arnold", Email = "Arnold@ehm.cz"},
            new { Name = "Telemín", Email = "Telemín@ehm.cz"}
        ];
        contactsList.ItemsSource = contacts;
    }

    private void BtnEditContact_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditContactPage));
    }

    private void BtnAddContact_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    private void ContactsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (contactsList.SelectedItem is not null)
        {
            DisplayAlert("Test", "ClickedItem", "Cancel");
        }   
    }
    private void ContactsList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        contactsList.SelectedItem = null;
    }
}