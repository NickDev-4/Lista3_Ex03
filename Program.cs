Console.Clear();

double consumo, uso, total;

Console.WriteLine("--- Custo de Energia ---");

Console.Write("Digite o consumo do aparelho (em kWh/mês): ");
consumo = double.Parse(Console.ReadLine());

Console.Write("Digite as horas de uso por dia: ");
uso = double.Parse(Console.ReadLine());

total = consumo * uso * 0.62258;

Console.WriteLine("");

Console.WriteLine("Consumo do aparelho (em kWh/mês)...: {0}", consumo);

Console.WriteLine("Horas de uso por dia...............: {0}", uso);

Console.WriteLine("Custo da energia (em R$/kWh).......: 0,62258");

Console.WriteLine("");

Console.WriteLine("Custo estimado: {0:f2}", total);