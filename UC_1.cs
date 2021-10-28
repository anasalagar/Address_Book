using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_BookUC_1
{
    class Program
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private string City;
        private string State;
        private int Zip;
        private long Phone;
        private string Email;

        
        public Program(string firstName, string lastName, string address, string city, string state, int zip, long phone, string email)
        {       //variable declaration
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
            this.Email = email;
        }
        public void Display()
        {                                               //output shows
            Console.WriteLine("Contact details : " + "\n name :" + FirstName + " " + LastName + "\n Address : " + Address + " \n City name :" + City + "\n state name : " + State + "\n Zip code :" + Zip + "\n Phone Number :" + Phone + "\n Email ID: " + Email);
        }
    }
    class main
    {
        static void Main(string[] args)
        {                                                           //generate object
            Program myDetails = new Program("Anas", "Salagar", "303 sauth sadar bazar solapur", "solpaur", "MH", 300301, 9999999999, "alisalagar@gmail.com");
            myDetails.Display();
            Console.ReadLine();
        }
    }
}
