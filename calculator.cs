
Console.WriteLine("------ MENU ------");
Console.WriteLine("1 - Sum");
Console.WriteLine("2 - Subtraction");
Console.WriteLine("3 - Multiplication");
Console.WriteLine("4 - Division");
Console.WriteLine("------------------");

Console.WriteLine("Enter the number that represents your desired option:");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        Console.WriteLine("------ SUM ------");
        Console.WriteLine("Enter the first number:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int sum = n1 + n2;
        Console.WriteLine($"The result of the sum is: {sum}.");
        break;
    case 2:
        Console.WriteLine("------- SUBTRACTION ------");
        Console.WriteLine("Enter the first number:");
        int n3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int n4 = Convert.ToInt32(Console.ReadLine());
        int subtraction = n3 - n4;
        Console.WriteLine($"The result of the subtraction is: {subtraction}."); ;
        break;
    case 3:
        Console.WriteLine("------ MULTIPLICATION ------");
        Console.WriteLine("Enter the first number:");
        int n5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int n6 = Convert.ToInt32(Console.ReadLine());
        int multiplication = n5 * n6;
        Console.WriteLine($"The result of the multiplication is: {multiplication}.");
        break;
    case 4:
        Console.WriteLine("------ DIVISION ------");
        Console.WriteLine("Enter the first number:");
        double n7 = Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            Console.WriteLine("Enter the second number:");
            double n8 = Convert.ToInt32(Console.ReadLine());
            if (n8 != 0)
            {
                double division = n7 / n8;
                Console.WriteLine($"The result of the division is: {division}.");
                break;
            }
            else
            {
                Console.WriteLine("Enter a number greater than 0.");
            }
        }
        break;
}
