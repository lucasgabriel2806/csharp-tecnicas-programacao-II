using System.Collections;

// Criando Arrays
ArrayList lista1 = new ArrayList();
ArrayList lista2 = new ArrayList();

// Adicionando elementos
lista1.Add("Lucas");
lista1.Add(20);
lista1.Add(1.75);
lista1.Add(true);
lista1.Add(null);

lista1.Insert(3, 65);

int[] array1 = { 1, 2, 3 };

// Adiciona uma coleção no final do ArrayList
lista1.AddRange(array1);

// Adiciona uma coleção a partir de um índice específico
lista1.InsertRange(0, array1);

foreach (var dado in lista1)
{
    Console.WriteLine(dado);
}

// Removendo elementos
lista1.Remove(20);

lista1.RemoveAt(0);

lista1.RemoveRange(2, 4);
foreach(var dado in lista1)
{
    Console.WriteLine(dado);
}

var lista3 = new ArrayList() { "Ana", "Carlos", "Maria", "a"};
lista3.Sort();
var rest1 = lista3.Contains("a");

foreach(var dado in lista3)
{
    Console.WriteLine(dado);
}

if (rest1)
{
    Console.WriteLine("Contém");
}
else
{
    Console.WriteLine("Não contém");
}

lista3.Clear();

foreach(var dado in lista3)
{
    Console.WriteLine(dado);
}