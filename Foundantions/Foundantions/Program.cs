namespace Foundantions;

class Program
{
    static void Main(string[] args)
    {
        var name = true;
        var consoleString = Console.ReadLine();
        
        var twoWordsVariable = int.Parse(consoleString);
        int undefinedVar;

        if (twoWordsVariable > 0)
        {
            Console.WriteLine(twoWordsVariable);
        }
        else if (twoWordsVariable > 10)
        {
            Console.WriteLine("Hello World!");
        }
        else if (twoWordsVariable == 10)
        {
            Console.WriteLine("Hello World! YESS!");
        }
        else
        {
            Console.WriteLine("ELSE");
        }

        for (var i = 0; i < twoWordsVariable ; i++) //declare variable and initialize ; condition for working ; action that we need to do wit var on each iteration
        {
            Console.WriteLine("Hello World!");
        }

        var collection = new string[] { "hello", "world", "csharp" };

        foreach (var a in collection)
        {
            Console.WriteLine(a);
        }

        var counter = 0;
        while (counter < twoWordsVariable)
        {
            Console.WriteLine("Hello World!");
            counter++;
        }
    }
}