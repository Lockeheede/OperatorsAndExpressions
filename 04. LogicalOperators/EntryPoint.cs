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

       
        //Challenge1:
        //Check to see if a username is more than 6 characters
        //Or the first character is a capital letter
        string userName = "Bud";
       

        bool userNameConditions = userName.Length > 6 || (int)userName[0] >= 65 && (int)userName[0] <= 90;
        Console.WriteLine(userNameConditions);
        //The Length property is checking if the entirety of the username is 6
        //The ascii table between 65 and 90 represents all the capital letters
        //The only way to do that is to type cast to intergers to access the hex number. 
        //The [0] array index checks the first letter of the string



        //Challenge2:
        //Check to see if username2 is 5 to 14 characters
        //And the firsr character is lowercase
        //And doesn't contain "admin"
        string userName2 = "admin";
        bool userNameConditions2 = userName2.Length >= 5 && userName2.Length <= 14 && (int)userName2[0] >= 97 && (int)userName2[0] <= 122 && userName2 != "admin";
        Console.WriteLine(userNameConditions2);

        //Challenge3:
        //Check if same username is 6 to 14 characters and doesn't have a number in the first letter

        bool userNameConditions3 = userName2.Length >= 6 && userName2.Length <= 14;
        bool notANumber = !((int)userName2[0] >= 48 && (int)userName2[0] <= 57);
        bool userNameConditions4 = userNameConditions3 && notANumber;


        //And finally test if challenge2 or challenge3 are true
        Console.WriteLine(userNameConditions2 || userNameConditions4);



    }
}

