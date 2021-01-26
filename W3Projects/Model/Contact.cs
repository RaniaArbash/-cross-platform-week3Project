using System;
namespace W3Projects
{
    public class Contact
    {
        public string name { get; set; }
        public string number { get; set; }
        public string image { get; set; }
        public Contact() { }
        public Contact(string name, string num)
        {
            this.name = name;
            this.number = num;
            
        }
    }
}
