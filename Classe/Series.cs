using ListaFlix.Classe;
using ListaFlix.Enum;
using System;
namespace ListaFlix
{
    public class Series : EntidadeBase
    {
       private Genero Genero {get; set;} 
       private string Titulo {get;set;}
       private string Descricao {get; set;}
       private int Ano {get; set;}

       private bool Ativo { get; set; }


    public Series(int id, Genero Genero, string titulo,string descricao, int ano)
    {
            this.id = id;
            this.Genero = Genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Ativo = true;
    }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Ativo: " + this.Ativo + Environment.NewLine;
            return retorno;
        }
        public int retornaID()
        {
            return this.id;
        }
        public string retornaTitulo()
        {
        return this.Titulo;
        }
        public bool retornaAtivo()
        {
            return this.Ativo;
        }
        public void Excluir()
        {
            this.Ativo = false;
        }
    
}
}