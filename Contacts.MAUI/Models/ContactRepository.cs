namespace Contacts.MAUI.Models
{
    public static class ContactRepository
    {
        private static readonly List<Contact> _contacts;

        static ContactRepository()
        {
            _contacts =
            [
            new Contact { Id = 1, Name = "Pepa", Email = "Pepa@ehm.cz"},
            new Contact { Id = 2, Name = "Arnold", Email = "Arnold@ehm.cz"},
            new Contact { Id = 3, Name = "Telemín", Email = "Telemín@ehm.cz"}
            ];
        }

        public static IEnumerable<Contact> GetAll() => _contacts;

        public static Contact? GetContact(int id) => _contacts.Find(c => c.Id == id);
    }
}
