class Program
{
    static void Main(string[] args)
    {
       
        //Console.WriteLine("This is a test");
        Exercise1();
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
     

        //for (int i = 0; i < newInput.Length; i++)
        //{
        //    if (newInput[i] > newInput[i + 1])
        //    }
        
        //var isSorted = true;
        //for (int i = 0; i < newinput.Count - 1; i++)
        //{
        //    if (newinput[i] > newinput[i + 1])
        //    {
        //        isSorted = true;
        //        break;
        //    }
        //}

        //Console.WriteLine(list);
    }
}



