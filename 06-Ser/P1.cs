//Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            person p;
            p = new employees();
            p.work();
            p = new manager();
            p.work();
            p = new clerk();
            p.work();    //1
            Console.WriteLine("-----------------------------------------");
            bank b1 = new bank();
            b1.print_balance();
            b1.calc_interest();     //2
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("savings account");
            banks b = new savi();
            b.print_balance();
            b.calc_interest();
            Console.WriteLine("current aacount");
            banks b2 = new current();
            b2.print_balance();
            b2.calc_interest();   //3   //4    
            Console.WriteLine("-----------------------------------------");
            bankss g = new bankss();



            g.current();
            g.savings();
            g.deposits();
            g.withdraw();
            g.total_balc();
            g.deposits1();
            g.withdraw1();
            g.total_balc1();            //5  //6   


            Console.WriteLine("-----------------------------------------");

        }
    }
}


//Class.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public abstract class person
    {

        public abstract void work();

    }
    public class employees : person
    {


        public override void work()
        {
            Console.WriteLine("calling emplpoyee");
        }
    }
    public class manager : person
    {


        public override void work()
        {
            Console.WriteLine("calling manager");
        }
    }
    public class clerk : person
    {


        public override void work()
        {
            Console.WriteLine("calling clerk");
        }
    }

}
public interface transaction
{

    void print_balance();
    void calc_interest();
}
public class bank : transaction
{

    public double amount;

    public bank()
    {

        amount = 0;
    }

    public void print_balance()
    {
        Console.WriteLine("ENTER THE AMOUNT");
        amount = Convert.ToDouble(Console.ReadLine());
    }
    public void calc_interest()
    {
        int r;
        Console.WriteLine("enter the interest to calculate");
        r = Convert.ToInt32(Console.ReadLine());
        double result = amount * r;
        Console.WriteLine("calc_interest " + result);
    }
}
public interface banks
{

    void print_balance();
    void calc_interest();
}
public class savi : banks
{

    public double amount;

    public savi()
    {

        amount = 0;
    }

    public void print_balance()
    {
        Console.WriteLine("ENTER THE AMOUNT");
        amount = Convert.ToDouble(Console.ReadLine());
    }
    public void calc_interest()
    {
        float r = 0.04f;

        double result = amount * r;
        Console.WriteLine("calc_interest " + result);
    }
}
public class current : banks
{

    public double amount;

    public current()
    {

        amount = 0;
    }

    public void print_balance()
    {
        Console.WriteLine("ENTER THE AMOUNT");
        amount = Convert.ToDouble(Console.ReadLine());
    }
    public void calc_interest()
    {
        float r = 0.02f;

        double result = amount * r;
        Console.WriteLine("calc_interest " + result);
    }
}
public class bankss
{
    public int x, y;
    public bankss()
    {
        x = 1000;
        y = 2000;
    }


}
public static class curr
{

    public static void current(this bankss obj)
    {
        Console.WriteLine("current balance " + obj.x);
    }
    public static void deposits(this bankss obj)
    {
        Console.WriteLine("enter the amount to deposit in current aacnt");
        int dep = Convert.ToInt32(Console.ReadLine());
        obj.x = dep + obj.x;
        Console.WriteLine("AMOUNT DEPOSIT");
    }
    public static void withdraw(this bankss obj)
    {
        Console.WriteLine("enter the amount to withdraw in current aacnt");
        int with = Convert.ToInt32(Console.ReadLine());
        if (with < obj.x)
            obj.x = obj.x - with;
        else
            Console.WriteLine("amount can't be withdraw");
        Console.WriteLine("AMOUNT WITHDRAW");

    }
    public static void total_balc(this bankss obj)
    {
        Console.WriteLine("total balance in current aacnt " + obj.x);
    }
}
public static class sav
{

    public static void savings(this bankss obj)
    {
        Console.WriteLine("saving balance" + obj.y);
    }
    public static void deposits1(this bankss obj)
    {
        Console.WriteLine("enter the amount to deposit in savings accnt");
        int dep = Convert.ToInt32(Console.ReadLine());

        obj.y = dep + obj.y;
        Console.WriteLine("AMOUNT DEPOSIT");
    }
    public static void withdraw1(this bankss obj)
    {
        Console.WriteLine("enter the amount to withdraw in savings accnt");
        int with = Convert.ToInt32(Console.ReadLine());
        if (with < obj.y)
            obj.y = obj.y - with;
        else
            Console.WriteLine("amount can't be withdraw");
        Console.WriteLine("AMOUNT WITHDRAW");
    }
    public static void total_balc1(this bankss obj)
    {
        Console.WriteLine("total balance in current aacnt " + obj.y);
    }
}
