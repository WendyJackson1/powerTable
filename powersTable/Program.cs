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
