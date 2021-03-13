using System;

namespace Address_book
{

    public static
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("===Welcome to Addresh book using console Apllicaation by Amit Rana==");
            AddressBook addressBook = new AddressBook();

            int options;
            do
            {
                Console.WriteLine("\tChose options : \n1.Add Contact \n2.Edit Contact \n3.Delete user  \nPress ' 0 '(zero) for exit from  appliction");
                options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Contact contact = new Contact();
                        setContactDetails(contact);
                        addressBook.AddContact(contact);
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
                    case 3:
                        Console.WriteLine("Enter the First Name of Contact you wish to delete");
                        string fname = Console.ReadLine();
                        int idx = addressBook.FindByFirstName(fname);
                        if (idx == -1)
                        {
                            Console.WriteLine("No Contact Exists with Following First Name");
                            continue;
                        }
                        else
                        {
                            addressBook.DeleteContact(idx);
                            Console.WriteLine("Contact Deleted Successfully \n");
                        }
                        break;
                     default:
                        Console.WriteLine("sorry wrong input \n");
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
