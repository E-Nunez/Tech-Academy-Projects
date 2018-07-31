using System;
using System.Collections.Generic;

namespace ArraysAndListstExercise
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = new string[5];
            Console.WriteLine("Type in a random word and press Enter, then type another random word. Repeat this a total of 5 times.");
            Console.WriteLine("1:");
            stringArray[0] = Console.ReadLine();
            Console.WriteLine("2:");
            stringArray[1] = Console.ReadLine();
            Console.WriteLine("3:");
            stringArray[2] = Console.ReadLine();
            Console.WriteLine("4:");
            stringArray[3] = Console.ReadLine();
            Console.WriteLine("5:");
            stringArray[4] = Console.ReadLine();
            Console.WriteLine("Press Enter to view the array list you created.");
            Console.ReadLine();

            foreach (string strings in stringArray)
            {
                Console.WriteLine(strings);
            }
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Guess a letter from the alphabet?");
            string letter = Console.ReadLine();
            bool isGuessed = letter == "E" && letter == "e";

            do
            {
                switch (letter)
                {
                    case "E":
                        Console.WriteLine("You guessed the letter E. That is Correct!");
                        isGuessed = true;
                        break;
                    case "e":
                        Console.WriteLine("You guessed the letter e. That is Correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are Wrong. \n Try again.");
                        letter = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"*COMPARISON USED TO ITERATE THE LOOP IS ""<"" OPERATOR*");
            Console.WriteLine();

            List<int> moneyTransaction = new List<int>() { 250, 500, 155, 785, 682, 592, 192, 442, 375 };
            List<int> lessThan500 = new List<int>();
            List<int> lessEqual500 = new List<int>();

            for (int i = 0; i < moneyTransaction.Count; i++)
            {
                if (moneyTransaction[i] < 500)
                {
                    Console.WriteLine("Transactions less than 500: " + moneyTransaction[i]);
                    lessThan500.Add(moneyTransaction[i]);
                }
            }
            Console.WriteLine("Count: " + lessThan500.Count);
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(@"*COMPARISON USED TO ITERATE THE LOOP IS ""<="" OPERATOR*");
            Console.WriteLine();

            foreach (int money in moneyTransaction)
            {
                if (money <= 500)
                {
                    Console.WriteLine("Transactions less than or equal to 500: " + money);
                    lessEqual500.Add(money);
                }
            }
            Console.WriteLine("Count: " + lessEqual500.Count);
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            List<string> favColor = new List<string>() { "Red", "Green", "Blue", "Black", "Orange", "Yellow", "Brown" };

            foreach (string color in favColor)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();
            Console.WriteLine("Pick a color from the List to find out its Index number: ");
            string randomColor = Console.ReadLine();

            for (int j = 0; j < favColor.Count; j++)
            {
                bool colorGuess = randomColor == favColor[j];
                again:
                do
                {
                    switch (randomColor)
                    {
                        case "Red":
                            Console.WriteLine(randomColor + ": {0}", favColor.IndexOf(favColor[0]));
                            Console.ReadLine();
                            goto Next;
                        case "Green":
                            Console.WriteLine(randomColor + ": {0}", favColor.IndexOf(favColor[1]));
                            Console.ReadLine();
                            goto Next;
                        case "Blue":
                            Console.WriteLine(randomColor + ": {0}", favColor.IndexOf(favColor[2]));
                            Console.ReadLine();
                            goto Next;
                        case "Black":
                            Console.WriteLine(randomColor + ": {0}", favColor.IndexOf(favColor[3]));
                            Console.ReadLine();
                            goto Next;
                        case "Orange":
                            Console.WriteLine(randomColor + ": {0}", favColor.IndexOf(favColor[4]));
                            Console.ReadLine();
                            goto Next;
                        case "Yellow":
                            Console.WriteLine(randomColor + ": {0}", favColor.IndexOf(favColor[5]));
                            Console.ReadLine();
                            goto Next;
                        case "Brown":
                            Console.WriteLine(randomColor + ": {0}", favColor.IndexOf(favColor[6]));
                            Console.ReadLine();
                            goto Next;
                        default:
                            Console.WriteLine("That color is not in the list. \n Try again.");
                            randomColor = Console.ReadLine();
                            break;
                    }
                }
                while (colorGuess);
            }

            Next:
            Console.WriteLine();

            List<string> letterOfWeek = new List<string>() { "S", "M", "T", "W", "T", "F", "S" };

            Console.WriteLine("Type in a Letter for the day of the Week from the List to find out its Index number: \n S, M, T, W, T, F, S");
            string randomLetter = Console.ReadLine();

            for (int a = 0; a < letterOfWeek.Count; a++)
            {
                bool letterGuess = randomLetter == letterOfWeek[a];


                do
                {
                    switch (randomLetter)
                    {
                        case "S":
                            Console.WriteLine("Sunday" + ": {0}", letterOfWeek.IndexOf(letterOfWeek[0]));
                            Console.WriteLine("Saturday" + ": {0}", letterOfWeek.LastIndexOf(letterOfWeek[6]));
                            Console.ReadLine();
                            goto Last;
                        case "M":
                            Console.WriteLine("Monday" + ": {0}", letterOfWeek.IndexOf(letterOfWeek[1]));
                            Console.ReadLine();
                            goto Last;
                        case "T":
                            Console.WriteLine("Tuesday" + ": {0}", letterOfWeek.IndexOf(letterOfWeek[2]));
                            Console.WriteLine("Thursday" + ": {0}", letterOfWeek.LastIndexOf(letterOfWeek[4]));
                            Console.ReadLine();
                            goto Last;
                        case "W":
                            Console.WriteLine("Wednesday" + ": {0}", letterOfWeek.IndexOf(letterOfWeek[3]));
                            Console.ReadLine();
                            goto Last;
                        case "F":
                            Console.WriteLine("Friday" + ": {0}", letterOfWeek.IndexOf(letterOfWeek[5]));
                            Console.ReadLine();
                            goto Last;
                        default:
                            Console.WriteLine("That Letter is not on the list. \n Try again.");
                            randomLetter = Console.ReadLine();
                            break;
                    }
                }
                while (letterGuess);


            }

            Last:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"*IDENTICAL STRINGS DISPLAY A MESSAGE IF THEY HAVE ALREADY APPEARED IN THE LIST*");

            List<string> letterOfMonth = new List<string>() { "J", "F", "M", "A", "M", "J", "J", "A", "S", "O", "N", "D" };

            foreach (string month in letterOfMonth)
            {
                Console.WriteLine("\n" + month);
                if (month == "J")
                {
                    Console.WriteLine(@"(This letter has already appeared in the list)");
                }
                if (month == "M")
                {
                    Console.WriteLine(@"(This letter has already appeared in the list)");
                }
                if (month == "A")
                {
                    Console.WriteLine(@"(This letter has already appeared in the list)");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("END");
            Console.ReadLine();


        }


    }
}
