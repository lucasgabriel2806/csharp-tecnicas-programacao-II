using System;

public delegate void AlarmeTemperaturaHandler(double temperatura);

class ArCondicionado
{
    public double Temperatura { get; private set; }
    public double LimiteSuperior { get; set; }
    public double LimiteInferior { get; set; }

    public event AlarmeTemperaturaHandler AlarmeTemperatura;

    public void AjustarTemperatura(double novaTemp)
    {
        Temperatura = novaTemp;
        Console.WriteLine($"Temperatura ajustada para: {Temperatura}");

        if (Temperatura > LimiteSuperior || Temperatura < LimiteInferior)
        {
            AlarmeTemperatura?.Invoke(Temperatura);
        }
    }
}

class Monitor
{
    public void AoDispararAlarme(double temperatura)
    {
        Console.WriteLine($"⚠️ ALERTA! Temperatura fora do limite: {temperatura}");
    }
}

class Program
{
    static void Main()
    {
        ArCondicionado ar = new ArCondicionado
        {
            LimiteSuperior = 30,
            LimiteInferior = 18
        };

        Monitor monitor = new Monitor();

        ar.AlarmeTemperatura += monitor.AoDispararAlarme;

        ar.AjustarTemperatura(25);
        ar.AjustarTemperatura(35); // dispara evento
        ar.AjustarTemperatura(15); // dispara evento
    }
}