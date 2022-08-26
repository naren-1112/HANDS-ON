
    class P1
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("1.Create\n2.Appeend\n3.Truncate\n");
                int x = Convert.ToInt32(Console.ReadLine());
                string path = "D:\\Mphasis\\C#\\25-Aug\\P1";
                Console.WriteLine("Enter the file name");
                string fname = Console.ReadLine();


                fname = string.Concat(path, fname);
                Console.WriteLine("--------------------------------");
                // file creation path
                switch (x)
                {
                    case 1:

                        FileStream f = new FileStream(fname, FileMode.Create);
                        StreamWriter s = new StreamWriter(f);

                        s.WriteLine("WELCOME");
                        s.Close();
                        f.Close();
                        Console.WriteLine("File created successfully...");
                        break;    //create

                    case 2:
                        Console.WriteLine("-----------------");

                        FileStream fs = new FileStream(fname, FileMode.Append);
                        StreamWriter ss = new StreamWriter(fs);

                        ss.WriteLine("Hiiii Naren");
                        ss.Close();
                        fs.Close();
                        Console.WriteLine(" Appended  successfully...");
                        break;//append
                    case 3:
                        Console.WriteLine("-----------------------");
                        FileStream fs1 = new FileStream(fname, FileMode.Truncate);
                        StreamWriter ss1 = new StreamWriter(fs1);

                        ss1.WriteLine("Hiiii Naren");
                        ss1.Close();
                        fs1.Close();
                        Console.WriteLine(" Truncated  successfully...");
                        break;//truncate

                        Console.ReadLine();

                }
            } while (true);
            

        }

    }
}
