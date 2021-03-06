﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Sorting *****\n");
            // Make an array of Car objects.
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);
            Console.ReadLine();

            // display current array
            Console.WriteLine("Here is unordered set of cars:");
            foreach(Car c in myAutos)
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);

            // and now sorted
            Array.Sort(myAutos);
            Console.WriteLine();

            // Display sorted array
            Console.WriteLine("Here is the ordered set of cars:");
            foreach(Car c in myAutos)
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            Console.ReadLine();

            // now sort by pet name
            Array.Sort(myAutos, new PetNameComparer());

            // Dump sorted array
            Console.WriteLine("Ordering by pet name:");
            foreach (Car c in myAutos)
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);

            Array.Sort(myAutos, Car.SortByPetName);

            Console.ReadLine();

        }
    }
}
