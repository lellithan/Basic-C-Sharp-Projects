using System;
using System.Collections.Generic;

namespace ArrayAndListsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  create a string array and show the array to the user and then get an index variable from the user of which name they want to select
            string[] stringArray = { "Ellie", "Kelsey", "Alex", "Faron", "Nicole", "Carmen" };
            Console.WriteLine("Welcome to Data Collections Oregon!\nPick out a name using an indexed number! Starting with 0.");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            //  get the index from the user
            int index = Convert.ToInt32(Console.ReadLine());

            //  if the index that the user gives is out of range of our array then we inform the user and move to the next array
            if (index > stringArray.Length || index < 0)
            {
                Console.WriteLine("Index you entered is not within range of the array.");
            }
            else
            {
                Console.WriteLine(stringArray[index]);
            }
            
            //  start again but this time we use an integer array
            int[] intArray = { 1, 5, 50, 100, 105, 210 };
            Console.WriteLine("Pick out a integer using an indexed number! Starting with 0.");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            //  get the index
            index = Convert.ToInt32(Console.ReadLine());
            
            //  display an error message if needed
            if (index > intArray.Length || index < 0)
            {
                Console.WriteLine("Index you entered is not within range of the array.");
            }
            else
            {
                Console.WriteLine(intArray[index]);
            }

            //  create a list of data type strings and display it to the user
            List<string> stringList = new List<string>() { "Zero", "One", "Two", "Three", "Four", "Five" };
            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }

            //  get the indexed string that the user wants
            index = Convert.ToInt32(Console.ReadLine());

            // display error message if necessary
            if (index > stringList.Count || index < 0)
            {
                Console.WriteLine("Index you entered is not within range of the list.");
            }
            else
            {
                // if error is not flagged then print the indexed article
                Console.WriteLine(stringList[index]);
            }

            Console.ReadLine();
        }
    }
}
