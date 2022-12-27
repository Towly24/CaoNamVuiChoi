using ConsoleApp1.session1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session2
{
    internal class Student : Human
    {
        private string[] telephone = new string[3];

        public int age;
        public Student()
        {
        }
        public Student(String s, int a): base()
        {
            this.age = a;
        }
        public string this[int index]
        {
            get { return telephone[index];} set { telephone[index] = value; }
        }
    }
}
