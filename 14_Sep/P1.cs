//Program.cs

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

using _14Lib;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerUser s1 = new CustomerUser();
            s1.Id = 9677384564;
            s1.Password = "121922";
            s1.validate();
            CustomerUser s2 = new CustomerUser();
            s2.Id = 9677384564;
            s2.Password = "121922";
            s2.validate();
            FileStream fs = new FileStream(@"empty.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, s1);
            bf.Serialize(fs, s2);
            fs.Flush();
            fs.Close();
            fs.Dispose();
            FileStream fs1 = new FileStream(@"empty.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            CustomerUser[] s = new CustomerUser[2];
            for (int i = 0; i < 2; i++)
            {

                s[i] = (CustomerUser)bf1.Deserialize(fs1);
            }
            foreach (var item in s)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Password);
                Console.WriteLine(item.login);
                Console.WriteLine(item.date);
            }

            fs1.Flush();
            fs1.Close();
            fs1.Dispose();
            Searching si1 = new Searching();
            si1.initiate();
            si1.DisplayMovies();
            si1.search();
            FileStream fs2 = new FileStream(@"empty1.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter write = new BinaryFormatter();
            write.Serialize(fs2, si1);
            fs2.Flush();
            fs2.Close();
            fs2.Dispose();
            FileStream fs3 = new FileStream(@"empty1.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter read = new BinaryFormatter();
            Searching si2 = new Searching();
            si2 = (Searching)read.Deserialize(fs3);
            foreach (var item in si2.Search)
            {
                Console.WriteLine($"{item.mname} {item.mlanguage} {item.mgenre} {item.mstock}");
            }
            fs3.Flush();
            fs3.Close();
            fs3.Dispose();


            Console.WriteLine("Add watchlist");
            Watch e1 = new Watch();
        mer:

            Console.WriteLine("enter name of movie");
            e1.Addtowatchlist();
            Console.WriteLine("Enter yes to continue");
            string d = Console.ReadLine();
            if (d == "yes")
            {
                goto mer;
            }
            foreach (var item in e1.watchlist)
            {

                Console.WriteLine($"{item.Item1.mname} {item.Item1.mlanguage} {item.Item1.mgenre} {item.Item1.mstock} {item.Item2}");
            }
            string s11 = JsonConvert.SerializeObject(e1);
            FileStream fs7 = new FileStream(@"empty3.json", FileMode.Create, FileAccess.Write);
            StreamWriter w1 = new StreamWriter(fs7);
            w1.Write(s11);
            w1.Close();
            w1.Dispose();
            fs7.Close();
            fs7.Dispose();
            FileStream fs8 = new FileStream(@"empty3.json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs8);
            string s12 = sr.ReadToEnd();

            Watch s22 = JsonConvert.DeserializeObject<Watch>(s12);
            foreach (var item in s22.watchlist)
            {

                Console.WriteLine($"{item.Item1.mname} {item.Item1.mlanguage} {item.Item1.mgenre} {item.Item1.mstock} {item.Item2}");
            }
            Console.WriteLine("Already seen movie");
            e1.releaselist();
            List<Movie> dgg = new List<Movie>();
            foreach (var item in e1.release)
            {
                dgg.Add(item.Item1);
            }
            s1.alreadyseen = dgg;
            FileStream fs4 = new FileStream(@"empty2.Xml", FileMode.Create, FileAccess.Write);
            System.Xml.Serialization.XmlSerializer xm = new System.Xml.Serialization.XmlSerializer(typeof(CustomerUser));
            xm.Serialize(fs4, s1);
            fs4.Flush();
            fs4.Close();
            fs4.Dispose();
            FileStream fs5 = new FileStream(@"empty2.Xml", FileMode.Open, FileAccess.Read);
            System.Xml.Serialization.XmlSerializer ms = new System.Xml.Serialization.XmlSerializer(typeof(CustomerUser));
            var t = (CustomerUser)ms.Deserialize(fs5);
            Console.WriteLine("Already seen movies");
            foreach (var item in t.alreadyseen)
            {
                Console.WriteLine($"{item.mname} {item.mlanguage} {item.mgenre} {item.mstock}");
            }
            fs5.Flush();
            fs5.Close();
            fs5.Dispose();
            Console.WriteLine("Cost of which movie you want to know");
            string id = Console.ReadLine();
            e1.totalcostassociated(id);
            FileStream fs9 = new FileStream(@"empty4.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter write1 = new BinaryFormatter();
            write1.Serialize(fs9, e1);
            fs9.Flush();
            fs9.Close();
            fs9.Dispose();
            FileStream fs81 = new FileStream(@"empty4.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter read1 = new BinaryFormatter();

            var sii2 = (Watch)read.Deserialize(fs81);
            foreach (var item in sii2.total)
            {
                Console.WriteLine($"{item.Item1} {item.Item2} {item.Item3}");
            }
            fs81.Flush();
            fs81.Close();
            fs81.Dispose();


        }
    }
}


//Class.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml.Schema;

namespace _14Lib
{
    [Serializable()]
    public class Movie
    {
        public string mname
        {
            get;
            set;
        }
        public string mlanguage { get; set; }
        public string mgenre { get; set; }
        public int mstock { get; set; }
        public Movie(string name, string language, string genre, int stock)
        {
            mname = name;
            mlanguage = language;
            mgenre = genre;
            mstock = stock;

        }
        public Movie()
        {

        }
    }

    [Serializable()]
    public class Searching
    {
        public List<Movie> Search
        {
            get;
            set;
        }
        public static List<Movie> movies = new List<Movie>();
        public void initiate()
        {
            movies.Add(new Movie("Vikram", "Tamil", "Action", 20));
            movies.Add(new Movie("Thiruchitrambalam", "Tamil", "Romance", 40));
            movies.Add(new Movie("Premam", "Malayalam", "Romance", 50));
            movies.Add(new Movie("Pushpa", "Telugu", "Action", 60));
            movies.Add(new Movie("Conjuring", "English", "Horror", 34));
        }
        public void search()
        {
            Console.WriteLine("Search by\n 1.Name\n 2.Language\n 3.Genre");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                    Console.WriteLine("Enter the movie name to search");
                    string q = Console.ReadLine();
                    var pt = movies.Where(pi => pi.mname == q).ToList();
                    if (pt != null)
                    {
                        Search = pt;
                    }
                    else
                    {
                        Console.WriteLine("Movie unavailable");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the movie language to search");
                    string qq = Console.ReadLine();
                    var tp = movies.Where(pi => pi.mlanguage == qq).ToList();
                    if (tp != null)
                    {
                        Search = tp;
                    }
                    else
                    {
                        Console.WriteLine("Language unavailable");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the movie genre to search");
                    string qqq = Console.ReadLine();
                    var tpp = movies.Where(pi => pi.mgenre == qqq).ToList();
                    if (tpp != null)
                    {
                        Search = tpp;
                    }
                    else
                    {
                        Console.WriteLine("Language unavailable");
                    }
                    break;

            }
        }
        public void AddMovies()
        {
            Movie m = new Movie();
            Console.WriteLine("Enter movie name");
            m.mname = Console.ReadLine();
            Console.WriteLine("Enter movie language");
            m.mlanguage = Console.ReadLine();
            Console.WriteLine("Enter movie genre");
            m.mgenre = Console.ReadLine();
            Tuple<string, string, string> mi = Tuple.Create<string, string, string>(m.mname, m.mlanguage, m.mgenre);
            Predicate<Tuple<string, string, string>> k = (i) =>
            {
                int flag = 0;
                foreach (var item in movies)
                {
                    if (item.mname == i.Item1 && item.mlanguage == i.Item2 && item.mgenre == i.Item3)
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            if (k(mi))
            {
                Console.WriteLine("Already Exists");
            }
            else
            {
                movies.Add(m);

            }
        }
        public void DeleteMovies()
        {

            Movie md = new Movie();
            Console.WriteLine("Enter movie name");
            md.mname = Console.ReadLine();
            Console.WriteLine("Enter movie language");
            md.mlanguage = Console.ReadLine();
            Console.WriteLine("Enter movie genre");
            md.mgenre = Console.ReadLine();
            foreach (var item in movies)
            {
                if (item.mname == md.mname && item.mlanguage == md.mlanguage && item.mgenre == md.mgenre)
                {

                    movies.Remove(item);
                }

            }

        }

        public void DisplayMovies()
        {
            foreach (var item in movies)
            {
                Console.WriteLine($"{item.mname} {item.mlanguage} {item.mgenre}");
            }
        }
    }
    [Serializable()]
    public class CustomerUser : Searching
    {

        public long Id { get; set; }

        public string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string login
        {
            get;
            set;
        }
        public DateTime date
        {
            get { return DateTime.Now; }
        }
        public bool validate()
        {
            if (Id == 7904358017 && Password == "123456789")
            {
                login = "true";
                return true;
            }
            else
            {
                login = "false";
                return false;
            }
        }


        public List<Movie> alreadyseen
        {
            get;
            set;
        }





    }
    [Serializable()]
    public class Watch : Searching
    {
        public List<Tuple<Movie, DateTime>> watchlist = new List<Tuple<Movie, DateTime>>();
        public List<Tuple<Movie, int>> release = new List<Tuple<Movie, int>>();
        public List<Tuple<string, int, double>> total = new List<Tuple<string, int, double>>();
        public void Addtowatchlist()
        {
            string s = Console.ReadLine();
            var pi = movies.Where(p => p.mname == s).ToList();
            if (pi != null)
            {
                foreach (Movie item in pi)
                {

                    Console.WriteLine(item.mname);

                    movies.Remove(item);
                    item.mstock = item.mstock - 1;
                    Console.WriteLine("Enter year");
                    int yr1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month");
                    int mon1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter date");
                    int dt1 = Convert.ToInt32(Console.ReadLine());
                    DateTime t1 = new DateTime(yr1, mon1, dt1);

                    Tuple<Movie, DateTime> ji = Tuple.Create<Movie, DateTime>(item, t1);
                    movies.Add(item);
                    watchlist.Add(ji);


                }

            }
            else
            {
                Console.WriteLine("Cannot be added");
            }

        }
        public void releaselist()
        {

            string cp = Console.ReadLine();
            Tuple<Movie, DateTime> k = null;
            foreach (var item in watchlist)
            {
                if (cp == item.Item1.mname)
                {
                    k = item;

                    movies.Remove(item.Item1);
                    item.Item1.mstock = item.Item1.mstock + 1;

                    Console.WriteLine("Enter year");
                    int yr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month");
                    int mon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter date");
                    int dt = Convert.ToInt32(Console.ReadLine());
                    DateTime t = new DateTime(yr, mon, dt);
                    TimeSpan ts = t - item.Item2;
                    Tuple<Movie, int> poi = Tuple.Create<Movie, int>(item.Item1, ts.Days);
                    release.Add(poi);
                    movies.Add(item.Item1);


                }


            }
            watchlist.Remove(k);
        }
        public void totalcostassociated(string p)
        {
            int flag = 0;
            foreach (var item in release)
            {
                if (p == item.Item1.mname)
                {
                    flag = 1;
                    Console.WriteLine(item.Item1.mname);
                    Console.WriteLine("Enter the cost for one day");
                    double Cost = Convert.ToInt32(Console.ReadLine());
                    double k = 0.18 * Cost;
                    double ty = item.Item2 * 0.01 * Cost;
                    double yt = k + ty + Cost;
                    Console.WriteLine($"GST is {k}");
                    Console.WriteLine($"Bluray cost is {ty}");
                    Console.WriteLine("Total cost is" + " " + yt);
                    Tuple<string, int, double> k2 = Tuple.Create(item.Item1.mname, item.Item2, yt);

                    total.Add(k2);
                }
            }
            foreach (var item in watchlist)
            {
                if (p == item.Item1.mname)
                {
                    Console.WriteLine(item.Item1.mname);
                    Console.WriteLine("Enter the cost for one day");
                    double Cost = Convert.ToInt32(Console.ReadLine());
                    TimeSpan tu = DateTime.Now - item.Item2;
                    double k = 0.18 * Cost;
                    double ty = (tu.Days) * 0.01 * Cost;
                    double yt = k + ty + Cost;
                    Console.WriteLine($"GST is {k}");
                    Console.WriteLine($"Bluray cost is {ty}");
                    Console.WriteLine("Total cost is" + " " + yt);
                    Tuple<string, int, double> k2 = Tuple.Create(item.Item1.mname, tu.Days, yt);

                    total.Add(k2);
                }
                else if (flag != 1)
                {
                    foreach (var item1 in movies)
                    {
                        if (p == item1.mname)
                        {

                            Console.WriteLine(item1.mname);
                            Console.WriteLine("Enter the cost for one day");
                            double Cost = Convert.ToInt32(Console.ReadLine());

                            double k = 0.18 * Cost;
                            double ty = 0 * 0.01 * Cost;
                            double yt = k + ty + Cost;
                            Console.WriteLine($"GST is {k}");
                            Console.WriteLine($"Bluray cost is {ty}");
                            Console.WriteLine("Total cost is" + " " + yt);
                            Tuple<string, int, double> k2 = Tuple.Create(item.Item1.mname, 0, yt);

                            total.Add(k2);
                        }
                    }

                }
            }
        }


    }
}
