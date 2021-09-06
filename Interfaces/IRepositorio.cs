using System.Collections.Generic;

namespace Projeto_Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Cadastrar(T entidade);

        void Excluir(int id);

        void Alterar(int id, T entidade);

        int ProximoId();



    }
}