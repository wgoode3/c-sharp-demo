using System;
using System.Collections.Generic;

namespace DemoCode
{
    class Program
    {

        // shift array values to the left
        // [1, 2, 3, 4] => [2, 3, 4, 0]
        static int[] ShiftValuesLeft (int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = 0;
            return arr;
        }

        static List<object> GetObjectList ()
        {
            return new List<object> ()
            {
                "hello",
                15,
                "world",
                "22",
                -6
            };
        }

        static void PrintObjectList (List<object> ol)
        {
            string s = "";
            int num = 0;
            for (int i = 0; i < ol.Count; i++)
            {
                if (ol[i] is int)
                {
                    num += (int) ol[i];
                }
                else if (ol[i] is string)
                {
                    s += ol[i] + " ";
                }
            }
            Console.WriteLine($"the strings are:\n{s}");
            Console.WriteLine($"the numbers are:\n{num}");
        }

        // Random Array
        // Create a function called RandomArray() that returns an integer array
        // Place 10 random integer values between 5-25 into the array
        // Print the min and max values of the array
        // Print the sum of all the values

        static int[] RandomArray() 
        {
            int[] dissarray = new int[10];
            int min = 25;
            int max = 5;
            int sum = 0;
            Random rand = new Random();
            for(int i=0; i<10; i++)
            {
                dissarray[i] = rand.Next(5,26);
                sum += dissarray[i];
                if(dissarray[i] < min) 
                {
                    min = dissarray[i];
                }
                if(dissarray[i] > max) {
                    max = dissarray[i];
                }
            }
            Console.WriteLine($"min: {min}, max: {max}, sum {sum}");
            Console.WriteLine(String.Join(", ", dissarray));
            return dissarray;
        }

        static void Main (string[] args)
        {
            // int[] result = ShiftValuesLeft(new int[]{1,2,3,4});
            // Console.WriteLine(String.Join(", ", result));
            // Console.WriteLine(GetFlavor());
            Dictionary<string, string> result = IceCream.GetUsers();
            Console.WriteLine(result);
            foreach(KeyValuePair<string,string> entry in result) {
                Console.WriteLine($"{entry.Key} likes {entry.Value}");
            }
            // PrintObjectList( GetObjectList () );
            // RandomArray();
        }
    }
}