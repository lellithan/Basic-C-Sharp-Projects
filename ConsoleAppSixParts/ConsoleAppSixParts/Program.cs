using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {
        ////  Assignment Part 1 -
        ////  step 1 - create a one dimensional array of strings
        string[] yourChildren = { "Eliza", "Timmy", "Jimmy", "Sharon" };

        //  step 2 - print to the user asking for their input (their last name)
        Console.WriteLine("Congratulations on adopting 4 children!! Please enter your last name to update their names!");
        string lastName = Console.ReadLine();

        // step 3 - create a loop that iterates through our array and concatenates the user input
        // onto each element in the array
        for (int i = 0; i < yourChildren.Length; i++)
        {
            yourChildren[i] += (" " + lastName);
        }

        // step 4 - iterate through the updated array and print each element one at a time
        Console.WriteLine("Your children's new full names are: ");
        for (int i = 0; i < yourChildren.Length; i++)
        {
            Console.WriteLine(yourChildren[i]);
        }
        Console.ReadLine();

        //  Assignment Part Two -
        //  step 1 - create an infite loop
        //while (true)
        //{
        //    Console.Write("Help me...");
        //}

        // step 2 - fix the infinite loop by added a proper condition that will end at some point
        // changed the while to a for loop (more secure loop) added int i that ensure the console only prints, "Thank you!!", 1 time
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine("Thank you!!");
        }
        Console.ReadLine();

        //  ASsignment Part Three -
        //  step 1 - created a loop that utilizes a "<" comparison operator to iterate the loop
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);
        }

        //  step 3 - added another loop that behaves similary to the previous loop but use the "<=" operator instead
        //  this loop prints an additional number (3) because of the added equal sign
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();

        //  Assignment Part Four -
        //  step 1 - create a list of strings with 4 unique strings
        List<string> stringList = new List<string>() { "Ellie", "Shmellie", "Belly", "Kelly" };

        //  step 2 - asking the user for some text to search our list items. if we find a match we will add it to a count 
        Console.WriteLine("Enter text that we will search each element. If we find the text within we will add it to our count.");
        string userInput = Console.ReadLine();
        bool matchingText = false;

        //// step 3 - created a loop to iterate each item in our list and then checks if the current item match what the
        ////  what the user input. if we find a match we print the index to the console and flag that we got a match with our bool.
        ////  
        foreach (string item in stringList)
        {
            if (userInput == item)
            {
                Console.WriteLine("The index of your matched item is: " + stringList.IndexOf(item));
                matchingText = true;
                // step 5 - added code that stops the loop from executing once a match is found
                break;
            }
        }

        //// step 4 - code that will check if we never found a match in the list.
        //// if still false then we print to the console that we didnt find a match.
        if (matchingText == false)
        {
            Console.WriteLine("Sorry, there were no matches in the array. Please try again.");
        }
        Console.ReadLine();

        // Assignment Part Five -
        // step 1  create a list of strings that has at least two identical strings
        // and then ask the user for text to search in the list
        List<string> stringNumbers = new List<string>() { "Zero", "One", "One", "Three", "Four" };
        Console.WriteLine("Please enter a number 'One' through 'Four.' Please use proper capitalization and write it in English.");
        string userInputTwo = Console.ReadLine();
        bool foundMatch = false;

        // step 2 - created a for loop that will iterate every item in the list and print the index, even if there are multiples
        for (int i = 0; i < stringNumbers.Count; i++)
        {
            if (userInputTwo == stringNumbers[i])
            {
                Console.WriteLine("The index of your matched item is: " + i);
                foundMatch = true;
            }
        }

        // step 3 - code that tells the user no matches were found.
        if (foundMatch == false)
        {
            Console.WriteLine("Sorry, there were no matches in the list. Please try again.");
        }
        Console.ReadLine();

        //  Assignment Part 6 -
        //  step 1 - created a list of strings that has two identical strings
        List<string> partSixList = new List<string>() { "Zero", "One", "Two", "Four", "Four", "Six" };
        bool isDuplicate = false;
        List<string> printed = new List<string>{ };

        // step 2 - create a foreach loop that will iterate each item in the list
        // each item will be printed and if it is a duplicate print that it is.
        foreach (string item in partSixList)
        {
            //  set duplicate to false because we are in a new item
            isDuplicate = false;
            
            //  search our printed list to see if the current item we are using
            //  has already been added to the printed list.
            for (int i = 0; i < printed.Count; i++)
            {

                //  if the item is already in printed then isDuplicate = true
                if (item == printed[i]) 
                { 
                    isDuplicate = true; 
                }

            }

            //  add the item to our printed list so we can catch them in further checks
            printed.Add(item);

            //  if we have a duplicate then print that it is to the console. if not then run the else statement
            if (isDuplicate)
            {
                Console.WriteLine(item + " - this item is a duplicate.");
            }
            else
            {
                Console.WriteLine(item + " - this item is unique.");
            }
        }
        Console.ReadLine();
    }
}

