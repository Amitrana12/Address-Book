using System;

namespace Address_book
{

    public static
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Welcome to Addresh book using console Apllicaation by Amit Rana");
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Menu : \n1.Add Contact \n2.exit---press 0");
            int options = Convert.ToInt32(Console.ReadLine());
            while (options != 0)
            {
               switch (options)
               {
                case 1:
                    Contact contact = new Contact();
                    setContactDetails(contact);
                    addressBook.AddContact(contact);
                    break;
                    default:
                        Console.WriteLine("sorry wrong input");
                        break;
                }
            } 
            Console.WriteLine(addressBook.ContactList.Count);
        }
        public static void setContactDetails(Contact contact)
        {
            
                Console.WriteLine("Enter the First Name");
                contact.FirstName = Console.ReadLine();
                Console.WriteLine("Enter the Last Name");
                contact.LastName = Console.ReadLine();
                Console.WriteLine("Enter the Address");
                contact.Address = Console.ReadLine();
                Console.WriteLine("Enter the City Name");
                contact.City = Console.ReadLine();
                Console.WriteLine("Enter the State Name");
                contact.State = Console.ReadLine();
                Console.WriteLine("Enter the zip code");
                contact.Zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Phone Number");
                contact.PhoneNumber = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter the email address");
                contact.Email = Console.ReadLine();
            
        }
        
    }

}
