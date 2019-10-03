using System;
class EntryPoint
{
    static void Main()
    {
        Console.Title = "Arithmetic Operators";

        int firstNumber = 36;
        int secondNumber = 33;
        int thirdNumber = 777;
        
        int addition = firstNumber + secondNumber;
        int subtraction = secondNumber - firstNumber;
        int multiplication = firstNumber * secondNumber;
        double division = (double)secondNumber / (double)firstNumber;
        //Make sure to typecast, because dividing by ints does not give decimal results
        //It will say the type casting is redundant, but it is needed in order to get the proper information, which is a decimal point number
        Console.Write("" + firstNumber + " + " + secondNumber + " = " + addition + "\n");
        Console.Write("" + secondNumber + " - " + firstNumber + " = " + subtraction + "\n");
        Console.Write("" + firstNumber + " * " + secondNumber + " = " + multiplication + "\n");
        Console.Write("" + secondNumber + " / " + firstNumber + " = " + division + "\n");

        double equation = (double)firstNumber * ((double)secondNumber - (double)thirdNumber);
        int multiplication2 = secondNumber * thirdNumber;
        Console.Write("" + firstNumber + " times the difference of " + thirdNumber + " and " + secondNumber + " = " + equation + "\n");
        Console.Write("" + secondNumber + " * " + thirdNumber);
    }
}

