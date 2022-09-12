using System;
using System.Threading;

namespace P4_mutex
{
    class Program
    {
        class MutexDemo
        {
            static void Main(string[] args)
            {
                //imterprocess
                using (Mutex mutex = new Mutex(false, "ThreadingDemo"))
                {

                    if (!mutex.WaitOne(1000, false))
                    {
                        Console.WriteLine("already running....");
                        Console.ReadLine();
                        return;

                    }
                    else
                    {
                        Console.WriteLine("app is running");
                        Console.ReadLine();
                    }

                }

            }
        }
    }
}

