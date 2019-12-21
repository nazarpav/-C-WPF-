using ContactList.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.ViewModels
{
    class MainWindowViewModel
    {
        private ContactBookManager bookManager;
        public ObservableCollection<ContactViewModel> observableBook = new ObservableCollection<ContactViewModel>();
        public MainWindowViewModel(ContactBookManager manager)
        {
            bookManager = manager;

            foreach (var c in manager.GetContacts())
            {
                observableBook.Add(new ContactViewModel(c));
            }
        }
        public void Add(ContactViewModel c)
        {
            observableBook.Add(c);           
        }

        //        public void Add(Contact newC)
        //        {
        //            newC.Id = observableBook.Max(c => c.ID) + 1;
        //            contacts.Add(newC);
        //        }

        //        public void Delete(string id)
        //        {
        //            Contact contactDelete = GetContactByID(id);
        //​
        //            if (contactDelete != null)
        //                observableBook.Remove(contactDelete);
        //        }
        //​
        //        public IEnumerable<Contact> GetAll()
        //        {
        //            return contacts;
        //        }
        //​
        //        public Contact GetContactByID(string id)
        //        {
        //            return contacts.FirstOrDefault(c => c.ID == id);
        //        }
        //​
        //        public void Edit(string id, Contact c)
        //        {
        //            Contact contactEdit = GetContactByID(id);
        //​
        //            if (contactEdit == null)
        //                return;
        //​
        //            contactEdit.Name = c.Name;
        //            contactEdit.Surname = c.Surname;
        //            contactEdit.Phone = c.Phone;
        //​
        //        }
    }
}
