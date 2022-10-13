namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("welcome to address book");
            Contact contact = new Contact()
            {
                FirstName = "Himanshu",
                LastName="Singh",
                Address="bsp",
                City="bilaspur",
                State="chhatisgarh",
                Zip=45666,
                Phoneno="989898999",
                Email="hsjsak@"
            };
            Console.WriteLine("firstname:"+ contact.FirstName+"\n"+"Lastname:"+contact.LastName+"\n"+"Address:"+contact.Address+"\n"+"city:"+contact.City+"\n"+"State:"+contact.State+"\n"+"Zip:"+contact.Zip+"\n"+"Phoneno:"+contact.Phoneno+"\n"+"Email:"+contact.Email);

        }
    }
}