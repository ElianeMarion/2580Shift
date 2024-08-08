using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public class ContaPoupanca : Conta
	{
		public ContaPoupanca(Cliente titular) : base(titular)
		{
			gerente = "Maria da Silva";
		}

		public ContaPoupanca(int numero, double saldo, Agencia agencia, Cliente titular) : base(numero, saldo, agencia, titular)
		{
		}

		//SubClasse -> Especialização  (Filha)

		public double Rendimento {  get; set; }

		public double CalculoDeRendimentoMensal(double porcentagem)
		{
			Rendimento = Saldo * porcentagem / 100;
			return Rendimento; 
		}

	
	}
}
