using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeguro.models
{
	public class ExemploStatic
	{

		public int Total { get; set; }
		public static int TotalEstatico { get; set; }

		public ExemploStatic() {
			Total++;
			TotalEstatico++;
		}
	}
}
