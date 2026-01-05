using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TasksSet1;

internal class Program
{
    static void Main(string[] args)
    {
        // Uncomment the task you want to run:

        // Task1();
        // Task2();
        // Task3();
        // Task4();
        // Task5();
        // Task6();
        // Task7();
        // Task8();
        // Task9();
        // Task10();
        // Task11();
        // Task12();
        // Task13();
        // Task14();
         Task15();

       // Console.WriteLine("Select a task in Main and uncomment TaskN() call.");
    }

    // =========================================================
    //  SIMPLE IF TASKS (NO LOOPS) - Task1..Task5
    // =========================================================

    /// <summary>
    /// Task 1 (simple condition).
    /// Cinema ticket price.
    /// Ask the user for age.
    /// Rules:
    /// - age < 5: ticket is free
    /// - 5 <= age <= 18: child ticket (price 8)
    /// - age > 18: adult ticket (price 12)
    /// Print the final ticket price.
    /// </summary>
    public static void Task1()
    {
        Console.WriteLine("Task 1: Cinema ticket price.");

        int userAge = int.Parse(Console.ReadLine());
        if (userAge < 5)
        {
            Console.WriteLine("Ticket is free");
        }
        else if (userAge >= 5 && userAge <= 18)
        {
            Console.WriteLine("Price 8");
        }
        else
        {
            Console.WriteLine("Ticket is 12");
        }// TODO:
        // 1. Read age (int).
        // 2. Use if/else if/else to determine price.
        // 3. Print the price with a short message.
    }

    /// <summary>
    /// Task 2 (simple condition).
    /// Home thermostat suggestion.
    /// Ask the user for the current room temperature in Celsius.
    /// Rules:
    /// - temp < 18: "It's cold, turn on heating."
    /// - 18 <= temp <= 24: "Temperature is comfortable."
    /// - temp > 24: "It's warm, maybe open a window."
    /// </summary>
    public static void Task2()
    {
        Console.WriteLine("Task 2: Thermostat suggestion.");
        Console.WriteLine("Please enter the temperature:");
        int temperatureHouse = int.Parse(Console.ReadLine());
        if (temperatureHouse < 18)
        {
            Console.WriteLine("It's cold, turn on heating.");
        }
        else if (temperatureHouse >= 18 && temperatureHouse <= 24)
        {
            Console.WriteLine("Temperature is comfortable.");
        }

        else
        {
            Console.WriteLine("It's warm, maybe open a window.");
        }



        // TODO:
        // 1. Read temperature (double).
        // 2. Use if/else if/else to choose message.
        // 3. Print the message.
    }

    /// <summary>
    /// Task 3 (simple condition).
    /// Bank account overdraft check.
    /// Ask for current balance and payment amount.
    /// If payment is greater than balance, print:
    /// "Payment denied: not enough funds."
    /// Otherwise print:
    /// "Payment accepted. Remaining balance: <balance - payment>."
    /// </summary>
    public static void Task3()
    {
        Console.WriteLine("Task 3: Bank overdraft check.");
        Console.WriteLine("Please enter the current balance:");

        int currentBalance = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the amount you want to withdaw:");

        int paymentAmount = int.Parse(Console.ReadLine());

        if (currentBalance < paymentAmount)
        {
            Console.WriteLine("Payment denied: not enough funds.");
        }
        else
        {
            Console.WriteLine($"Payment accepted. Remaining balance: {currentBalance-paymentAmount}");
        }



        // TODO:
        // 1. Read balance (double).
        // 2. Read payment amount (double).
        // 3. Check if payment <= balance.
        // 4. Print appropriate message.
    }

    /// <summary>
    /// Task 4 (simple condition).
    /// Role-based greeting.
    /// Ask the user for a role: "admin", "manager", or anything else.
    /// Rules:
    /// - "admin": "Welcome, administrator!"
    /// - "manager": "Hello, manager!"
    /// - other: "Hello, user."
    /// Ignore letter case if you want (optional).
    /// </summary>
    public static void Task4()
    {
        Console.WriteLine("Task 4: Role-based greeting.");
        Console.WriteLine("Please enter the preffered role:");

        string prefferedRole = Console.ReadLine();
        if (prefferedRole == "admin")
        {
            Console.WriteLine("Welcome, administrator!");
        }
        else if(prefferedRole=="manager")
        {
            Console.WriteLine("Hello, manager!");
        }
        else 
        {
            Console.WriteLine("Hello, user!");
        }

        // TODO:
        // 1. Read role (string).
        // 2. Use if/else if/else to decide greeting.
        // 3. Print greeting.
    }

