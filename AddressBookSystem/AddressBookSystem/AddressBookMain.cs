using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        ContactClass contact = new ContactClass();

        public void AddNewContact()
        {
            Console.WriteLine("Enter First Name");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter your Address");
            contact.Address = Console.ReadLine();


            Console.WriteLine("Enter your City");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter your State");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter your ZIP");
            contact.Zip = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Phone Number");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter your Email");
            contact.Email = Console.ReadLine();
        }

        public void Display()
        {

            Console.WriteLine("print here your all  details");
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" +
                contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber +
                "\n" + contact.Email);
        }
    }
}
