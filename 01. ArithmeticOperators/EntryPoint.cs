using System;
class EntryPoint
{
    static void Main()
    {
        Console.Title = "Arithmetic Operators";

        int firstNumber = 36;
        int secondNumber = 33;
        int thirdNumber = 777;

        int fourthNumber = 3; int fifthNumber = 7; int sixthNumber = 5; int seventhNumber = 4;

        
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
        Console.Write("" + secondNumber + " * " + thirdNumber + "\n");

        //equation2 and equation3 are the same operation
        double equation2 = (double)(((fourthNumber/fifthNumber)) + Math.Pow(sixthNumber, 2)) / (double)((fourthNumber) + (seventhNumber/fourthNumber));
        Console.Write("" + fourthNumber + "/" + fifthNumber + " + " + sixthNumber + " squared " +
            " / " + fourthNumber + " + " + seventhNumber + "/" + fourthNumber + " = " + equation2 + "\n");

        double equation3 = ((3 / 7) + Math.Pow(5, 2)) / (3 + (4 / 3));
        Console.Write(equation3 + "\n");

        // ++, and -- increase and decrease the value of an interger by 1, based on the location
        Console.WriteLine(++firstNumber);
        Console.WriteLine(firstNumber--);
        Console.WriteLine(firstNumber);

        //Modulous, the remained of division is used with the % symbol and only shows what is left of a division operation
        int remainder = thirdNumber % firstNumber;
        Console.WriteLine(remainder);

        //Using 2 with modulous gives a 1 or a 0 to show if the remainer is odd or even
        int remainder2 = 4 % 2;
        Console.WriteLine(remainder2);

        


        
    }
}

