using System;
    class EntryPoint
    {
        static void Main()
        {
        //There are 6 ComparisonOperators
        // > Greater than; >= Greater than or equal to
        // < Less than; <= Less than or equal to
        // == Equal to; != Not equal to

        int firstNumber = 18;
        int secondNumber = 36;

        Console.WriteLine(firstNumber > secondNumber); //boolean result of true or false
        Console.WriteLine(secondNumber < firstNumber);

        int thirdNumber = 33;
        int fourthNumber = 33;
        Console.WriteLine(thirdNumber >= fourthNumber); //true
        Console.WriteLine(thirdNumber != fourthNumber); //false

        //Since the ComparisonOperators are true or false, you can set them to boolean datatypes
        bool isThirdNumberEqualToFourthNumber = fourthNumber == thirdNumber;
        Console.WriteLine(isThirdNumberEqualToFourthNumber); //true

        int fifthNumber = 36;
        int sixthNumber = 33;
        bool isFifthNumberLessThanOrEqualToSixthNumber = fifthNumber <= sixthNumber;
        Console.WriteLine(fifthNumber <= sixthNumber);//false
        Console.WriteLine(isFifthNumberLessThanOrEqualToSixthNumber);//false

        //Strings can be compared as well. You use the length property to do this.
        string nameOne = "tod";
        
        bool nameOneVersusnameTwo = (nameOne.Length > "Tod".Length);
        Console.WriteLine(nameOneVersusnameTwo);
        }
    }
