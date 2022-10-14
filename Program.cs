namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            Address address = new Address();


            Console.WriteLine("Please Enter the Choice :\n1.Add\n2.Edit");
            int Choice=Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine("enter first name");
                    string FirstName = Console.ReadLine();
                    address.EditContact(FirstName);
                    break;

                default:
                    Console.WriteLine("invalid choice");
                    break;



            }
        }
    }
}