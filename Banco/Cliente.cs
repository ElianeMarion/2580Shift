﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public class Cliente
	{
		public string Nome {  get; set; }
		public string Telefone { get; set; }
		public string Cpf {  get; set; }

		public override string ToString()
		{
			return "Nome do cliente: " + Nome + "\nCPF: " + Cpf;
		}
	}
}
