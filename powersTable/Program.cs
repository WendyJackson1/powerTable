

// Ask the user if they would like to go again, and if so loop back to the beginning.

//What will the application do?
    //The application prompts the user to enter an integer.
//The application displays a table of squares and cubes from 1 to the value entered.
    //The application prompts the user to continue.
    // Assume that the user will enter valid data.
    //The application should continue only if the user agrees to.

//Don’t mess up the difference between squares and cubes! 
//Use \t to tab to line up columns properly
//Your instructor will provide you with sample loops during class regarding how to ask the user if they would like to go again.

   //Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number.
//Research formatted strings and right-align the numbers in columns instead of left-aligning them
   //Find out the maximum number whose cube will fit in an int, and limit the user input to that number or less.....1290 is the max.2,147,483,640 had to change 7 to 0


public class Program
    {
        public static void Main()
        {
        bool continueLoop = true;
        int userNumber = 0;

      

        while (continueLoop)
        {
            while (true)
            {
                Console.WriteLine("Please enter a integer greater than 0 and less than 1291 that you would like the powers of.");
                int userInput = int.Parse(Console.ReadLine());
                userNumber = userInput;


                if (userInput >= 1 && userInput <= 1291)
                {
                    Console.WriteLine("That is a good number!");
                    int square, cube;
                    Console.WriteLine("\t" + "Number" + "\t\t" + "Square" + "\t\t" + "Cubed");
                    Console.WriteLine("\t" + "=======" + "\t\t" + "=======" + "\t\t" + "=======");
                    for (int i = 1; i <= userInput; i++)
                    {
                        square = (int)(i * i);
                        cube = (int)(i * i * i);
                        Console.WriteLine("\t\t" + i + "\t\t" + square + "\t\t" + cube);
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("You need to try again");
                }



            }
            Console.WriteLine($"You entered the number " + userNumber);


            Console.WriteLine($"Would you like to enter more numbers? Press y to do it again!");
            string userRepsonse = Console.ReadLine().ToLower();

            if (userRepsonse == "y")
            {
                Console.WriteLine("Nice!");
            }
            else
            {
                Console.WriteLine("Sorry you dont want to do it again. Have a good day!");
                continueLoop = false;
            }
        }

    }
}
