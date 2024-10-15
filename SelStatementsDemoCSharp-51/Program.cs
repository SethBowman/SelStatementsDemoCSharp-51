namespace SelStatementsDemoCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        //if-else statements

        bool condition = true;

        if (condition == true)
        {
            Console.WriteLine("If scope");
        }
        else
        {
            Console.WriteLine("Else scope");
        }

        Console.WriteLine("Continue on..");

        int a = 200;
        int b = 200;

        if (a == b)
        {
            Console.WriteLine("If scope");
        }
        else if (a > b)
        {
            Console.WriteLine("1st else if scope");
        }
        else
        {
            Console.WriteLine("Else scope");
        }

        Console.WriteLine("Continue on..");
        
        //ternary operator (inline if statement)
        int i = -1;
        string message = i > 0 ? "Positive" : "Negative";
        Console.WriteLine(message);
        
        //switch case statement

        string today = "funday";

        switch (today.ToLower())
        {
            case "sunday":
            case "sun":
                Console.WriteLine("It is Sunday!");
                break;
            case "monday":
                Console.WriteLine("It is Monday!");
                break;
            case "tuesday":
                Console.WriteLine("It is Tuesday!");
                break;
            case "wednesday":
                Console.WriteLine("It is Wednesday!");
                break;
            case "thursday":
                Console.WriteLine("It is Thursday!");
                break;
            case "friday":
                Console.WriteLine("It is Friday!");
                break;
            case "saturday":
                Console.WriteLine("It is Saturday!");
                break;
            default:
                Console.WriteLine("That is not a day of the week.");
                break;
        }

    }
}
