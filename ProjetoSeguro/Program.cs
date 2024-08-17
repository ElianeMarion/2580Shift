using ProjetoSeguro.models;
using System.Globalization;

namespace ProjetoSeguro
{
	internal class Program
	{

		static void Main(string[] args)
		{
			Veiculo veiculo = new Veiculo();
			veiculo.Franquia = 1000;

			Vida vida = new Vida();
			GerenciadorImpostos gi = new GerenciadorImpostos();
			gi.adicionar(vida);
			Console.WriteLine("Total: " + GerenciadorImpostos.Total);

			ExemploStatic exemploStatic = new ExemploStatic();
			ExemploStatic exemploStatic2 = new ExemploStatic();
			ExemploStatic exemploStatic3 = new ExemploStatic();

			Console.WriteLine("Total: " +  exemploStatic.Total);
			Console.WriteLine("TotalEstatico: " + ExemploStatic.TotalEstatico);

			Repository<Veiculo> repository= new models.Repository<Veiculo>();
			repository.Cadastrar(veiculo);

			Repository<Vida> repositoryVida = new models.Repository<Vida>();
			repositoryVida.Cadastrar(vida);

			Repository<string> repositoryTexto = new models.Repository<string>();

			//			double raiz = Math.Sqrt(16);
		}
	}
}
