using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Models
{
    class Contact
    {
        private static int counterId = 0;
        public Contact()
        {
            Id=counterId++;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
    }
}
