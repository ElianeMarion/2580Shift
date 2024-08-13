using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Model
{
	public abstract class Produto
	{
		private int codigo;
		public int Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}
		public string Nome { get; set; }
		public string Descricao { get; set; }
        public string Genero { get; set; }
        public string Foto { get; set; }
		public bool Status { get; set;}

		public virtual string ExibirDados()
		{
			string mensagem;
			mensagem = $"Nome do produto: {Nome} \nDescrição: {Descricao} \nGenero: {Genero}";
			return mensagem;
		}

		/*
		 * Método abstrato:
		 *		- Só existe em classes abstratas
		 *		- Não tem implementação, só tem a assinatura com a palavra abstract
		 *		- OBRIGA que todos que herdem da classe abstrata implemente o método
		*/
		public abstract void ExibirInformacoesProduto();
    }
}
