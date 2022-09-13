//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P_B
{
    internal class Program
    {
        static void Main(string[] args)
        {

          Program.WritedataForEachCode(typeof(Song));
            Console.Read();
        }
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Methods " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);
            foreach (System.Attribute attr in attrs)
            {
                if (attr is DeveloperAttribute)
                {
                    DeveloperAttribute a = (DeveloperAttribute)attr;
                    Console.WriteLine(a.SongName);

                }
            }
            Console.WriteLine("---------------------------------");
            MemberInfo[] minfo = t.GetMembers();

            foreach (var item in minfo)
            {
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is DeveloperAttribute)
                    {
                        DeveloperAttribute a = (DeveloperAttribute)attrItem;
                        System.Console.WriteLine(a.SongName);
                        System.Console.WriteLine(a.Language);
                        System.Console.WriteLine(a.Lyrics);
                    }
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12SEP_HANDSON
{
    [Developer("New Album", SongName = "Love in the air")]
    public class Song
    {
        [Developer("Name of the song", SongName = "Fitoor")]
        public string SongName { get; set; }

        [Developer("Language of the song", Language = "Hindi")]
        public string Language { get; set; }

        [Developer("Lyrics", Lyrics = "abc")]

        [Developer("Language of the song", Language = "Hindi")]
        public string Lyrics { get; set; }


        public Song(string sname, string language, string lyrics)
        {
            SongName = sname;
            Language = language;
            Lyrics = lyrics;
        }
    }
}
