using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public string Phoneno;
        public string Email;
        public Contact(string firstName, string lastName, string address, string city, string state, int zip, string phoneno, string email)
        {
           this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phoneno = phoneno;
            this.Email = email;
        }
    }
}
