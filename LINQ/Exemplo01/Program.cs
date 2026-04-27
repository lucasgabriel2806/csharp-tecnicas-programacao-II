int[] numeros = { 1, 2, 3, 4, 5, 6 };

var pares = from n in numeros
            where n % 2 == 0
            select n;

foreach (var num in pares)
{
    Console.WriteLine(num);
}

// Outra sintaxe usando Lambda
Console.WriteLine("Exemplo usando Lambda\n");

var pares2 = numeros.Where(n => n % 2 == 0);

foreach (var num in pares2)
{
    Console.WriteLine(num);
}