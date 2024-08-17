using ProjetoSeguro.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeguro.models
{
	internal class Residencia : Seguro, ITributavel
	{
		public double calculaImposto()
		{
			return 100;
		}
	}
}
