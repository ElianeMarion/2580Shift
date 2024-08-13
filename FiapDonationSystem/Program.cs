using FiapDonationSystem.Enums;
using FiapDonationSystem.Model;

namespace FiapDonationSystem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Roupa roupa = new Roupa();
			roupa.Nome = "Jaqueta jeans";
			roupa.Descricao = "Jaqueta Jeans azul claro com detalhes em renda";
			roupa.Genero = "Feminino";
			roupa.Tamanho = ETamanhoRoupa.Doze;
			roupa.Categoria = ECategoriaRoupa.Blusas;
			Console.WriteLine(roupa.ExibirDados());

			Roupa produto = new Roupa();
			produto.Nome = "Camiseta colorida";
			produto.Descricao = "";
			produto.Foto = "";
			produto.Genero = "Masculino";

		}
	}
}
