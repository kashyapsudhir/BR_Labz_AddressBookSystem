using System;
using System.Transactions;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Address Book Program in AddressBookMain class on main branch");

            //ContactClass contact = new ContactClass();

            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookMain.AddNewContact();

            addressBookMain.Display();

            //Console.WriteLine("Enter First Name");
            //contact.FirstName = Console.ReadLine();

            //Console.WriteLine("Enter Last Name");
            //contact.LastName = Console.ReadLine();

            //Console.WriteLine("Enter your Address");
            //contact.Address = Console.ReadLine();


            //Console.WriteLine("Enter your City");
            //contact.City = Console.ReadLine();

            //Console.WriteLine("Enter your State");
            //contact.State = Console.ReadLine();

            //Console.WriteLine("Enter your ZIP");
            //contact.Zip = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your Phone Number");
            //contact.PhoneNumber = Console.ReadLine();

            //Console.WriteLine("Enter your Email");
            //contact.Email = Console.ReadLine();




        }

       
    }
}