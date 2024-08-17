using ProjetoSeguro.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeguro.models
{
	public class GerenciadorImpostos
	{
		public static double Total {  get; set; }
		public void adicionar(ITributavel trib)
		{
			Total += trib.calculaImposto();
			
		}

	}
}
