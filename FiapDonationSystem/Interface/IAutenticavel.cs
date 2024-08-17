using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Interface
{
	public interface IAutenticavel
	{
		public bool Autenticar(string username, string password);
	}
}
