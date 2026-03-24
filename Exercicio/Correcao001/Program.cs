using Correcao001;

Fabrica fabrica1 = new Fabrica("Fabrica 1", "modelo 1", "1000", "Maquina Nova", "Equipamento 1", new DateTime(2024, 12, 12);
fabrica1.AdicionarMaquina("modelo 1", "3000", "Maquina Nova", "Equipamento 2", new DateTime(2024, 12, 12));
fabrica1.AdicionarMaquina("modelo 2", "3000", "Maquina Usada", "Equipamento 3", new DateTime(2024, 12, 12));
fabrica1.ListarMaquinas();

Maquina maquina1 = new Maquina("Modelo5", "5000", "Máquina do Operador", "Equipamento 5", new DateTime(2024, 12, 12));
Operador operador1 = new Operador("Paulo", maquina1);
await operador1.OperarMaquinaAsync(fabrica1, "modelo 1");
Console.ReadKey();