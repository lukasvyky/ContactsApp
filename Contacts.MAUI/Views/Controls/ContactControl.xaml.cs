namespace Contacts.MAUI.Views.Controls;

public partial class ContactControl : ContentView
{
    public event EventHandler<string> OnError;
    public event EventHandler<EventArgs> OnSave;

    public string Name 
    { 
        get { return entryName.Text; }
        set { entryName.Text = value; }
    }

    public string Email
    {
        get { return entryEmail.Text; }
        set { entryEmail.Text = value; }
    }

    public string Phone
    {
        get { return entryPhone.Text; }
        set { entryPhone.Text = value; }
    }

    public string Address
    {
        get { return entryAddress.Text; }
        set { entryAddress.Text = value; }
    }
    public ContactControl()
    {
        InitializeComponent();
    }

    private void BtnSave_Clicked(object sender, EventArgs e)
    {
        if (nameValidator.IsNotValid)
        {
            OnError?.Invoke(sender, "Name is not correct");
        }
        if (emailValidator.IsNotValid)
        {
            OnError?.Invoke(sender, String.Join("\n", emailValidator.Errors));
            return;
        }

        OnSave?.Invoke(sender, e);
    }
}