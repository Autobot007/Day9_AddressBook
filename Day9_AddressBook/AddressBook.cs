using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_AddressBook
{
    public class AddressBook
    {
        List<Contacts> entries = new List<Contacts>();
        public void AddContact()
        {
            Contacts con = new Contacts();
            Console.WriteLine("Enter Firstname");
            con.Firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            con.Lastname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            con.Address = Console.ReadLine();
            Console.WriteLine("Enter Phonenumber");
            con.Phonenumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter City");
            con.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            con.State = Console.ReadLine();
            Console.WriteLine("Enter Email");
            con.Email = Console.ReadLine();
            entries.Add(con);
            Console.WriteLine("\n\n\nContact Added\n\n\n\n\n\n");
            Console.WriteLine(entries);
        }

    }

}