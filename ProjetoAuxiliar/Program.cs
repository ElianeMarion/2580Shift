namespace ProjetoAuxiliar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var data = new DateTime();
			Console.WriteLine(data);

			var dataHoje = DateTime.Now;
			Console.WriteLine(dataHoje);

			var dataAniversario = new DateTime(1978, 08, 25);
			Console.WriteLine("Seu aniversário é " + dataAniversario);
			Console.WriteLine("O dia do seu aniversário é " + dataAniversario.DayOfYear);

			Console.WriteLine(dataHoje.AddDays(20));

			var dataFormatada = string.Format("{0:dd/MM/yyyy}",dataHoje);
			Console.WriteLine(dataFormatada);

			dataFormatada = string.Format("{0:yyyy}", dataHoje);
			Console.WriteLine( dataFormatada);



		}
	}
}
