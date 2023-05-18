using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        //ContactClass contact = new ContactClass();
        public static List<ContactClass> contactList = new List<ContactClass>();

        public static void AddNewContact()
        {
            Console.WriteLine("if you want to edit add new deatails press 1 or press 2 to cancle.");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num == 1)
            {
                ContactClass contact = new ContactClass();

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

                contactList.Add(contact);

                Console.WriteLine("if you want to edit details press 1 to edit or press 2 to cancle.");
                num = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Total number of contact in address book:" + contactList.Count);

            foreach (ContactClass contact in contactList)
            {
                Console.WriteLine(contact.FirstName);
            }

            Console.WriteLine("if you want to edit details press 1 to edit or press 2 to cancle.");
            num = Convert.ToInt32(Console.ReadLine());

            while (num == 1)
            {
                Console.WriteLine("Enter first name for edit: ");
                string FirstName = Console.ReadLine();
                bool found = false;
                for (int i = 0; i < contactList.Count; i++)
                {

                    if (contactList[i].FirstName == FirstName)
                    {
                        found = true;

                        Console.WriteLine("Enter first name: ");
                        contactList[i].FirstName = Console.ReadLine();

                        Console.WriteLine("Enter last name: ");
                        contactList[i].LastName = Console.ReadLine();

                        Console.WriteLine("Enter address: ");
                        contactList[i].Address = Console.ReadLine();

                        Console.WriteLine("Enter city: ");
                        contactList[i].City = Console.ReadLine();

                        Console.WriteLine("Enter state: ");
                        contactList[i].State = Console.ReadLine();

                        Console.WriteLine("Enter phone: ");
                        contactList[i].Zip = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter email: ");
                        contactList[i].PhoneNumber = Console.ReadLine();

                        Console.WriteLine("Enter zipcode: ");
                        contactList[i].Email = Console.ReadLine();
                        break;

                    }
                }

                if (!found)
                    Console.WriteLine("the contact with given person {0} is not in address book", FirstName);
                
                Console.WriteLine("Current contacts in adress book");
                foreach (ContactClass contact in contactList)
                {
                    Console.WriteLine(contact.FirstName);
                }
                Console.WriteLine("if you want to edit details press 1 to edit or press 2 to cancle.");
                num = Convert.ToInt32(Console.ReadLine());

            }

            //deleting

            Console.WriteLine("Do you want to delete contact press 1 to delete or press 2 to cancle.");
            num = Convert.ToInt32(Console.ReadLine());

            while (num == 1 && contactList.Count > 0)
            {
                Console.WriteLine("Enter contact First name");
                string firstName = Console.ReadLine();

                bool found = false;
                for (int i = 0; i < contactList.Count; i++)
                {

                    if (contactList[i].FirstName == firstName)
                    {
                        found = true;  

                        contactList.RemoveAt(i);
                        break;

                    }
                }

                if (found)
                {
                    if (contactList.Count == 0) 
                        break;
                }
                else
                    Console.WriteLine("the contact with given person '{0}' is not in address book", firstName);

                Console.WriteLine("Current contacts in adress book");
                foreach (ContactClass contact in contactList)
                {
                    Console.WriteLine(contact.FirstName);
                }
                Console.WriteLine("Do you want to delete contact press 1 to delete or press 2 to cancle.");
                num = Convert.ToInt32(Console.ReadLine());

            }//while end


        }
    }
}
