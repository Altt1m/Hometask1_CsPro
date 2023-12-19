namespace Hometask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double num1, num2;
                try
                {
                    Console.Write("Enter your first number: "); // first num
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter your second number: "); // second num
                    num2 = int.Parse(Console.ReadLine());

                    Console.Clear(); // new line
                }
                catch
                {
                    Console.Clear();
                    continue;
                }
                
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Num1 = {num1} Num2 = {num2}");
                        Console.WriteLine("\"1\" - add\n" +
                                            "\"2\" - substract\n" +
                                            "\"3\" - multiply\n" +
                                            "\"4\" - divide\n" +
                                            "or \"0\" to return.");
                        Console.Write("Choose your operation: ");
                        int response = int.Parse(Console.ReadLine());

                        if (response == 0) 
                        {
                            Console.Clear();
                            break; 
                        }
                        double res;
                        switch (response)
                        {
                            case 1:
                                res = Calculator.AddNumbers(num1, num2);
                                Console.WriteLine($"{num1} + {num2} = {res}\n");
                                
                                break;
                            case 2:
                                res = Calculator.SubNumbers(num1, num2);
                                Console.WriteLine($"{num1} - {num2} = {res}\n");
                                break;
                            case 3:
                                res = Calculator.MulNumbers(num1, num2);
                                Console.WriteLine($"{num1} * {num2} = {res}\n");
                                break;
                            case 4:
                                res =Calculator.DivNumbers(num1, num2);
                                Console.WriteLine($"{num1} / {num2} = {res}\n");
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Clear();

                        Console.WriteLine(e.Message);
                        
                        continue;
                    }
                    
                }
                

            }
            
        }
    }
}