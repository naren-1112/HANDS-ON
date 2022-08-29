using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
 public class product
    {
        public int _productID;

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        public string _productname;

        public string Productname
        {
            get { return _productname; }
            set { _productname = value; }
        }
        public static void ll()
        {
            List<int> productIDlist = new List<int>();
            List<string> producnamelist = new List<string>();
            Console.WriteLine("adding numbers");
            Console.WriteLine("----------");
            productIDlist.Add(1);
            productIDlist.Add(2);
            productIDlist.Add(3);
            //productIDlist.Add(3);
            Console.WriteLine("adding strings");
            Console.WriteLine("----------------");
            producnamelist.Add("Naren");
            producnamelist.Add("Sarath");
            producnamelist.Add("Praveen");
            foreach (var i in productIDlist)
            {
                Console.WriteLine(i);
            }
            foreach (var j in producnamelist)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("removing numers");
            Console.WriteLine("------------------");
            int Remove = 1;
            productIDlist.Remove(Remove);
            foreach (var i in productIDlist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("removing string");
            Console.WriteLine("------------------");
            string remove = "Naren";
            producnamelist.Remove(remove);
            foreach (var item in producnamelist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        
