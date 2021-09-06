using System.Collections.Generic;
using Projeto_Series.Interfaces;



namespace Projeto_Series
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaFilme = new List<Filme>();

        public void Alterar(int id, Filme objeto)
        {

            listaFilme[id] = objeto;

        }

        public void Cadastrar(Filme objeto)
        {

            listaFilme.Add(objeto);

        }

        public void Excluir(int id)
        {
            listaFilme[id].Excluir();

        }

        public List<Filme> Lista()
        {
            return listaFilme;

        }

        public int ProximoId()
        {
            return listaFilme.Count;

        }

        public Filme RetornaPorId(int id)
        {
            return listaFilme[id];

        }



    }
}