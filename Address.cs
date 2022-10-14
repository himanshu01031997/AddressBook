using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Address
    {
        List<Contact> conta = new List<Contact>();
        public void AddContact(Contact contact)
        {
            conta.Add(contact);
            Display();
        }
        public void Display()
        {
            foreach (var contact in conta)
            {
                Console.WriteLine("FirstName: " + contact.FirstName + "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "Phone Number: " + contact.Phoneno + "\n" + "Email: " + contact.Email);
            }
        }
        public void EditContact(string name)
        {
            foreach (var contact in conta)
            {
                if (contact.FirstName == name)
                {
                    Console.WriteLine("-----------------------------\n");
                    Console.WriteLine("Enter The Option Which You Can Edit : ");
                    Console.WriteLine("1.Lastname\n2.Address\n3.City\n4.State\n5.Zip\n6.Phoneno\n7.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter LastName to Edit");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Address to Edit");
                            contact.Address = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter City to Edit");
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter State to Edit");
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter Zip to Edit");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter PhoneNo to Edit");
                            contact.Phoneno = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter Email to Edit");
                            contact.Email = Console.ReadLine();
                            break;
                    }
                    Console.WriteLine("------- Edited Contact  List --------");
                    Display();
                }
            }
        }
    }
}
