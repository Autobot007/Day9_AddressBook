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
        }

        public void Delete()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            foreach (Contacts entry in entries)
            {
                if (entry.Firstname.Equals(name))
                {
                    entries.Remove(entry);
                    continue;
                }
                else
                {
                    Console.WriteLine(name + "is not avaiable into list");
                }
            }
        }

        public void Edit()
        {
            Console.WriteLine("Enter the First Name of User");
            String firstName=Console.ReadLine();
            foreach (Contacts entry in entries)              
            {
                if (firstName.Equals(entry.Firstname))
                {    
                    bool save = true;
                    while (save)
                    {
                        Console.WriteLine("First Name : " + entry.Firstname);
                        Console.WriteLine("Last Name : " + entry.Lastname);
                        Console.WriteLine("Address : " + entry.Address);
                        Console.WriteLine("Phone Number: " + entry.Phonenumber);
                        Console.WriteLine("City: " + entry.City);
                        Console.WriteLine("State : " + entry.State);
                        Console.WriteLine("Email : " + entry.Email);
                        Console.WriteLine("Enter the following to change data\n1.For Firstname\n2.For Lastname\n3.For Address\n4.For Phone Number\n5.For City\n6.For State\n7.Email");
                        int edit = Convert.ToInt32(Console.ReadLine());
                        switch (edit)
                        {
                            case 1:
                                Console.WriteLine("Enter the Correct name");
                                string name = Console.ReadLine();
                                entry.Firstname = name;
                                break;
                            case 2:
                                Console.WriteLine("Enter the Correct Last Name");
                                string lastName = Console.ReadLine();
                                entry.Lastname = lastName;
                                break;
                            case 3:
                                Console.WriteLine("Enter Correct Address");
                                string address = Console.ReadLine();
                                entry.Address = address;
                                break;
                            case 4:
                                Console.WriteLine("Enter correct Phone number");
                                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                                entry.Phonenumber = phoneNumber;
                                break;
                            case 5:
                                Console.WriteLine("Enter City");
                                string city = Console.ReadLine();
                                entry.City = city;
                                break;
                            case 6:
                                Console.WriteLine("Enter State");
                                string state = Console.ReadLine();
                                entry.State = state;
                                break;
                            case 7:
                                Console.WriteLine("Enter Email ");
                                string email = Console.ReadLine();
                                entry.Email = email;
                                break;
                            default:
                                Console.WriteLine("Please enter Valid input");
                                break;
                        }
                        Console.WriteLine("Enter 1 to save");
                        int intsave = Convert.ToInt16(Console.ReadLine());
                        if (intsave == 1)
                            save = false;
                    }
                }
                else
                {
                    Console.WriteLine("Following User does not exist in Database");

                }
            }

        }

        public void Display()
        {
            foreach (Contacts entry in entries)
            {
                Console.WriteLine(entry.Firstname);
            }
        }
       

    }
}