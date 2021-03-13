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

            int options;
            do
            {
                Console.WriteLine("Menu : \n1.Add Contact \n\n2.Edit Contact \n0.exit---press 0");
                options = Convert.ToInt32(Console.ReadLine());

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
                    case 2:
                        Console.WriteLine("Enter the Phone Number of Contact you wish to Edit");
                        long phoneNumber = long.Parse(Console.ReadLine());
                        int index = addressBook.FindByPhoneNum(phoneNumber);
                        if (index == -1)
                        {
                            Console.WriteLine("No Contact Exists With Following Phone Number");
                            continue;
                        }
                        else
                        {
                            Contact contact2 = new Contact();
                            setContactDetails(contact2);
                            addressBook.ContactList[index] = contact2;
                            Console.WriteLine("Contact Updated Successfully");
                        }
                        break;

                }
            } while (options != 0);
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
