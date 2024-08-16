using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeguro.models
{
	public class Seguro
	{
		public DateTime DataContratacao { get; set; }
		public double Valor { get; set; }

		public DateTime getValidade()
		{
			return DataContratacao.AddYears(1);
		}

	}
}
