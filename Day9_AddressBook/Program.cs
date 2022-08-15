namespace Day9_AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("******************Welcome to Addres Book******************");
            Console.WriteLine("==========================================================");

            AddressBook addressbook = new AddressBook();
            while (true)
            {
                Console.WriteLine("1-add,2-display,3-remove");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressbook.AddContact();
                        break;
                    case 2:
                        addressbook.Display();
                        break;
                    case 3:
                         addressbook.Edit();
                        break;
                }
            }

        }
    }
}
