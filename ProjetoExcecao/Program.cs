namespace ProjetoExcecao
{
	internal class Program
	{
		static void ExemploNumerosException()
		{
			//Exemplo de DivideByZeroException e FormatException
			try
			{
				Console.WriteLine("Digite um número:");
				string valor = Console.ReadLine();
				int numero = int.Parse(valor);

				int divisao = 10 / numero;
				Console.WriteLine("Resultado da divisão: " + divisao);
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("Erro: Divisão por zero não existe.");
				Console.WriteLine("Detalhes do erro: " + ex.Message);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número.");
				Console.WriteLine("Detalhes do erro: " + ex.Message);
			}
		}

		static int BuscarValorLista(List<int> lista, int indice)
		{
			if(indice < 0 || indice >= lista.Count)
			{
				throw new ArgumentOutOfRangeException("O índice está fora do limite da lista");
			}
			return lista[indice];
		}
		static void ListExceptions()
		{
			try
			{
				List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
				Console.WriteLine("Digite o índice do elemento que deseja procurar na lista: ");
				int indice = int.Parse(Console.ReadLine());
				int valor = numeros[indice];
				Console.WriteLine($"Valor no índice {indice}: {valor}");

			}
			catch(ArgumentOutOfRangeException ex) {
				Console.WriteLine("Erro: O índice está fora do limite da lista.");
				Console.WriteLine("Detalhes do erro: " + ex.Message);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número.");
				Console.WriteLine("Detalhes do erro: " + ex.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ocorreu um erro inesperado.");
				Console.WriteLine("Detalhes do erro: " + ex.Message);
			}
			finally { Console.WriteLine("Programa Finalizado"); }
		}

		static void LerArquivo()
		{
			StreamReader leitor = null;

			try
			{
				leitor = new StreamReader("arquivo.txt");
				string conteudo = leitor.ReadToEnd();
				Console.WriteLine(conteudo);
			}
			catch (FileNotFoundException ex)
			{
				Console.WriteLine("Erro: Arquivo não encontrado.");
				Console.WriteLine("Detalhes do erro: " + ex.Message);
			}
			finally
			{
				if (leitor != null)
				{
					leitor.Close();
					Console.WriteLine("Leitor de arquivos fechado.");
				}
			}
		}

		static void Main(string[] args)
		{
			try
			{
				List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
				int valor = BuscarValorLista(numeros, 2);
				Console.WriteLine($"Valor: {valor}");
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine("Erro: O índice está fora do limite da lista.");
				Console.WriteLine("Detalhes do erro: " + ex.Message);
			}

			LerArquivo();



		}
	}
}
