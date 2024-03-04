using Contacts.MAUI.Models;
using Contact = Contacts.MAUI.Models.Contact;

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

    private void ContactsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (contactsList.SelectedItem is not null)
        {
            Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={(e.SelectedItem as Contact)?.Id}");
        }   
    }
    private void ContactsList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        contactsList.SelectedItem = null;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        contactsList.ItemsSource = ContactRepository.GetAll();
    }
}