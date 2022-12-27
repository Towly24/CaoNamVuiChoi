using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session1
{
    internal class Human
    {
        private string name;
        private int age;
        private int id;
        public Human()
        {

        }
        public Human(string s)
        {
            this.name = s;
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get => name;
            set => name = value; 
        }
        public int Age
        {
            get { return age; } set { }

        }
        public string Email { get; set; }
    }
}
