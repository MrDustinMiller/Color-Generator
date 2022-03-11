using System;

namespace DevinColors
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initalize array of colors
            string[] colors = { "Red", "Blue", "Black", "Green", "Brown", "Pink", "Purple", "Orange", "Yellow", "Light Blue", "Almond", "Amethyst", "Bubble Gum", "Canary Yellow", "Dark Orange",
                                "Dark Blue", "Light Green", "Deep Black", "Bright Red", "Turquoise", "Grey", "Magenta", "Air Force Blue"};

            //call function
            UserColors(colors);
        }//end main

        static void UserColors(string[] colors)
        {
            //vars
            int userInput;
            int count = -1;
            char y = 'y';
            char n = 'n';

            //get user input on number of colors to select
            Console.Write("How many colors do you want to choose today? ");
            bool success = int.TryParse(Console.ReadLine(), out userInput);

            //create random number generator
            Random numberGen = new Random();

            //display setup
            Console.Write("Your colors are: ");

            //for loop to run through the array 
            for (int i = 0; i < userInput; i++)
            {
                //number generator runs through our array starting from index 0 through the whole length
                colors[i] = colors[numberGen.Next(0, colors.Length)];

                //display formatted colors
                Console.Write("{0}, ", colors[i]);
            }//end for

            Console.WriteLine();

            //ask user if they would like to generate another set of colors
            Console.WriteLine("\nGo one more time? y/n ");

            //read the key press
            ConsoleKeyInfo info = Console.ReadKey();

            while (count < 0)
            {
                if (info.KeyChar == y) //then
                {
                    //disply new set statement
                    Console.WriteLine("\n");
                    Console.Write("Your new set of colors is: ");

                    //for loop to run through array one more time
                    for (int i = 0; i < userInput; i++)
                    {
                        colors[i] = colors[numberGen.Next(0, colors.Length)];

                        //display new set of colors
                        Console.Write("{0} ,", colors[i]);

                        //increment count
                        count++;

                        //break out of loop
                        if (count > 50)
                        {
                            break;
                        }
                    }//end for
                }

                //if key press is n then exit and break out of the while loop
                if (info.KeyChar == n)
                {
                    Console.WriteLine("\nGoodbye! :) ");
                    break;
                }//end if

            }//end while
        } //end function

    }//end class
}//end namespace
