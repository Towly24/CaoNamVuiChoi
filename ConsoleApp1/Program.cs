using ConsoleApp1.assignment1;
using ConsoleApp1.session1;
using ConsoleApp1.session2;
using ConsoleApp1.session4;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp1.session5;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args) {
            CallApi cs = new CallApi();
            cs.FetchData();
        }
        static void Main4(string[] args) {
            //Thread t1 = new Thread(ThreadRun);
            //Thread t2 = new Thread(ThreadRunParam);
            //t2.IsBackground= true;
            //t1.Start();
            //t2.Start("T2203E");
            Number num = new Number() { x=0, y=0 };
            Thread n1 = new Thread(ThreadLock);
            Thread n2 = new Thread(ThreadLock);
            n1.Start(num);
            n2.Start(num);
        }
        static void ThreadRun()
        {
            for(int i = 0; i< 10; i++) {
            
                Console.WriteLine("i = " + i);
                try
                {
                    Thread.Sleep(1000);
                }catch(Exception e) { }
            }
        }
        static void ThreadRunParam(Object msg)
        {
            for (int i = 0; i < 20; i++)
            {

                Console.WriteLine("i = " + i);
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e) { }
            }
        }
        static void ThreadLock(object obj)
        {
            Number n = (Number)obj;
            for(int i = 0; i < 20; i++)
            {
                lock (n)
                {
                    n.ChangeXY();
                    n.PrintXY();
                }
                try
                {
                    Thread.Sleep(1000);
                }catch(Exception e) { }
            }
        }

        static void Main3(string[] args) {
            DemoEvent de = new DemoEvent();
            de.Invoke();
        }
        static void Main2(string[] args)
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
