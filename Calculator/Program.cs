using System;
internal class Program
{

    public static List<double>? results = new List<double>(); // use list to store final results because i need dynamic size
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome user lets calculate : ");
        int choice;
        do {
            //print all options that user can choose from it
            showOptions();
            //this is the choice of user and convert it to int because it string by default
            choice = Convert.ToInt32(Console.ReadLine());
            //flow control
            switch (choice) {
                case 1:
                    //call add function
                    add();
                    break;
                case 2:
                    //call sub function 
                    sub();
                    break;
                case 3:
                    //call multi function 
                    malti();
                    break;
                case 4:
                    //call divided function 
                    Divided();
                    break;
                case 5:
                    //call sqrt function 
                    sqrt();
                    break;
                case 6:
                    //call number squared function 
                    NumberSquared();
                    break;
                case 7:
                    //call sin function 
                    sin();
                    break;
                case 8:
                    //call cos function 
                    cos();
                    break;
                case 9:
                    //call tan function 
                    tan();
                    break;
                case 10:
                    //print previous results
                    ShowpreviousResults();
                    break;
                case -1:
                    //print message
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
            
        }while (choice != -1);
    }
    public static void showOptions() {
        Console.WriteLine("1)Add");
        Console.WriteLine("2)Sub");
        Console.WriteLine("3)Multiplication");
        Console.WriteLine("4)Divided");
        Console.WriteLine("5)Square root");
        Console.WriteLine("6)Number squared");
        Console.WriteLine("7)Sin");
        Console.WriteLine("8)Cos");
        Console.WriteLine("9)Tan");
        Console.WriteLine("10)Show previous results");
        Console.WriteLine("-1)Exit");
    }

    public static void add() {
        dynamic? input;
        dynamic result=0; // set zero as intial value
        int container; // to store the returned value from TryParse 
        while (true) //while well breake when user press = and i use while to get multi values from user (not add just 2 nums)
        {
            input=Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("can't be null");
            }
            else if (input == "=")
            {
                Console.WriteLine(result);
                results!.Add(result); // store final result in list results to show it to user if want
                break;
            }
            else if (input == "+")
            {
                continue;
            }
            else {
                //check if can parsing
                if (int.TryParse(input, out container)==false)
                {
                    Console.WriteLine("invaild option");
                    continue;
                }
                else
                {
                    result += int.Parse(input);
                }
            }
        }
    }

    public static void sub()
    {
        dynamic? input;
        dynamic? result=null; // set null as intial value to can check if result is frist time store value
        int container; // to store the returned value from TryParse
        while (true)
        {
            input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("can't be null");
            }
            else if (input == "=")
            {
                Console.WriteLine(result);
                results!.Add(result); //store final result in list results to show it to user if want
                break;
            }
            else if (input == "-")
            {
                continue;
            }
            else
            {
                //check if can parsing
                if (int.TryParse(input, out container)==false)
                {
                    Console.WriteLine("invaild option");
                    continue;
                }
                else
                {
                    
                    if (result == null)
                    {
                        result = int.Parse(input);
                    }
                    else
                    {
                        result -= int.Parse(input);
                    }
                }
            }
        }
    }

    public static void malti() 
    {
        dynamic? input;
        dynamic result = 1; // set one as intial value because one doesn't effect on Multiplication
        int container;// to store the returned value from TryParse
        while (true)
        {
            input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("can't be null");
            }
            else if (input == "=")
            {
                Console.WriteLine(result);
                results!.Add(result);//store final result in list results to show it to user if want
                break;
            }
            else if (input == "*")
            {
                continue;
            }
            else
            {
                //check if can parsing
                if (int.TryParse(input, out container) == false)
                {
                    Console.WriteLine("invaild option");
                }
                else
                {
                    result *= int.Parse(input);
                }
            }
        }
    }

    public static void Divided()
    {
        dynamic? input;
        dynamic? result = null;// set null as intial value to can check if result is frist time store value
        int container;// to store the returned value from TryParse
        while (true)
        {
            input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("can't be null");
            }
            else if (input == "=")
            {
                Console.WriteLine(result);
                results!.Add(result);   //store final result in list results to show it to user if want
                break;
            }
            else if (input == "/")
            {
                continue;
            }
            else
            {
                //check if can parsing
                if (int.TryParse(input, out container)==false)
                {
                    Console.WriteLine("invaild option");
                }
                else
                {
                    //check is the first time to store value
                    if (result == null)
                    {
                        result = int.Parse(input);
                    }
                    else
                    {
                        try
                        {
                            result /= int.Parse(input);
                        }
                        //throw exception if the user divide by zero
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Error:" + ex);
                        }

                    }
                }
            }
        }
    }

    public static void sqrt()
    { 
        try 
        {
            double num = Convert.ToDouble(Console.ReadLine());
            double result = Math.Sqrt(num);
            Console.WriteLine(result);
            results!.Add(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        
    }
    public static void NumberSquared() 
    {
        try
        {
            double num = Convert.ToDouble(Console.ReadLine());
            double result= Math.Pow(num, 2);
            Console.WriteLine(result);
            results!.Add(result);
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex);
        }
    }

    public static void sin()
    { 
        Console.WriteLine("Enter angle");

        try 
        {
            double angle = Convert.ToDouble(Console.ReadLine());
            double result = Math.Sin(angle);
            Console.WriteLine(result);
            results!.Add(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    public static void cos()
    {
        Console.WriteLine("Enter angle");

        try 
        {
            double angle = Convert.ToDouble(Console.ReadLine());
            double result = Math.Cos(angle);
            Console.WriteLine(result);
            results!.Add(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    public static void tan()
    {
        Console.WriteLine("Enter angle");

        try
        {
            double angle = Convert.ToDouble(Console.ReadLine());
            double result= Math.Tan(angle);
            Console.WriteLine(result);
            results!.Add(result);
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex);
        }
    }
    public static void ShowpreviousResults() 
    {

        if (results is null)
        {
            Console.WriteLine("There are no previous results");
        }
        else
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Previous results : ");
            foreach (var i in results)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------------");
        }
    }
}