using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public class ContaCorrente : Conta
	{
		public ContaCorrente(Cliente titular) : base(titular)
		{
		}

		public ContaCorrente(int numero, double saldo, Agencia agencia, Cliente titular)
			: base(numero, saldo, agencia, titular)
		{
		}

		public ContaCorrente(double limite, int numero, double saldo, Agencia agencia, Cliente titular)
			: base(numero, saldo, agencia, titular)
		{
			Limite = limite;
		}

		public double Limite { get; set; }
		//Sobrescrita de métodos
		public override void Sacar(double valor)
		{
			if (Saldo >= valor)
			{
				Saldo -= valor; //Saldo = Saldo - valor;
			}
			else if (Saldo + Limite >= valor)
			{
				Limite = Saldo + Limite - valor;
				Saldo = 0;
			}
			else
			{
				Console.WriteLine("Saldo insuficiente para saque");
			}

		}

		public override void ExibirExtrato()
		{
			base.ExibirExtrato();
			Console.WriteLine("Limite: " + Limite);
			gerente = "José dos Santos";
			Console.WriteLine("Seu gerente é " + gerente);
		}
		//Sobrecarga nesta classe
		public string Sacar(double valor, string tipoCliente)
		{
			if (tipoCliente.Equals("Especial"))
			{
				Limite = Saldo + Limite - valor;
				Saldo = 0;
			}
			return "Saldo" + Saldo;
		}

		
	}
}
