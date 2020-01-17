using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_2_Csharp
{
    class Aviao : Veiculo
    {
		private string tipo, uso;

		public Aviao(string _modelo, float _qtdeCombustivel, int _velocidade, int _qtdePassageiros, string _tipo, string _uso) : base (_modelo, _qtdeCombustivel, _velocidade, _qtdePassageiros)
		{
			this.Tipo = _tipo;
			this.Uso = _uso;
		}

		public string Tipo { get => tipo; set => tipo = value; }
		public string Uso { get => uso; set => uso = value; }
	}
}
