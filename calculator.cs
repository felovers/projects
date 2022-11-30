
Console.WriteLine("------ MENU ------");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("------------------");

Console.WriteLine("Digite o número da opção desejada:");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 1:
        Console.WriteLine("------ SOMA ------");
        Console.WriteLine("Digite o primeiro número:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int soma = n1 + n2;
        Console.WriteLine($"O resultado da soma é {soma}.");
        break;
    case 2:
        Console.WriteLine("------- SUBTRAÇÃO ------");
        Console.WriteLine("Digite o primeiro número:");
        int n3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int n4 = Convert.ToInt32(Console.ReadLine());
        int subtração = n3 - n4;
        Console.WriteLine($"O resultado da subtração é {subtração}."); ;
        break;
    case 3:
        Console.WriteLine("------ MULTIPLICAÇÃO ------");
        Console.WriteLine("Digite o primeiro número:");
        int n5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int n6 = Convert.ToInt32(Console.ReadLine());
        int multiplicação = n5 * n6;
        Console.WriteLine($"O resultado da multiplicação é {multiplicação}.");
        break;
    case 4:
        Console.WriteLine("------ DIVISÃO ------");
        Console.WriteLine("Digite o primeiro número:");
        double n7 = Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            Console.WriteLine("Digite o segundo número:");
            double n8 = Convert.ToInt32(Console.ReadLine());
            if (n8 != 0)
            {
                double divisão = n7 / n8;
                Console.WriteLine($"O resultado da divisão é {divisão}.");
                break;
            }
            else
            {
                Console.WriteLine("Digite um número maior que 0.");
            }
        }
        break;
}
