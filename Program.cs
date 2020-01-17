using System;

namespace Desafio_2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
			Carro c = new Carro("gol", 10f, 2, 0, "GM", 4, "2020");
			Aviao a = new Aviao("helicoptero", 300000f, 0, 2, "domestico", "passeio");

			//TESTANDO O CARRO
			Console.WriteLine("A modelo do carro é: " + c.Modelo);
			Console.WriteLine("Quantidade combustivel no carro é: " + c.QtdeCombustivel + " litros");
			Console.WriteLine("A velocidade do carro é: " + c.QtdePassageiros);
			Console.WriteLine("Quantidade de passageiros do carro é: " + c.Velocidade);
			Console.WriteLine("A marca do carro é: " + c.Marca);
			Console.WriteLine("A quantidade de portas do carro é: " + c.Portas);
			Console.WriteLine("O ano do carro é: " + c.Ano);
			Console.WriteLine();


			//TESTANDO O AVIÃO

			Console.WriteLine("A modelo do avião é: " + a.Modelo);
			Console.WriteLine("Quantidade combustivel no avião é: " + a.QtdeCombustivel + " litros");
			Console.WriteLine("Quantidade de passageiros do avião é: " + a.QtdePassageiros);
			Console.WriteLine("A velocidade do avião é: " + a.Velocidade);
			Console.WriteLine("O tipo do avião é: " + a.Tipo);
			Console.WriteLine("O uso do avião é: " + a.Uso);

		}
	}
}
