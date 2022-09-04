// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;

namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Category[] cs = new Category[2];
                for (int i = 0; i < cs.Length; i++)
                {
                    Category c = new Category();
                    Console.WriteLine("Enter category ID");
                    c.ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Category name");
                    c.Name = Console.ReadLine();
                    Console.WriteLine("Enter desc");
                    c.Desc = Console.ReadLine();
                    cs[i] = c;
                    List<Products> product = new List<Products>();
                    for (int j = 0; j < 2; j++)
                    {
                        Products p = new Products();
                        Console.WriteLine("Enter Product Id");
                        p.Productid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product name");
                        p.Productname = Console.ReadLine();
                        p.AddProduct(p.Productid, p.Productname);

                        product.Add(p);
                        cs[i].AddProdut();


                    }
                    cs[i].prod = product;

                }

                for (int i = 0; i < 2; i++)
                {
                    cs[i].Display();
                }
                Console.ReadLine();
            }
        }
    }
    
    // Class.cs
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Category
    {
        private int categoryid;
        public int ID
        {
            get { return categoryid; }
            set { categoryid = value; }
        }
        private string categoryname;
        public string Name
        {
            get { return categoryname; }
            set { categoryname = value; }
        }
        private string description;
        public string Desc
        {
            get { return description; }
            set { description = value; }

        }
        public List<Products> product;
        public List<Products> prod
        {
            get { return product; }
            set
            {
                product = value;
            }
        }
        static int cnt = 0;
        public void AddProdut()
        {
            cnt++;
            Console.WriteLine("Product added {0}", cnt);
        }
        public void DeleteProduct()
        {
            cnt--;
            Console.WriteLine("Product added {0}", cnt);
        }
        public Category()
        {

        }
        public void AddCategory(int id, string name, string desc)
        {
            categoryid = id;
            categoryname = name;
            description = desc;
        }
        public void Display()
        {
            Console.WriteLine(categoryid);
            Console.WriteLine(categoryname);
            Console.WriteLine(description);
            foreach (var item in product)
            {
                Console.WriteLine(item.Productid);
                Console.WriteLine(item.Productname);

            }
        }

    }
    public class Products
    {
        private int productid;
        public int Productid
        {
            get { return productid; }
            set { productid = value; }
        }
        private string productname;
        public string Productname
        {
            get { return productname; }
            set { productname = value; }
        }
        private int qtysold;
        public int Qtysold
        {
            get { return qtysold; }
            set { qtysold = value; }
        }
        private int quanInhand;
        public int QuanInhand
        {
            get { return quanInhand; }
            set
            {
                quanInhand = value;
            }
        }
        private int unitprice;
        public int Unitprice
        {
            get { return unitprice; }
            set
            {
                unitprice = value;
            }
        }
        private string unit;
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
            }
        }

        public void Reorder()
        {
            int reorder;
            reorder = qtysold;

        }
        public void AddProduct(int id, string name)
        {
            productid = id;
            productname = name;

        }
    }
}
    
    
