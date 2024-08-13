using FiapDonationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Model
{
	public class Roupa : Produto
	{
        public ECategoriaRoupa Categoria { get; set; }
		public ETamanhoRoupa Tamanho { get; set; }
		public string Material { get; set; }
		public EComprimentoRoupa TipoComprimento {  get; set; }

		public override string ExibirDados()
		{
			//string mensagem = base.ExibirDados();
			return $"{base.ExibirDados()}\nCategoria: {Categoria} \nTamanho: {Tamanho}";
		}

		public override void ExibirInformacoesProduto()
		{
			Console.WriteLine($"Roupa selecionada para possível troca: {Nome} - Tamanho: {Tamanho}");
		}
	}
}
