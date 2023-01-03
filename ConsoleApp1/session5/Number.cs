using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session5
{
    public class Number
    {
        public int x { get; set; }
        public int y { get; set; }
        public void ChangeXY()
        {
            x++;
            y++;
        }
        public void PrintXY()
        {
            Console.WriteLine("X= " + x);
            Console.WriteLine("Y= " + y);
        }
    }
}
