using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_2_Csharp
{
	class Veiculo
	{
		// ATRIBUTOS
		private String modelo;
		private float qtdeCombustivel;
		private int velocidade, qtdePassageiros;

		// METODOS
		// METODO CONSTRUTOR

		public Veiculo (String _modelo, float _qtdeCombustivel, int _velocidade, int _qtdePassageiros)
		{
			this.Modelo = _modelo;
			this.qtdePassageiros = _qtdePassageiros;
			this.qtdeCombustivel = _qtdeCombustivel;
			this.velocidade = _velocidade;
		}

		public string Modelo { get; set; }
		public float QtdeCombustivel { get; set; }
		public int Velocidade { get; set; }
		public int QtdePassageiros { get; set; }
	}
}