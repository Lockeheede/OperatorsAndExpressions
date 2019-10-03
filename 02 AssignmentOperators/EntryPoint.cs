using System;
class EntryPoint
{
    static void Main()
    {
        //Assignment operators consist of =, +=, and -=
        int firstNumber = 5; int secondNumber = 6;
        firstNumber += secondNumber; //This means firstNumber = firstNumber + secondNumber
        Console.WriteLine(firstNumber); //Instead of 5, this will equal 11

        secondNumber -= firstNumber; //This means the secondNumber = secondNumber - the new firstNumber (11), which is now -5
        //but if we use the increment operator to display it, we will get instead:
        Console.WriteLine(++secondNumber);//-4

        //There is also *=, /=. and %= operators/
        secondNumber *= firstNumber; //-44, because -4 * 11
        Console.WriteLine(secondNumber);

        int thirdNumber = 7;
        secondNumber /= thirdNumber++; //second = -6, third = 8
        Console.WriteLine(secondNumber);
        Console.WriteLine(thirdNumber);

        secondNumber = secondNumber * -1; //6
        Console.WriteLine(secondNumber);
        firstNumber %= secondNumber; //5
        Console.WriteLine(firstNumber);

        //This was after many different tries to calculate. The assignment operators can be very
        //confusing if you do not keep track of the right data. 





    }
}

