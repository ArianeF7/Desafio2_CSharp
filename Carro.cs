using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_2_Csharp
{
    class Carro : Veiculo
    {
		public Carro(string _modelo, float _qtdeCombustivel, int _velocidade, int _qtdePassageiros, string _marca, int _portas, string _ano) : base (_modelo, _qtdeCombustivel, _velocidade, _qtdePassageiros)
		{
			this.Marca = _marca;
			this.Portas = _portas;
			this.Ano = _ano;

		}

		private string marca;
		private int portas;
		private string ano;

		public string Marca { get => marca; set => marca = value; }
		public int Portas { get => portas; set => portas = value; }
		public string Ano { get => ano; set => ano = value; }
	}
}