    /// <summary>
    /// Task 5 (simple condition).
    /// Exam grade description.
    /// Ask for exam score (0-100).
    /// Rules:
    /// - score < 0 or > 100: "Invalid score."
    /// - 90-100: "Grade: A"
    /// - 75-89: "Grade: B"
    /// - 60-74: "Grade: C"
    /// - 40-59: "Grade: D"
    /// - 0-39: "Grade: F"
    /// </summary>
    public static void Task5()
    {
        Console.WriteLine("Task 5: Exam grade description.");

        Console.WriteLine("Please enter the score:");
        int examScore = int.Parse(Console.ReadLine());

        if (examScore < 0 && examScore < 100)
        {
            Console.WriteLine("Invalid Score !");
        }
        else if (examScore >= 90 && examScore <= 100)
        {
            Console.WriteLine("Grade A !");
        }
        else if (examScore >= 75 && examScore <= 89)
        {
            Console.WriteLine("Grade B !");
        }
        else if (examScore >= 60 && examScore <= 74)
        {
            Console.WriteLine("Grade C !");
        }
        else if (examScore >= 40 && examScore <= 59)
        {
            Console.WriteLine("Grade D !");
        }
        else if (examScore >= 0 && examScore <= 39)
        {
            Console.WriteLine("Grade F !");
        }


        // TODO:
        // 1. Read score (int).
        // 2. Check for invalid range.
        // 3. Use if/else if/else to choose grade.
        // 4. Print result.
    }

    // =========================================================
    //  LOOP TASKS (FOR / WHILE / ARRAYS) - Task6..Task10
    // =========================================================

    /// <summary>
    /// Task 6 (loops).
    /// Total daily sales.
    /// Ask for number of days.
    /// For each day, ask for sales amount.
    /// Store values in an array, calculate:
    /// - total sales
    /// - average sales per day
    /// Print both.
    /// </summary>
    public static void Task6()
    {
        Console.WriteLine("Task 6: Total daily sales.");
        int daysNumber = int.Parse(Console.ReadLine());
        int totalSales = 0;
        for (int i = 0; i < daysNumber; i++)
        {
            int saleAmount = int.Parse(Console.ReadLine());
            totalSales=totalSales + saleAmount;
            
        }
        Console.WriteLine($"Total amount:{totalSales}");
        Console.WriteLine($"Everage:{totalSales / daysNumber}");


        // TODO:
        // 1. Read number of days (int).
        // 2. Create an array of double for sales.
        // 3. Use for loop to fill the array.
        // 4. Sum all sales.
        // 5. Calculate average.
        // 6. Print total and average.
    }

    /// <summary>
    /// Task 7 (loops).
    /// Counting even numbers.
    /// Ask the user for N.
    /// Read N integers and store them in an array.
    /// Count how many numbers are even.
    /// Print the count.
    /// </summary>
    public static void Task7()
    {
        Console.WriteLine("Task 7: Counting even numbers.");
        Console.WriteLine("Please enter the number of the list:");
         


        if (!int.TryParse(Console.ReadLine(), out int listLenth) || listLenth <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        int[] evenNumbers = new int[listLenth];

        for (int i = 0; i < listLenth; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out evenNumbers[i]))
            {
                Console.Write("Invalid input. Please enter an integer: ");
            }
        }

        for (int i = 0; i < listLenth; i++)
        {
            if (evenNumbers[i] % 2 == 0) 
            {
                Console.WriteLine(evenNumbers[i]);
            }
        }

