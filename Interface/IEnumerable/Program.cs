List<string> lista = new List<string>() { "Alice", "Bruno", "Camily" };
string[] array = { "Daniel", "João" };
IEnumerable<string> Inomes = new List<string> { "Clóvis" };

ExibirNomes(lista);
ExibirNomes(array);
ExibirNomes(Inomes);

void ExibirNomes(IEnumerable<string> colecao)
{
    foreach (var nome in colecao)
    {
        Console.WriteLine(nome);
    }
}
