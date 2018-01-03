using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCarStore
{
    class Car
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public CarType Type { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Car(byte id, string name, CarType carType, string color, int year)
        {
            Id = id;
            Name = name;
            Type = carType;
            Color = color;
            Year = year;
        }

        public Car(string name, CarType carType)
        {
            Name = name;
            Type = carType;
        }
    }
}
