namespace Banco
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Cliente titular = new Cliente();
			titular.Nome = "Eliane";
			Console.WriteLine(titular.ToString());
			
			ContaCorrente cc = new ContaCorrente(titular);
			Console.WriteLine("Bem vindo " + cc.Titular.Nome);
			Console.WriteLine("---CORRENTE---");
			cc.Saldo = 500;
			cc.Limite = 500;
			cc.Sacar(600);
			cc.ExibirExtrato();


			Console.WriteLine("---POUPANÇA---");
			ContaPoupanca cp = new ContaPoupanca(titular);
			cp.Saldo = 1000;
			cp.Sacar(500);
			cp.ExibirExtrato();

			//Conta conta = new Conta(titular);
			
			
		}
	}
}
