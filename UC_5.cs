using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        //declaring list with class contacts type
        public List<ContactDetails> contacts = new List<ContactDetails>();
        //This method for add new contact in address book
        public void AddContact()
        {
            //creating object of ContactDetails class
            ContactDetails contact = new ContactDetails();
            Console.Write("Enter First Name : ");
            //storing user input in contact
            contact.firstName = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            contact.lastName = Console.ReadLine();
            Console.Write("Enter address Name : ");
            contact.address = Console.ReadLine();
            Console.Write("Enter phone number : ");
            contact.phoneNumber = Console.ReadLine();
            Console.Write("Enter city Name : ");
            contact.city = Console.ReadLine();
            Console.Write("Enter state Name : ");
            contact.state = Console.ReadLine();
            Console.Write("Enter zip code : ");
            contact.zip = Console.ReadLine();
            //storing all input from user into contacts
            contacts.Add(contact);
        }
        //This method for view added Contact details
        public void ViewDetails()
        {
            //if statement for show nothing in list
            if (contacts.Count == 0)                                       
            {
                Console.WriteLine("Currently there are no people added in your addressbook.");
            }
            //else statement for show details of contacts in addressbook
            else
            {
                Console.WriteLine("Here is the list and details of all the contacts in your addressbook.");

                 //tforeacch loops iterates through all the contacts objects in the contacts class
                    foreach (var Detailing in contacts)
                    { 
                        Console.WriteLine("First name : " + Detailing.firstName);
                        Console.WriteLine("Last name : " + Detailing.lastName);
                        Console.WriteLine("Address : " + Detailing.address);
                        Console.WriteLine("State : " + Detailing.state);
                        Console.WriteLine("City : " + Detailing.city);
                        Console.WriteLine("Zip Code : " + Detailing.zip);
                        Console.WriteLine("Phone number = " + Detailing.phoneNumber);
                    }
            }
        }
        //This method for edit contact details
        public void EditDetails()                          
        {
            Console.WriteLine("Enter the first name of the contact you want to Modify.");
            Console.WriteLine();
            //taking input from user 
            string name = Console.ReadLine(); 
            //for each loop for show details of contacts
            foreach (var Details in contacts)
            {
                //if statement for first name of input matches with already existed contact first name
                if (name == Details.firstName)
                {
                    Console.Write("Enter First Name - ");
                    Details.firstName = Console.ReadLine();
                    Console.Write("Enter Last Name - ");
                    Details.lastName = Console.ReadLine();
                    Console.Write("Enter Address - ");
                    Details.address = Console.ReadLine();
                    Console.Write("Enter Phone number - ");
                    Details.phoneNumber = Console.ReadLine();
                    Console.Write("Enter Email ID - ");
                    Details.email = Console.ReadLine();
                    Console.Write("Enter City - ");
                    Details.city = Console.ReadLine();
                    Console.Write("Enter State - ");
                    Details.state = Console.ReadLine();
                    Console.Write("Enter ZIP code - ");
                    Details.zip = Console.ReadLine();
                    break;
                }
                //else statement from if input from user is mismatches with existing contact first name
                else
                {
                    Console.WriteLine("No such entry found. Please check and try again!");
                    break;
                }
            }

        }
        //this method for delete contact details
        public void DeleteContact()
        {
            //Taking input from user
            Console.Write("Enter the first name of contact you want to delete : ");
            Console.WriteLine();
            string name = Console.ReadLine();
            foreach (var Details in contacts)
            {
                //if statement for matching first name of existing contact with input taken from user
                if (name == Details.firstName)
                {
                    //if condition true then contact is deleted
                    Console.WriteLine("Do you want to delete this Contact ? (y/n)");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        contacts.Remove(Details);
                        Console.WriteLine("Contact is deleted.");
                        break;
                    }
                }
                //if condition is false then else condition is executed
                else
                {
                    Console.WriteLine("Contact is not present");
                }
            }
        }
    }
}
