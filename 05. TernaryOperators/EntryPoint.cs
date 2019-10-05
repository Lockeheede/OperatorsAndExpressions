using System;
class EntryPoint
    {
        static void Main()
        {
        //Called ternaryoperator because there are three situations:
        // expression ? true side : false side

        //Console Title
        Console.Title = "Ternary Operator Practice";
        
        //Asks for and allows the user to enter Username
        Console.Write("Enter a username. \n" +
            "It must be 6 characters or more: ");
        string incomingTemporaryUserName = Console.ReadLine();

        ConsoleColor correctColor = ConsoleColor.Green;
        ConsoleColor incorrectColor = ConsoleColor.Gray;

            
        //Conditional of username. If 6 or more characters, it works, if not, it is default
        string userName = incomingTemporaryUserName.Length >= 6 ? incomingTemporaryUserName : "default_user";
        ConsoleColor color = incomingTemporaryUserName.Length >= 6 ? ConsoleColor.Green : ConsoleColor.Red;

        Console.ForegroundColor = color;
        Console.WriteLine("The user name is: " + userName);

            


        }
    }

