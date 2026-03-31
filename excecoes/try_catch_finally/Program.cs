try
{
    Console.WriteLine("Digite o Dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o Divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    var resultado = dividendo / divisor;
    
    Console.WriteLine($"O Resultado de {dividendo} / {divisor} = {resultado}");
}
catch (FormatException)
{
    Console.WriteLine("Digite um número inteiro");
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("Digite um número inteiro");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Divisor não pode ser zero");
}
catch (Exception ex)
{
    Console.WriteLine("Problema: " + ex.Message);
}
finally
{
    Console.WriteLine("Fim do Programa");
}