// See https://aka.ms/new-console-template for more information

class MathAssignment
{
    static void Main()
    {

        System.Console.WriteLine("Press Ctrl + C to exit\n");

        while (true)
        {

            try
            {
                System.Console.Write("Enter the first Integer: ");
                var num1String = System.Console.ReadLine();
                int num1 = Convert.ToInt32(num1String);
                System.Console.Write("Enter the second Integer: ");
                var num2String = System.Console.ReadLine();
                int num2 = Convert.ToInt32(num2String);

                System.Console.WriteLine("The two numbers you entered are: " + num1 + " and " + num2);
                System.Console.WriteLine("The sum of two numbers you entered is: " + (num1 + num2));
                System.Console.WriteLine("The difference of two numbers you entered is: " + (num1 - num2));
                System.Console.WriteLine("The product of two numbers you entered is: " + (num1 * num2));
                System.Console.WriteLine("The quotient of two numbers you entered is: " + (num1 / num2));
                System.Console.WriteLine("The remainder of two numbers you entered is: " + (num1 % num2));
                if (num1 == num2)
                {
                    System.Console.WriteLine("The two numbers are equal");
                }
                else
                {
                    System.Console.WriteLine("\nThe larger of two numbers you entered is: " + Math.Max(num1, num2));
                }

                Console.WriteLine("Press 'Enter' to continue");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                    ;
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Please try again with proper inputs!");
            }
        }
    }

}

