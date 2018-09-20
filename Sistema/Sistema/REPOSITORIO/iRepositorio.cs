using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.REPOSITORIO
{
    interface iRepositorio<T> where T : class
    {
        string Inserir(T t);
        bool Remover(int id);
        bool Atualizar(T t);
        List<T> Buscar(string sql);
        T BuscarPeloId(int id);
    }

}
