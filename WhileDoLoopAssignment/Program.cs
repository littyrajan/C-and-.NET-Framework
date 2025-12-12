using System;

namespace WhileDoLoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // WHILE LOOP BOOLEAN COMPARISON
            // -------------------------------

            // Initialize a counter variable
            int counter = 0;

            // The while loop checks the boolean condition BEFORE executing the loop
            // The loop will continue running while counter is less than 5
            while (counter < 5)
            {
                // Display the current value of counter
                Console.WriteLine("While loop counter value: " + counter);

                // Increment counter by 1
                counter++;
            }

            // -------------------------------
            // DO-WHILE LOOP BOOLEAN COMPARISON
            // -------------------------------

            // Initialize another variable
            int number = 10;

            // The do-while loop executes the code block FIRST,
            // then checks the boolean condition afterward
            do
            {
                // Display the current value of number
                Console.WriteLine("Do-while loop number value: " + number);

                // Decrease number by 1
                number--;
            }
            // The loop continues while number is greater than 5
            while (number > 5);

            // Keeps the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
