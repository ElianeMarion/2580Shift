using ProjetoSeguro.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeguro.models
{
	public class Vida : Seguro, ITributavel

	{
		public string TipoPlano { get; set; }

		public double calculaImposto()
		{
			return 42;
		}
	}
}
