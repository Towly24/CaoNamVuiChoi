using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session3
{
    public class PhoneNumber
    {
        public PhoneNumber(string name, string phone) {
            Name = name;
            Phone = new List<string>();
            Phone.Add(phone);
        }
        public string Name { get; set; }
        public List<string> Phone { get; set; }
        public string this[int index]
        {
            get => Phone[index];
            set => this[index] = value;
        }
    }
}
