using System.Collections.Generic;
using Projeto_Series.Interfaces;

namespace Projeto_Series
{

    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Alterar(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Cadastrar(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}