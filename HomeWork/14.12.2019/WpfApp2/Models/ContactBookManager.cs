using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Models
{
    class ContactBookManager
    {
        private List<Contact> contacts = new List<Contact>();

        public IEnumerable<Contact> GetContacts() { return contacts; }
        public void LoadBook() { /*deserialize or smth else*/ }
        public void SaveBook() { /*deserialize or smth else*/ }
    }
}
