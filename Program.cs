Console.Clear();

string opEscolhida;

Console.WriteLine(@"Selecione uma operação:
                    
Adição [+]
Subtração [-]
Multiplicação [*]
Divisão [/]");

Console.WriteLine();

Console.Write("Qual a operação? ");
opEscolhida = Console.ReadLine()!;

switch (opEscolhida)

{
    case "+":

    {double nr1, nr2, resultado;

    Console.WriteLine("Digite os valores: ");
    
    nr1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"1° número = {nr1}");

    nr2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"2° número = {nr2}");

    resultado = nr1 + nr2;
    Console.WriteLine($"Total = {resultado}");

    Console.ReadKey();
    break;}

    case "-":

    {double nr1, nr2, resultado;

    Console.WriteLine("Digite os valores: ");
    
    nr1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"1° número = {nr1}");

    nr2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"2° número = {nr2}");

    resultado = nr1 - nr2;
    Console.WriteLine($"Total = {resultado}");

    Console.ReadKey();
    break;}

    case "*":

    {double nr1, nr2, resultado;

    Console.WriteLine("Digite os valores: ");
    
    nr1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"1° número = {nr1}");

    nr2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"2° número = {nr2}");

    resultado = nr1 * nr2;
    Console.WriteLine($"Total = {resultado}");

    Console.ReadKey();
    break;}

    case "/":

    {double nr1, nr2, resultado;

    Console.WriteLine("Digite os valores: ");
    
    nr1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"1° número = {nr1}");

    nr2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"2° número = {nr2}");

        if (nr2 == 0)
        {
            Console.WriteLine("Não existe divisão por 0... Tente novamente...");
        }

        else
        {
            resultado = nr1 / nr2;
            Console.WriteLine($"Total = {resultado}");
        }


    Console.ReadKey();
    break;}

    default:

    Console.WriteLine("Selecione uma das teclas indicadas no menu.");
    break;
}