using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
	public class RegistroVendas
	{
		public double Total {  get; set; }

		public void Adicionar(Livro livro)
		{
			Console.WriteLine("Livro adicionado " + livro.Nome);
			Total = Total + livro.Valor;
		}



	}
}
