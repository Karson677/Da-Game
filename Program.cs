using System.Diagnostics;

internal class NewBaseType
{
    private static void Main(string[] args)
    {
        Console.Title = "TESTING";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WindowHeight = 60;

        Console.WriteLine("Hello , Whats your name? (:  ");

        string userName = Console.ReadLine();

        Console.WriteLine("My name is AI92357 , Your name is beautiful.");
        Console.WriteLine("Whats your favorite color???");

        string userColor = Console.ReadLine();

        Console.WriteLine("Mine is KAJNFKSANFKANGK, But i like that one too.");

        Console.ReadLine();

        Console.WriteLine("on a scale of 1 - 10, How smart am i?");

        Console.ReadLine();

        Console.WriteLine("Let me be honest, I dont actually know your name or color, Im just a dumb ai lol.");

        Console.ReadLine();

        Console.WriteLine("Jk. I know your name, Its " + userName);

        Console.WriteLine("Am i right?");

        Console.ReadLine();

        Console.WriteLine("i know your favorite color too!");
        Console.WriteLine("Its " + userColor);
        Console.WriteLine("right?");

        Console.ReadLine();
        Console.WriteLine("put 1 number. (:");

        int num1;
        int num2;
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("put 1 more number. (:");

        num2 = Convert.ToInt32(Console.ReadLine());

        int result = num1 * num2;

        Console.WriteLine("i multiplied those two numbers together and they make " + result + "(: (type yes to continue)");
        Console.ReadLine();

        Console.WriteLine("I used ints to do that. im pretty smart😎");
        Console.ReadKey();
        Console.WriteLine("Heres a question, Whats 32 + 28. Its pretty easy.");

        int num = Convert.ToInt32(Console.ReadLine());
        
        switch (num) {
            case 60:
                Console.WriteLine("CORRECT!");
                break;
            default:
                Console.WriteLine("INCORRECT DODO HEAD.");
                break;
        }
        
        
        
        
        Console.ReadLine();
    }
}