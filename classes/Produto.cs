using System;

namespace _Métodos_Construtores_Csharp.classes
{
    public class Produto
    {
        //Atributos

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string desc;
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        private int estoque;
        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }
        
        //Métodos

        public Produto(string nome, string desc, int id, int estoque){

            this.Nome = nome;
            this.Desc = desc;
            this.Id = id;
            this.Estoque = estoque;

        }

        public string MostrarProduto(string nome, string desc, int id, int estoque  ) {

            return $"\nDados \nNome: {nome} \nDescrição: {desc} \nID: {id} \nestoque: {estoque} \n";

        }

    }
}