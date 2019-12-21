using ContactList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.ViewModels
{
    class ContactViewModel : INotifyPropertyChanged
    {
        private Contact contact;

        public ContactViewModel()
        {
            contact = new Contact();
            contact.Name = String.Empty;
            contact.Surname = String.Empty;
            contact.Phone = String.Empty;
        }
        public ContactViewModel(Contact c)
        {
            contact = c;
        }
      
        public string Name
        {
            get { return contact.Name; }
            set
            {
                if (value != contact.Name)
                {
                    contact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string Surname
        {
            get { return contact.Surname; }
            set
            {
                if (value != contact.Surname)
                {
                    contact.Surname = value;
                    OnPropertyChanged(nameof(Surname));
                }
            }
        }
        public string Phone
        {
            get { return contact.Phone; }
            set
            {
                if (value != contact.Phone)
                {
                    contact.Phone = value;
                    OnPropertyChanged(nameof(Phone));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public override string ToString()
        {
            return $"{Name} {Surname}{Phone}";
        }
    }
}