using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCarStore
{
    class Car
    {
        private byte Id { get; set; }
        private string Name { get; set; }
        private CarType Type { get; set; }
        private string Color { get; set; }
        private int Year { get; set; }

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
