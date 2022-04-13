public class Program
    {
        public static void Main()
        {
        bool isGettingPowers = true;
        int userNumber = 0;
        while (isGettingPowers)
        {
            bool isNotValidInterger = true;
            while (isNotValidInterger)
            {
                Console.WriteLine("Please enter a integer greater than 0 and less than 1291 that you would like the powers of.");
                int userInput = int.Parse(Console.ReadLine());
                userNumber = userInput;

                if (userInput >= 1 && userInput <= 1290)
                {
                    Console.WriteLine("That is a good number!");
                    int square, cube;
                    Console.WriteLine("\t" + "Number" + "\t\t" + "Square" + "\t\t" + "Cubed");
                    Console.WriteLine("\t" + "=======" + "\t\t" + "=======" + "\t\t" + "=======");
                    for (int i = 1; i <= userInput; i++)
                    {
                        square = i * i;
                        cube = i * i * i;
                        Console.WriteLine("\t\t" + i + "\t\t" + square + "\t\t" + cube);
                    }
                    isNotValidInterger = false;
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
                isGettingPowers = false;
            }
        }
    }
}
