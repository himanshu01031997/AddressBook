namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact("Himanshu","Singh","bsnl","bsp","cg",76778,"89887776","hs@gmail.com");
            Console.WriteLine("FirstName: " +contact.FirstName);
            Console.WriteLine("LastName: "+contact.LastName);
            Console.WriteLine("Address: "+contact.Address);
            Console.WriteLine("City: " + contact.City);
            Console.WriteLine("State: "+contact.State);
            Console.WriteLine("Zip: "+contact.Zip);
            Console.WriteLine("Phoneno: "+contact.Phoneno);
            Console.WriteLine("Email:"+contact.Email);
        
        
        }
    }
}