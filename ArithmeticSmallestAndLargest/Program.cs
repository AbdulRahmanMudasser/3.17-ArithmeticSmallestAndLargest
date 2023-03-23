class ArithmeticSmallestAndLargest
{
    static void Main(string[] args)
    {
        // declaring variables
        int firstNumber;
        int secondNumber;
        int thirdNumber;

        // prompting user and taking input for firstNumber
        Console.Write("Enter First Number:  ");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking input for secondNumber
        Console.Write("Enter Second Number:  ");
        secondNumber = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking input for thirdNumber
        Console.Write("Enter Third Number:  ");
        thirdNumber = Convert.ToInt32(Console.ReadLine());

        // arithmetic operations
        int sum = firstNumber + secondNumber + thirdNumber;
        int product = firstNumber * secondNumber * thirdNumber;
        int average = (int)(sum / 3);

        Console.WriteLine();    // just for spacing purpose

        // displaying sum of three numbers
        Console.WriteLine("Sum Of Numbers:  " + sum);

        // displaying product of three numbers
        Console.WriteLine("Product Of Numbers:  " + product);

        // displaying avearge of three numbers
        Console.WriteLine("Average Of Numbers:  " + average);

        // comparing to get largest number
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine(firstNumber + " Is Greater than " + secondNumber + " And " + thirdNumber);
        }

        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine(secondNumber + " Is Greater than " + firstNumber + " And " + thirdNumber);
        }

        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine(thirdNumber + " Is Greater than " + firstNumber + " And " + secondNumber);
        }

        // comparing to get smallest number
        if (firstNumber < secondNumber && firstNumber < thirdNumber)
        {
            Console.WriteLine(firstNumber + " Is Smaller than " + secondNumber + " And " + thirdNumber);
        }

        else if (secondNumber < firstNumber && secondNumber < thirdNumber)
        {
            Console.WriteLine(secondNumber + " Is Smaller than " + firstNumber + " And " + thirdNumber);
        }

        else if (thirdNumber < firstNumber && thirdNumber < secondNumber)
        {
            Console.WriteLine(thirdNumber + " Is Smaller than " + firstNumber + " And " + secondNumber);
        }

        Console.WriteLine();    // just for spacing purpose
    }
}
