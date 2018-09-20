using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.INFRA
{
    interface IConexao
    {
        IDbConnection getConexao();
        string Execute_QueryStr(string sql);
        bool Execute_Query(string sql);
        int Execute_Scalar(string sql);
        DataSet Buscar(string sql);
    }
}
