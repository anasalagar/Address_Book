using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_New_Contact
{
    class Add_New_Contact
    {
        public static void AddNewContact()
        {
            
            List<string> add = new List<string>();
            Console.WriteLine("WELCOME TO ADDRESS BOOKING PROGRAM");
            Console.WriteLine("Enter numbers of person daitals : ");
            int count = Convert.ToInt32 (Console.ReadLine());
            
            while(count!=0)

            {
                Console.WriteLine("please, Enter the contact datails");
                
                Console.WriteLine("Enter first name : ");
                string firstName = Console.ReadLine();
                add.Add("your first name is "+firstName); // Add keyword -inbuilt function which is used to append the any values into array list.
                                                          //add uses difind function.
                                                          //we creste object firstname

                Console.WriteLine("Enter last name : ");
                string lastname = Console.ReadLine();
                add.Add("your last name is "+ lastname);

                Console.WriteLine("Enter address : ");
                string address = Console.ReadLine();
                add.Add("your address name is " + address);

                Console.WriteLine("Enter city name : ");
                string city = Console.ReadLine();
                add.Add("your city name is " + city);

                Console.WriteLine("Enter state name : ");
                string state = Console.ReadLine();
                add.Add("your state name is " + state);

                Console.WriteLine("Enter pin code: ");
                string zip = Console.ReadLine();
                add.Add("your pin code name is " + zip);

                Console.WriteLine("Enter phone number : ");
                string PhoneNumber = Console.ReadLine();
                add.Add("your contact number name is " + PhoneNumber);

                Console.WriteLine("Enter  Email ID : ");
                string mail = Console.ReadLine();
                add.Add("your MailId is " + mail);
                add.ForEach(Console.WriteLine);
                count--;
               
            }
        }
       
        static void Main(string[] args)
        {
            Add_New_Contact.AddNewContact();
            Console.ReadLine();
        }
    }
}
