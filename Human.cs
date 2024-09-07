using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Human
    {
        private String name;
        private int age;

        public Human()
        {
            this.name = String.Empty;
            this.age = 0;
        }

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
    }
}
