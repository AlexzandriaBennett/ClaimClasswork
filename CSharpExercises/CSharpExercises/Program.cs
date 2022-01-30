using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        //Exercise 1 through 5 relate to strings
        //Exercise1();
        //Exercise2();
        //Exercise3();
        //Exercise4();
        //Exercise5();

        //Exercise 6-10 relate to lists and arrays
        //Exercice6();
        Exercise7();


    }

    // Write a program and ask the user to enter their name.
    // Use an array to reverse the name and then store the result in a new string. 
    // Display the reversed name on the console.
    private static void Exercise7()
    {
        Console.WriteLine("Please enter your name");
        char[] input = Console.ReadLine().ToCharArray();
        var inputReversed = input.Reverse().ToString;
        
        Console.WriteLine(inputReversed);
       
    }


    // Summary:
    // Write a program and continuously ask the user to enter different names, until the user presses Enter 
    // (without supplying a name). Depending on the number of names provided, display a message based on the pattern.

    private static void Exercice6()
    {
        var listOfNames = new List<string>();
        while (true)
        {
            Console.WriteLine("Please enter names who like your post and press enter \nwhen finished leave empty and press enter");
            var input = Console.ReadLine();
            if (input.Length <= 0)
            {
                break;
            }
            listOfNames.Add(input);
        }
       if (listOfNames.Count == 0)
        {
            Console.WriteLine("no one likes this");
        }
       else if (listOfNames.Count == 1)
        {
            Console.WriteLine(listOfNames[0] + " likes your post");
        }
       else if(listOfNames.Count == 2)
        {
            Console.WriteLine(listOfNames[0] + " and " + listOfNames[1] + " like your post");
        }
       else if( listOfNames.Count > 2)
        {
            Console.WriteLine(listOfNames[0] + ", " + listOfNames[1] + ", and " + (listOfNames.Count -2) + " others like your post");
        }




    }

    // Summary:
    // Write a program and ask the user to enter an English word. Count the number of vowels 
    // (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
    // 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
    // casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).

    private static void Exercise5()
    {
        Console.WriteLine("Please enter an English word");
        var input = Console.ReadLine().ToCharArray();
        char[] unallowableValues = { 'a', 'e', 'i', 'o', 'u', 'A','E','I','O','U'};
        var instance = 0;

        foreach (char value in unallowableValues)
        {

            foreach (char letter in input)
            {
                if (letter == value)
                {
                    instance++;
                }
            }
           
        }
        Console.WriteLine(instance + " vowels");
        
   

    }

    //Summary:
    // Write a program and ask the user to enter a few words separated by a space.
    // Use the words to create a variable name with PascalCase. 
    // For example, if the user types: "number of students", display "NumberOfStudents". 
    // Make sure that the program is not dependent on the input. 
    // So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
    private static void Exercise4()
    {
        Console.WriteLine("Please enter a few words separated by a space");
        var input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error");
            return;
        }

        var variableName = "";
        foreach (var word in input.Split(' '))
        {
            var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
            variableName += wordWithPascalCase;
        }

        Console.WriteLine(variableName);




        //var splitted = input.Split(' ');
        //foreach (var line in splitted)
        //{
        //    line.ToUpper();
        //    Console.WriteLine(line);
        //}
    }

    //Summary:
    //Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
    //A valid time should be between 00:00 and 23:59.
    //If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
    //If the user doesn't provide any values, consider it as invalid time.
    private static void Exercise3()
    {
        Console.WriteLine("Please enter a time value in the 24-hour time format (e.g. 19:00)");
        var input = Console.ReadLine();
        bool isWhiteSpace = string.IsNullOrWhiteSpace(input);
        if (isWhiteSpace == true)
        {
            Console.WriteLine("invalid input");
            Exercise3();
        }
        var date = DateTime.TryParse(input, out DateTime result);
        if (date == true)
        {
            Console.WriteLine("Ok");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        

    }




    //Summary:
    //Write a program and ask the user to enter a few numbers separated by a hyphen.
    //If the user simply presses Enter, without supplying an input, exit immediately;
    //otherwise, check to see if there are duplicates.
    //If so, display "Duplicate" on the console.
    private static void Exercise2()
    {
        Console.WriteLine("Please enter numbers seperated by a hyphen(-) symbol");
        var input = Console.ReadLine();
        var numbers = new List<int>();
        bool isWhiteSpace = string.IsNullOrWhiteSpace(input);
        if (isWhiteSpace == true)
        {
            Environment.Exit(0);
        }
        else
        {
            var splittedInput = input.Split('-');
            foreach(var item in splittedInput)
            {
                numbers.Add(int.Parse(item));
            }
            if(numbers.Count != numbers.Distinct().Count())
            {
                Console.WriteLine("duplicate");
            }
            else
            {
                Console.WriteLine("all good!");
            }
            
        }
        
    }


    // Summary: 
    // Write a program and ask the user to enter a few numbers separated by a hyphen.
    // Work out if the numbers are consecutive.
    // For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
    public static void Exercise1()
    {

        Console.WriteLine("Please enter numbers seperated by a hyphen(-) symbol");
        var input = Console.ReadLine();
        var newInput = input.Split('-');
        var numbers = new List<int>();
        foreach (var i in newInput)
        {
            numbers.Add(int.Parse(i));
        }

        numbers.Sort();
        var isConsecutive = true;

        for (var i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] != numbers[i - 1] + 1)
            {
                isConsecutive = false; 
                break;
            }
        }

        var message = isConsecutive ? "Consecutive" : "Not Consecutive";
        Console.WriteLine(message);

    }
}



