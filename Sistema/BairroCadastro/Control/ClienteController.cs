using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Models;
using Sistema.REPOSITORIO;

namespace BairroCadastro.Control
{
    class ClienteController
    {
        public ClienteController()
        {

        }

        public string InserirCliente(Clientes cliente)
        {
            Repositorio r = new Repositorio();
            return r.Inserir(cliente);
            
        }

        
    }
}
