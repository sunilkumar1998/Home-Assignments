using System;
using System.Collections.Generic;
using System.Text;

namespace productCatalog
{
    public class Category
    {
        Category[] Catelog = new Category[20];

        public int _Id;

        public string _Name;

        public string _shortCode;

        public string _Description;

        static int i = 0; 
        public Category() { }

        public Category(int id, string name, string description, string shortcode)
        {

            Id = id;
            Name = name;
            Description = description;
            ShortCode = shortcode;
        }

        public int Id{ get { return _Id; }  set { _Id = value; } }

        public string Name { get { return _Name; } set { _Name = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }

        public string ShortCode { get { return _shortCode; } set { _shortCode = value; } }

        

        public  void EnterAcategory(int id, string name, string shortcode, string description)
        {

            Catelog[i] = new Category(id, name, shortcode, description);

            i++;

        }
        public void Listcategory() {
            Console.WriteLine("Id    Name    shortCode   Description");

            Console.WriteLine("=======================================================");

            for (int i = 0; i <= Catelog.Length - 1; i++)
            {

                if (Catelog[i] != null)
                {
                    Console.Write("{0}\t", Catelog[i]._Id);

                    Console.Write("{0}\t", Catelog[i]._Name);

                    Console.Write("{0}\t", Catelog[i]._shortCode);

                    Console.Write("{0}\t", Catelog[i]._Description);

                    Console.WriteLine("");
                }
                
            }
        }
        public void DeleteAcategory() { }
        public void SearchAcategory(string name) 
        {
            for (int i = 0; i <= Catelog.Length - 1; i++)
            {
                if (Catelog[i].Name.ToLower() == name.ToLower())
                {
                    Console.Write("{0}\t", Catelog[i]._Id);

                    Console.Write("{0}\t", Catelog[i]._Name);

                    Console.Write("{0}\t", Catelog[i]._shortCode);

                    Console.Write("{0}", Catelog[i]._Description);

                    Console.WriteLine("");
                    break;
                }
            }
        }



        

    }
}
