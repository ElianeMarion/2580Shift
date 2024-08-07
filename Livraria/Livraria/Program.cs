// See https://aka.ms/new-console-template for more information
using Livraria;


//Instanciar um objeto do tipo Editora
Editora novaEditora = new Editora();
novaEditora.Nome = "Novatec";
novaEditora.Telefone = "1129875485";
novaEditora.Site = "www.novatec.com.br";

//Console.WriteLine("Editora: " + novaEditora.Nome);
//Instanciar um objeto -> Criar o objeto na memória
Livro meuLivro = new Livro("Harry Potter", novaEditora);
//Console.WriteLine(meuLivro.Nome);
meuLivro.Paginas = 150;
meuLivro.Valor = 100;
meuLivro.Resumo = "Harry Potter é um bruxo ...";
meuLivro.Autor = "Autor x";
//meuLivro.Nome = "Harry Potter";
meuLivro.SetIdioma("Ingles");
//meuLivro.Editora = novaEditora;
meuLivro.ExibirDados();
//Console.WriteLine(meuLivro.Nome + " foi publicado pela editora: " + meuLivro.Editora.Nome);

Livro livroUML = new Livro("UML2");
//livroUML.Nome = "UML2";
livroUML.Autor = "Gilleanes Guedes";
livroUML.Paginas = 485;
livroUML.Valor = 100;
livroUML.Resumo = "UML 2.0 uma abordagem prática";
//livroUML.Idioma = "Portugues";
livroUML.ExibirDados();


Editora erika = new Editora();
