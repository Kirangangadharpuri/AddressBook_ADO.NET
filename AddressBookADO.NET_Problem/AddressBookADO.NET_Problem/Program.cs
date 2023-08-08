using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.NET_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Contacts contacts = new Contacts() { FirstName = "Kiran", LastName = "Puri", Address = "AP", City = "Jintur", State = "Maharashtra", Zip = 323232, PhoneNumber = 999999999, EmilID = "kiran@gmail.com" };
                AddressBook addressBook = new AddressBook();
                Console.WriteLine("1-INSERT DATA IN TABLE");
                Console.WriteLine("2-READ ALL DATA FROM TABLE");
                Console.WriteLine("Select above option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBook.AddNewContactInDatabase(contacts);
                        break;
                    case 2:
                        addressBook.GetAllDataFromDatabase();
                        break;
                }
            }
        }
    }
}
