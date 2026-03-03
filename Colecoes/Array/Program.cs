// Declaração e inicialização de arrays

int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int[] valores;
valores = new int[2] {20, 10};

string[] nomes = new string[3] { "João", "Maria", "Pedro" };

// Métodos de arrays

Array.Reverse(numeros); // Inverte a ordem dos elementos do array 'numeros'

Array.Sort(nomes); // Ordena os elementos do array 'nomes' em ordem crescente

Array.BinarySearch(nomes, "Pedro"); // Realiza uma busca binária no array 'nomes'
                                    // para encontrar o índice do elemento "Pedro"

// Exibir com foreach

foreach(var dado in nomes)
{
    Console.WriteLine(dado);
}

for (int x = 0; x < 2; x++)
{
    Console.WriteLine(valores[x]);
}

// Matriz de mais do que uma dimensão
int[,] Mat1;
Mat1 = new int[2, 3];
Mat1[0, 0] = 1;

int[,] Mat2 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

for(int lin = 0; lin < Mat2.GetLength(0); lin++)
{
    for(int col = 0; col < Mat2.GetLength(1); col++)
    {
        Console.Write(Mat2[lin, col] + " ");
    }
    Console.WriteLine();
}

foreach(var dado in Mat2)
{
    Console.WriteLine(dado);
}