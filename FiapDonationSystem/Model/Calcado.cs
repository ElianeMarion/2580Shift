using FiapDonationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Model
{
	public class Calcado : Produto
	{
		public string Material { get; set; }
		public ETamanhoCalcado Tamanho {  get; set; }
		public ECategoriaCalcado Categoria {  get; set; }
		public ETipoAjuste TipoAjuste { get; set; }

		public override void ExibirInformacoesProduto()
		{
			Console.WriteLine($"Calçado selecionado para possível troca: {Nome} - Tamanho: {Tamanho}");
		}
	}
}
