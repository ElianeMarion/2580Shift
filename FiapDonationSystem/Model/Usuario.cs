using FiapDonationSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Model
{
	public class Usuario : IAutenticavel
	{
		public string Nome { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string Apelido { get; set; }

		public bool Autenticar(string username, string password)
		{

			if (username == "")
			{
				throw new ArgumentNullException("Favor informar o usuário");
			}
			else
			{
				//verificar se o usuário existe
				Console.WriteLine("Existe");
				return true;
			}
			
		}
	}
}
