using System.Collections.Generic;

namespace ListaFlix.Interfaces
{
    public interface IRepositorio <T>
    {
         List<T> Lista();

        T RetornaPorid(int id);
        void Insere(T entidade);

        void Excluir(int id);
        
        void Atualizar(int id, T entidade);
        
        int ProximoId();

    }
}