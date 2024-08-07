using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
	public class Livro
	{
		//Padrão: CamelCase - NotaFiscal - ContaCorrente - PessoaFisica
		//Descrever a classe
		//Atributos: modificadorAcesso  tipo    nomeAtributo;
		//				+ -> public     string   nome

		//Encapsulamento é realizado utilizando o modificador de acesso private
		private string _nome;
		public string Nome {  
			get
			{
				return _nome;
			}
			set
			{ 
				if (!value.Equals("")) {
					_nome = value;
				}	
			}
		}
		public string Resumo { get; set; }
		
		private double valor;
		public double Valor { get { return valor; } set { valor = value; } }

		private int paginas;
		public int Paginas { get { return paginas; } set { paginas = value; } }
		
		public string Autor {get; set; }
		
		private string idioma;
		//Métodos de acesso
		//Get
		public string GetIdioma() { return idioma; }
		//Set
		public void SetIdioma(string idioma) {
			this.idioma = idioma;
		}

        public Editora Editora { get; set; }
        public void ExibirDados()
		{
			string titulo = "\nDETALHES DO LIVRO";
			Console.WriteLine(titulo);
			Console.WriteLine("Nome: " + _nome);
			Console.WriteLine("Resumo:" + Resumo);
			Console.WriteLine("Valor: " + Valor);
			Console.WriteLine("Páginas: " + Paginas);

			if (TemEditora())
			{
				Editora.ExibirDados();
			}
		}

		public void ExibirDados(string autor)
		{
			string titulo = "\nDETALHES DO LIVRO";
			Console.WriteLine(titulo);
			Console.WriteLine("Nome: " + _nome);
			Console.WriteLine("Autor: " + autor);
			Console.WriteLine("Resumo:" + Resumo);
			Console.WriteLine("Valor: " + Valor);
			Console.WriteLine("Páginas: " + Paginas);

			if (TemEditora())
			{
				Editora.ExibirDados();
			}
		}

		public bool TemEditora()
		{
			return Editora != null;
		}

		
		//Método Construtor
		public Livro(string nome, string resumo)
		{
			_nome = nome;
			Resumo = resumo;
		}

		public Livro(string nome)
		{
			_nome = nome;
	
		}

		public Livro(string nome, string resumo, double valor, int paginas,  string autor, string idioma, Editora editora) : this(nome)
		{
			Nome = nome;
			Resumo = resumo;
			this.valor = valor;
			Valor = valor;
			this.paginas = paginas;
			Paginas = paginas;
			Autor = autor;
			this.idioma = idioma;
			Editora = editora;
		}

	

		public Livro(string nome, Editora editora)
		{
			_nome = nome;
			Editora = editora;
		}
		public Livro() { }
        //Sobrecarga de métodos -> um método com mesmo nome porém com assinaturas diferentes
    }
}
