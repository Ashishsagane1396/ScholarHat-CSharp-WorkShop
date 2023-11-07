namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0, a, b;

            Console.WriteLine("**** WELCOME TO CALCULATOR ****");
             do{
                Console.WriteLine();

            Console.WriteLine("Enter Your Choice:");
            Console.WriteLine("1. Addition");

            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Two numbers :");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a}+{b}={a+b}");
                    break;
                    case 2:
                        Console.WriteLine("Enter Two numbers :");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a}-{b}={a - b}");
                        break;
                    case 3:
                        Console.WriteLine("Enter Two numbers :");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a}*{b}={a *b}");
                        break;
                    case 4:
                        Console.WriteLine("Enter Two numbers :");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a}/{b}={a / b}");
                        break;

                        case 5:
                        Console.WriteLine(" Exit !! ");
                        break;

                    default: Console.WriteLine("Enter Correct Choice!!");
                        break;

                }
                Console.WriteLine("****************");
             }while(choice!=5);        }
        }
    }