IAnimal animal1 = new Cachorro();
IAnimal animal2 = new Gato();

animal1.FazerSom();
animal2.FazerSom();

Cachorro cachorro = new Cachorro();
cachorro.QuantidadeDePatas();

public interface IAnimal
{
    public void FazerSom();
}

public class Cachorro : IAnimal
{
    public void FazerSom()
    {
        Console.WriteLine("Au au");
    }
    public void QuantidadeDePatas()
    {
        Console.WriteLine("O cachorro tem 4 patas");
    }
}
public class Gato : IAnimal
{
    public void FazerSom()
    {
        Console.WriteLine("Miau");
    }
}