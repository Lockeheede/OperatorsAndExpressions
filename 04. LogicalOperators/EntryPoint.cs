using System;
class EntryPoint
{
    static void Main()
    {
        // && - AND Operator Only if both
        // || - OR Operator If either
        // ! - Not Operator The opposite of the other

        int number = 5;
        bool lessThan = number < 20;
        bool moreThan = number > 15;

        bool isInRange = lessThan && moreThan;

        Console.WriteLine(lessThan);
        Console.WriteLine(moreThan);
        Console.WriteLine(isInRange);


    }
}

