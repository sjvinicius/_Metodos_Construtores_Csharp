using System;
using _Métodos_Construtores_Csharp.classes;

namespace _Métodos_Construtores_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Atribuindo Valores Por Variaveis
            Console.WriteLine("Digite o Nome do produto");
            string nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a Descrição do produto");
            string desc = Console.ReadLine().ToUpper();
            
            Console.WriteLine("Digite o ID do produto");
            int id = int.Parse( Console.ReadLine() );

            Console.WriteLine("Digite o Valor em Estoque do produto");
            int estoque = int.Parse( Console.ReadLine() );


            // Instânciando Objetos, e Atribuindo Valores Diretamente.
            Produto produto = new Produto( nome, desc, id, estoque);
            Console.WriteLine( produto.MostrarProduto(produto.Nome, produto.Desc, produto.Id, produto.Estoque) );

            Produto produto1 = new Produto("Condicionador", "Condicionador para cabelos cacheados", 24, 2424);
            Console.WriteLine( produto1.MostrarProduto(produto1.Nome, produto1.Desc, produto1.Id, produto1.Estoque) );

            Produto produto2 = new Produto("nome", "desc", 1, 1 );
            Console.WriteLine( produto2.MostrarProduto(produto2.Nome, produto2.Desc, produto2.Id, produto2.Estoque) );

        }
    }
}
