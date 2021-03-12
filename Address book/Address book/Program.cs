using System;

namespace Address_book
{

    public static
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Welcome to Addresh book using console Apllicaation by Amit Rana");
            setContactDetails();
        }
        public static void setContactDetails()
        {
            Contact obj = new Contact();
                Console.WriteLine("Enter the First Name");
                obj.FirstName = Console.ReadLine();
                Console.WriteLine("Enter the Last Name");
                obj.LastName = Console.ReadLine();
                Console.WriteLine("Enter the Address");
                obj.Address = Console.ReadLine();
                Console.WriteLine("Enter the City Name");
                obj.City = Console.ReadLine();
                Console.WriteLine("Enter the State Name");
                obj.State = Console.ReadLine();
                Console.WriteLine("Enter the zip code");
                obj.Zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Phone Number");
                obj.PhoneNumber = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter the email address");
                obj.Email = Console.ReadLine();
            
        }
        
    }

}
