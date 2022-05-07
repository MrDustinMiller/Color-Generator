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
            PromptInput(colors);
        }//end main

        static void PromptInput(string[] colors)
        {
            //vars
            int userInput;
            char y = 'y';
            char n = 'n';

            //get user input on number of colors to select
            Console.Write("How many colors do you want to choose today? ");
            bool success = int.TryParse(Console.ReadLine(), out userInput);

            CreateRandomGenerator(userInput, colors);

            //ask user if they would like to generate another set of colors
            Console.WriteLine("\nGo one more time? y/n");

            //read the key press
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.KeyChar == y) //then
            {
                Console.WriteLine();
                ContinueGenerator(colors);
            }//end if

            else if (info.KeyChar == n) //then
            {
                Console.WriteLine("\nGoodbye! :) ");
            }//end else if
           
        }//end function
        
        static void CreateRandomGenerator(int userInput, string[] colors)
        {
            //create random number generator
            Random numberGen = new Random();

            GenerateColors(userInput, colors, numberGen);
        }
        static void GenerateColors(int userInput, string[] colors, Random numberGen)
        {
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
        }
        
        static void ContinueGenerator(string[] colors)
        {         
             PromptInput(colors);   
            
        }//end function

    }//end class
}//end namespace
