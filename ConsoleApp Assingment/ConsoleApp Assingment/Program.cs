﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp_Assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] {"This", "is", "an", "array" };

            Console.WriteLine("Please add a word: ");
            string word = Console.ReadLine();
            bool array = true;

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + " " +word;
                Console.WriteLine(stringArray[i]);
            }


            while (array)
            {
                Console.WriteLine("Hello, World!");
                array = false;
            }


            int[] intArray = new int[]{ 1, 4, 34, 55, 0, 25 };
            for (int i = 0; i <= (intArray.Length - 1); i++)
            {
                Console.WriteLine(intArray[i]);
            }


            List<string> stringList = new List<string>() { "Melissa", "Pedro", "Juan","Miranda" };
            Console.WriteLine("Please type the name you wish to look for:");
            string name = Console.ReadLine();
            string fname = char.ToUpper(name[0]) + name.Substring(1);

            foreach (string names in stringList)
            {

                if (stringList.Contains(fname))
                {
                    Console.WriteLine(stringList.FindIndex(a => a.Contains(fname)));
                    break;


                }
                else
                {
                    Console.WriteLine("This name is not found");
                    break;
                }




            }

            List<string> fruits = new List<string>() { "apple", "orange", "cherry", "strawberry", "apple" };
            Console.WriteLine("Please type the fruit you wish to look for:");
            string userfruit = Console.ReadLine();
            string fruit1 = userfruit.ToLower();

            foreach (string fruit in fruits)
            {

                if (fruits.Contains(userfruit))
                {
                    
                    Console.WriteLine(fruits.FindIndex(a => a.Contains(userfruit)));
                    
                }
               
              
               

            }



            List<string> identicalList = new List<string>() { "mom", "dad", "daughter", "son", "daughter" };
            foreach (string family in identicalList)
            {
                if (identicalList.Count != identicalList.Distinct().Count())
                {
                    Console.WriteLine("There is a duplicate on the list");
                    break;
                }
                else
                {
                    Console.WriteLine("there are no duplicates on this list");
                    break;
                }
            }


            Console.ReadLine();
           
        }
    }
}