        // TODO:
        // 1. Read N (int).
        // 2. Create array of int.
        // 3. Read N integers into the array.
        // 4. Use a loop to count how many are even (number % 2 == 0).
        // 5. Print the count.
    }
    
    /// <summary>
    /// Task 8 (loops).
    /// Multiplication table.
    /// Ask the user for a number X.
    /// Print multiplication table for X from 1 to 10.
    /// Example for X=3:
    /// 3 x 1 = 3
    /// 3 x 2 = 6
    /// ...
    /// 3 x 10 = 30
    /// </summary>
    public static void Task8()
    {
        Console.WriteLine("Task 8: Multiplication table.");
        Console.WriteLine("Please enter the number:");

        int multNumber =int.Parse(Console.ReadLine());
        int[] resultMult = new int[11];
        for (int i = 1; i < 11; i++)
        {
             
                Console.WriteLine($"{multNumber} x {i} ={multNumber*i}");
            
        }


        // TODO:
        // 1. Read X (int).
        // 2. Use a for loop from 1 to 10.
        // 3. Print "X x i = result".
    }

    /// <summary>
    /// Task 9 (loops).
    /// Monthly savings plan.
    /// Ask for:
    /// - monthly amount to save
    /// - number of months
    /// In a loop, add this amount each month and print balance after each month.
    /// At the end print the final balance.
    /// </summary>
    public static void Task9()
    {
        Console.WriteLine("Task 9: Monthly savings plan.");

        Console.WriteLine("Please enter monthly saving amount:");

        double monthlyAmount = Convert.ToDouble(Console.ReadLine());
        double balance = 0;
        Console.WriteLine("Please enter number of the months:");
        int numberMonth = int.Parse(Console.ReadLine());

        for (int month = 1; month <= numberMonth; month++)
        {
            balance += monthlyAmount;
            Console.WriteLine($"Month {month}: Balance = {balance}");
        }

           
        // TODO:
        // 1. Read monthly amount (double).
        // 2. Read number of months (int).
        // 3. Use a loop to simulate each month:
        //      - add monthly amount to balance
        //      - print current month number and balance
        // 4. After loop print final balance.
    }

    /// <summary>
    /// Task 10 (loops).
    /// Reverse a string.
    /// Ask the user for a word or sentence.
    /// Use a loop to build a reversed version of the string.
    /// Print the reversed string.
    /// (Don't use built-in Reverse methods here; do it manually with a loop.)
    /// </summary>
    public static void Task10()
    {
        Console.WriteLine("Task 10: Reverse a string.");
        string reverseWord = Console.ReadLine();

        for (int i = reverseWord.Length-1; i >= 0; i--)
        {
            Console.Write(reverseWord[i]);
 
        }

        Console.WriteLine();







        // TODO:
        // 1. Read input string.
        // 2. Create an empty result string.
        // 3. Use a for loop from the end to the beginning of the string.
        // 4. Build the reversed string.
        // 5. Print the reversed string.
    }

    // =========================================================
    //  TASKS WITH YOUR OWN METHODS + LOOPS - Task11..Task15
    // =========================================================

    /// <summary>
    /// Task 11 (methods + loops).
    /// Prime number counter.
    /// You MUST create a separate method:
    ///     static bool IsPrime(int n)
    /// which returns true if n is a prime number, false otherwise.
    ///
    /// In Task11:
    /// - Ask the user to enter positive integers one by one.
    /// - Stop when the user enters 0.
    /// - For each number, call IsPrime(n).
    /// - Count how many entered numbers are prime.
    /// - Print the count at the end.
    /// </summary>
    public static void Task11()
    {
        Console.WriteLine("Task 11: Prime number counter.");

        Console.WriteLine("Please enter the numbers:");

        List<int> numbers = new List<int>();
        int number;

        do
        {
            Console.Write("Enter a number (0 to stop): ");
            number = int.Parse(Console.ReadLine());

            if (IsPrime(number) && number!=0)
            {
                numbers.Add(number);
            }

        } while (number != 0);
        Console.WriteLine("Prime numbers are:");
        Console.WriteLine(string.Join(", ", numbers)); 
        // TODO in this method:
        // 1. Implement IsPrime(int n) method (outside Task11).
        // 2. Here, read numbers in a loop until 0 is entered.
        // 3. Use IsPrime to check each number.
        // 4. Count how many numbers are prime.
        // 5. Print the result.
    }

    /// <summary>
    /// Task 12 (methods + loops).
    /// Temperature conversion with a helper method.
    /// Create method:
    ///     static double ConvertCelsiusToFahrenheit(double celsius)
    /// which returns Fahrenheit value.
    ///
    /// In Task12:
    /// - Ask the user for how many temperature values they want to convert.
    /// - Read that many Celsius values into an array.
    /// - In a loop, call ConvertCelsiusToFahrenheit for each value.
    /// - Print both Celsius and Fahrenheit values.
    /// </summary>
    public static void Task12()
    {
        Console.WriteLine("Task 12: Temperature conversion with helper method.");
        Console.WriteLine("Please enter how many temperature values do you want to convert:");
        int celsiusNumber = int.Parse(Console.ReadLine());
        double celsiusValue;
        Console.WriteLine("Please enter the temperature values in celsius:");
        List<(double ValueCelsius, double ValueFahrenheit)> tempereture = new List<(double, double)>();
        for (int i = 0; i < celsiusNumber; i++)
        {
            celsiusValue = int.Parse(Console.ReadLine());
            tempereture.Add((celsiusValue, ConvertCelsiusToFahrenheit(celsiusValue)));
        }


      

        Console.WriteLine("Values are:");
        Console.WriteLine(string.Join(", ", tempereture));

        // TODO:
        // 1. Implement ConvertCelsiusToFahrenheit(double celsius).
        // 2. In this method, read count of values.
        // 3. Read all Celsius values into an array.
        // 4. In a loop, call ConvertCelsiusToFahrenheit for each value.
        // 5. Print results line by line.
    }

    /// <summary>
    /// Task 13 (methods + loops).
    /// Shopping cart with discount method.
    /// Create method:
    ///     static double CalculateDiscountedPrice(double price, double discountPercent)
    /// which returns price after discount.
    ///
    /// In Task13:
    /// - Ask the user for number of products.
    /// - For each product, ask for price.
    /// - Ask once for discount percent (e.g., 10 for 10%).
    /// - In a loop, call CalculateDiscountedPrice for each product.
    /// - Print original price and price after discount.
    /// - At the end, print total original sum and total discounted sum.
    /// </summary>
    public static void Task13()
    {
        Console.WriteLine("Task 13: Shopping cart with discount method.");
        Console.WriteLine("Please enter how many prices do you want to apply disscount:");
        int quantityPrice = int.Parse(Console.ReadLine());
     
        double priceValue, discountedrate;
        List<(double price, double disscountedrate)> finalprice = new List<(double, double)>();
        for (int i = 0; i < quantityPrice; i++)
        {

            Console.WriteLine("Please enter the price:");
            priceValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter disscounted rate:");
            discountedrate = double.Parse(Console.ReadLine());
            finalprice.Add((priceValue, CalculateDiscountedPrice(priceValue, discountedrate)));
        }
       
        Console.WriteLine($"{"Price:",-10}{"Disscounted:",-5}");
        Console.WriteLine(new string('-', 25));
         

        for (int i = 0; i < finalprice.Count; i++)
        {

            Console.WriteLine(finalprice[i]);
        }

      
        // TODO:
        // 1. Implement CalculateDiscountedPrice(double price, double discountPercent).
        // 2. In this method, read number of products.
        // 3. Read all prices into an array.
        // 4. Read discount percent.
        // 5. In a loop, call CalculateDiscountedPrice for each price.
        // 6. Print per-product info and totals.
    }

    /// <summary>
    /// Task 14 (methods + loops).
    /// Name normalization.
    /// Create method:
    ///     static string NormalizeName(string name)
    /// which:
    /// - trims spaces at start and end;
    /// - converts the first letter to uppercase and the rest to lowercase.
    ///
    /// In Task14:
    /// - Ask for how many names the user wants to enter.
    /// - Read all names (they may have random spaces and letter cases).
    /// - In a loop, call NormalizeName for each.
    /// - Print original and normalized versions.
    /// </summary>
    public static void Task14()
    {
        Console.WriteLine("Task 14: Name normalization.");
        Console.WriteLine("Please enter how many words do you want to normalize:");
        int quantityWord = int.Parse(Console.ReadLine());

        string stringName;

        List<(string name, string normalizedName)> nameList = new List<(string, string)>();
        for (int i = 0; i < quantityWord; i++)
        {

            Console.WriteLine("Please enter the name:");
            stringName =  Console.ReadLine();
            nameList.Add((stringName, NormalizeName(stringName)));
        }

        Console.WriteLine($"{"Name:",-10}{"Normalized name:",-5}");
        Console.WriteLine(new string('-', 25));


        for (int i = 0; i < nameList.Count; i++)
        {
            Console.WriteLine(nameList[i]);
        }


        // TODO:
        // 1. Implement NormalizeName(string name).
        // 2. In this method, read count of names.
        // 3. Read all names into an array.
        // 4. In a loop, call NormalizeName for each name.
        // 5. Print original and normalized names.
    }

    /// <summary>
    /// Task 15 (methods + loops).
    /// BMI calculator for multiple people.
    /// Create method:
    ///     static double CalculateBmi(double weightKg, double heightMeters)
    /// which returns BMI = weight / (height * height).
    ///
    /// In Task15:
    /// - Ask how many people to process.
    /// - For each person, ask for weight (kg) and height (meters).
    /// - Call CalculateBmi for each person in a loop.
    /// - Print BMI and a simple category:
    ///     BMI < 18.5 -> "Underweight"
    ///     18.5 <= BMI < 25 -> "Normal"
    ///     25 <= BMI < 30 -> "Overweight"
    ///     BMI >= 30 -> "Obese"
    /// </summary>
    public static void Task15()
    {
        Console.WriteLine("Task 15: BMI calculator for multiple people.");

        Console.WriteLine("Please enter how many people do you want to count BMI:");
        int quantityPeople = int.Parse(Console.ReadLine()); 

        double weightBMI, heightBMI;
        string name;
        string resultComent="";
        List<(string name,double bmi, string resultComment)> resultBMI = new List<(string,double, string)>();
        for (int i = 0; i < quantityPeople; i++)
        {
            Console.WriteLine("Please enter the name:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the weight:");
            weightBMI = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height:");
            heightBMI = double.Parse(Console.ReadLine());
            

            if (CalculateBmi(weightBMI, heightBMI) < 18.5)

            {
                resultComent = "Underweight"; 
            }

            if (CalculateBmi(weightBMI, heightBMI) < 25 && CalculateBmi(weightBMI, heightBMI)>=18.5)

            {
                resultComent = "Normal";
            }

            if (CalculateBmi(weightBMI, heightBMI) >= 25 && CalculateBmi(weightBMI, heightBMI) < 30)

            {
                resultComent = "Overweight";
            }

            if (CalculateBmi(weightBMI, heightBMI) >= 30)

            {
                resultComent = "Obese";
            }


            resultBMI.Add((name,CalculateBmi(weightBMI, heightBMI), resultComent));
        }

        Console.WriteLine($"{"Name:",-10}{"BMI:",-10}{"BMI Comment:",-15}");
        Console.WriteLine(new string('-', 25));


        for (int i = 0; i < resultBMI.Count; i++)
        {

            Console.WriteLine(resultBMI[i]);
        }



        // TODO:
        // 1. Implement CalculateBmi(double weightKg, double heightMeters).
        // 2. In this method, read number of people.
        // 3. For each person, read weight and height.
        // 4. Call CalculateBmi inside a loop.
        // 5. Print BMI and category for each person.
    }

    // NOTE:
    // Helper methods for Task11..Task15 (IsPrime, ConvertCelsiusToFahrenheit, etc.)
    // should be implemented here in the Program class as static methods.
    // For example:
    //

    static double CalculateBmi(double weightKg, double heightMeters)
    {
        if (weightKg <= 0)
            throw new ArgumentException("Weight must be greater than zero.", nameof(weightKg));

        if (heightMeters <= 0)
            throw new ArgumentException("Height must be greater than zero.", nameof(heightMeters));

        return weightKg / (heightMeters * heightMeters);
    }



    static string NormalizeName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return string.Empty;

        name = name.Trim().ToLowerInvariant();
        name = name.Replace(" ", "");
        return char.ToUpperInvariant(name[0]) + name.Substring(1);
    }




    static bool IsPrime(int n)
    {

        for (int i = 2; i < n; i++)
        {

            if (n % i == 0)
            {
                return false;
            }
           
        }
        return true;
        // todo: implementation by student
    }



    static double CalculateDiscountedPrice(double price, double discountPercent)

    {
        return (price-price*discountPercent/100);
    }



    static double ConvertCelsiusToFahrenheit(double celsius)

    {
        return (celsius * 9 / 5) + 32;

    }
    //
    // static double ConvertCelsiusToFahrenheit(double celsius)
    // {
    //     // TODO: implementation by student
    // }
    //
    // etc.
}