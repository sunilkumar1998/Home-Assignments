using System;

namespace productCatalog
{
    class Program
    {
        public static string command;
        public static string command2;

        static void Main(string[] args)
        {
            Category cat = new Category();

            do
            {
                Console.WriteLine("Enter the number of the command you want: ");

                Console.WriteLine("1. Category ");

                Console.WriteLine("2. product ");

                Console.WriteLine("3. Exit the App ");

                command = Console.ReadLine();

               


                switch (command)
                {

                    case "1":
                        {


                            do
                            {
                                Console.WriteLine("");

                                Console.WriteLine("");
                                Console.WriteLine("Enter further choices: ");

                                Console.WriteLine("1. Enter a Category ");
                                Console.WriteLine("2. List All Categories ");

                                Console.WriteLine("3. Search ");

                                Console.WriteLine("4. Delete ");


                                Console.WriteLine("5. Exit ");

                                command2 = Console.ReadLine();
                                switch (command2)
                                {

                                    case "1":
                                        {
                                            Console.WriteLine("Enter the number of records you want to enter");
                                            int n = Convert.ToInt32(Console.ReadLine());

                                            for (int i = 0; i < n; i++)
                                            {

                                                Console.WriteLine("Enter the record");
                                                Console.Write("Id: ");

                                                int Id = Convert.ToInt32(Console.ReadLine());

                                                Console.Write("Name: ");

                                                string Name = Console.ReadLine();

                                                Console.Write("short code: ");

                                                string ShortCode = Console.ReadLine();

                                                Console.Write("Description: ");

                                                string Description = Console.ReadLine();

                                                cat.EnterAcategory(Convert.ToInt32(Id), Name, ShortCode, Description);
                                            }
                                            break;
                                        }


                                    case "2":
                                        {
                                            cat.Listcategory();

                                            break;
                                        }

                                    case "3":
                                        {
                                            Console.WriteLine("Enter the name of category you want to search");
                                            string searchname = Console.ReadLine();
                                            cat.SearchAcategory(searchname);

                                            break;
                                        }
                                }
                            } while (command2 != "5");

                                break;

                            }
                    case "2":
                        {

                            Console.WriteLine("Product works");
                            break;

                        }

                }


            } while (command != "3"); 
        }
        }
}
