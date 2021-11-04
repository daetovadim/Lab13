using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("1 Lenina st", 15, 10, 5);
            building.Print();

            MultiBuilding multiBuilding = new MultiBuilding("2 Lenina st", 15, 10, 20, 10);
            multiBuilding.Print();

            Console.ReadKey();
        }
    }
    class Building
    {
        public string Address;
        double length;
        double width;
        double height;

        public double Length
        {
            set
            {
                if (value > 0)
                    length = value;
                else
                    Console.WriteLine("Размер не может быть отрицательным");
            }
            get
            {
                return length;
            }
        }
        public double Width
        {
            set
            {
                if (value > 0)
                    width = value;
                else
                    Console.WriteLine("Размер не может быть отрицательным");
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                    height = value;
                else
                    Console.WriteLine("Размер не может быть отрицательным");
            }
            get
            {
                return height;
            }
        }

        public Building(string ad, double l = 1, double w = 1, double h = 1)
        {
            Length = l;
            Width = w;
            Height = h;
            Address = ad;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Здание с размерами (ШхДхВ) {Width}x{Length}x{Height}, находится по адресу {Address}");
        }
    }

    sealed class MultiBuilding:Building
    {
        double storeys;

        public double Storeys
        {
            set
            {
                if (value > 0)
                    storeys = value;
                else
                    Console.WriteLine("Количество этажей должно быть больше 0");
            }
            get
            {
                return storeys;
            }
        }

        public MultiBuilding(string ad, double l = 1, double w = 1, double h = 1, int s = 1)
            :base(ad, l, w, h)
        {
            Storeys = s;
        }

        public override void Print() => Console.WriteLine($"Здание с размерами (ШхДхВ) {Width}x{Length}x{Height}, находится по адресу {Address}, имеет {Storeys} этажей");
    }
}
