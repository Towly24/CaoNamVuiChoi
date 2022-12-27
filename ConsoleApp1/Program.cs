using ConsoleApp1.assignment1;
using ConsoleApp1.session1;
using ConsoleApp1.session2;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;
                throw new Exception("y bang 0 mat roi");
                y++;
                float z = x / y;
                Console.WriteLine("z = " + z);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
        }
        static void Main1(string[] args)
        {
            Human h = new Human();
            h.Age= 1;
            h.Email = "abc@gmail.com";
            Student s = new Student();
            //s.telephone[0] = "0358556177";
            s[0] = "12312312";
            List<string> ls = new List<string>();
            ls.Add("hello");
            ls.Add("world");
            ls.Add("morning");
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction(10, 20);
            f2.xuat();
            f2.RutGon();
            Console.WriteLine($"{f2}");
        }
    }
}
