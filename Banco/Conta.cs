using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public class Conta
	{
		//SuperClasse -> Generalização
		public int Numero { get; set; }
		public double Saldo { get; set; }
		public Agencia Agencia { get; set; }
		public Cliente Titular { get; set; }

		//Esse atributo pode ser acessado pela classe Conta e por todas as subclasses
		protected string gerente {  get; set; }

		//Sobrecarga de métodos
		public Conta(int numero, double saldo, Agencia agencia, Cliente titular)
		{
			Numero = numero;
			Saldo = saldo;
			Agencia = agencia;
			Titular = titular;
		}

		public Conta(Cliente titular)
		{
			Titular = titular;
		}
		//Virtual -> este método pode ser sobrescrito
		public virtual void Sacar(double valor)
		{
			if(Saldo >= valor)
			{
				Saldo -= valor; //Saldo = Saldo - valor;
			}
			
		}

		public virtual void ExibirExtrato()
		{
			Console.WriteLine("Extrato bancário");
			Console.WriteLine("Saldo atual: " +  Saldo);
		}
	}
}
