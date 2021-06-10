using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {0,1,2,3,4,5,6,7,8,9};
            foreach(int num in array1)
            {
                Console.WriteLine(num);
            }

            string[] array2 = {"Tim","Martin","Nikki","Sara"};
            foreach(string name in array2)
            {
                Console.WriteLine(name);
            }

            bool[] array3 = {true, false, true, false, true, false, true, false, true, false};
            foreach(bool trueFalse in array3)
            {
                Console.WriteLine(trueFalse);
            }

            List<string> flavors = new List<string>();

            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Rocky Road");
            flavors.Add("Mint Chocolate Chip");
            flavors.Add("Moose Tracks");

            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);

            flavors.Remove("Rocky Road");

            Console.WriteLine(flavors.Count);

            Dictionary<string,string> nameFlavors = new Dictionary<string, string>();

            nameFlavors.Add(array2[0], flavors[3]);
            nameFlavors.Add(array2[3], flavors[2]);
            nameFlavors.Add(array2[1], flavors[1]);
            nameFlavors.Add(array2[2], flavors[0]);

            foreach (KeyValuePair<string,string> entry in nameFlavors)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
