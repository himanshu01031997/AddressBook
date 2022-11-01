namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();

            bool flag = true;
            Address address = new Address();
            while (flag)
            {
                Console.WriteLine("Please Enter the Choice :\n1.Add\n2.Edit\n3.Delete\n4.Add Multiple\n5.multiple AddressBook");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {

                    case 1:

                        {

                            Console.WriteLine("--------------------------");
                            Console.Write("first name :");
                            contact.FirstName = Console.ReadLine();
                            Console.Write("last name :");
                            contact.LastName = Console.ReadLine();
                            Console.Write("Address :");
                            contact.Address = Console.ReadLine();
                            Console.Write("City :");
                            contact.City = Console.ReadLine();
                            Console.Write("State :");
                            contact.State = Console.ReadLine();
                            Console.Write("Zip :");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            Console.Write("PhoneNo :");
                            contact.Phoneno = Console.ReadLine();
                            Console.Write("Email :");
                            contact.Email = Console.ReadLine();
                        }
                        Console.WriteLine("Display contact detail:");
                        address.AddContact(contact);
                        break;

                    case 2:
                        Console.WriteLine("enter firstname to edit");//we want to edit through first name
                        string FirstName = Console.ReadLine();
                        address.EditContact(FirstName);
                        break;
                    case 3:
                        Console.WriteLine("Enter First name to delete");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("------------------------------------\n");
                        Console.WriteLine("Display After Delete Contact");
                        Console.WriteLine("------------------------------------\n");
                        address.DeleteContact(firstName);
                        address.Display();
                        break;
                    case 4:
                        Console.WriteLine("add multiple contact:");
                        address.AddMultiple("ram", "singh", "bsnl", "bsp", "cg", 234234, "63663", "jshjdjs");
                        address.AddMultiple("himanshu", "singh", "bsnl", "bsp", "cg", 234234, "63663", "jshjdjs");
                        address.Display();
                        break ;
                    case 5:

                        address.MultipleAddressBook();
                        address.Display();

                        break;

                    default:
                       Console.WriteLine("invalid choice");
                        break;

                }
            }
        }
    }
}