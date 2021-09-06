using System;

namespace Projeto_Series
{
    public class Filme : EntidadeBase
    {

        //Atributos
        private string Nome{get; set;}
        private int Ano_Lancamento{get; set;}
        private Genero Genero{get; set;}
        private bool status{get; set;}
        private Classificacao Classificacao{get; set;}
        private Idioma Idioma{get; set;}

        private  bool Excluido{get; set;}


        //Metodos
        public Filme(int id, string nome, int ano_Lancamento, Genero genero, Classificacao classificacao, Idioma idioma)
        {

            this.Id = id;
            this.Nome= nome;
            this.Ano_Lancamento = ano_Lancamento;
            this.Genero = genero;
            this.Classificacao = classificacao;
            this.Idioma = idioma;
            this.Excluido = false;


        }

        public override string ToString()
        {
            string retorno="" + Environment.NewLine;
            retorno+="Nome: " + this.Nome + Environment.NewLine;
            retorno+="Ano Lançamento: "+ this.Ano_Lancamento + Environment.NewLine;
            retorno+="Genero: "+ this.Genero + Environment.NewLine;
            retorno+="Classificacao: "+ this.Classificacao + Environment.NewLine;
            retorno+="Idioma: " + this.Idioma + Environment.NewLine;
            retorno+="Excluido: " + this.Excluido;
            return retorno;
        }


        public int retornaId()
        {
            return this.Id;

        }

        public string retornaNome()
        {
            return this.Nome;


        }

        public bool retornaStatus()
        {

            return this.status;

        }

        public bool retornaExcluido(){

            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido= true;

        }

      

    


        
    }
}