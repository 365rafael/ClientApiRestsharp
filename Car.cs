using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiRestsharp
{
    internal class Car
    {
        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public string Name { get; set; } = default!;
        public int Year { get; set; }

        //Sempre que referenciar Car.ToString, vai listar o nome e ano do carro
        public override string ToString()
        {
            return $"{Name} - {Year}";
        }
    }
}
