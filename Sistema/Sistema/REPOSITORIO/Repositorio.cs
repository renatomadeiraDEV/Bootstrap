using Sistema.INFRA;
using Sistema.Models;
using Sistema.REPOSITORIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Data;

namespace Sistema.REPOSITORIO
{
    public class Repositorio : iRepositorio<Clientes>
    {
        private Conexao con = new Conexao();

        public Repositorio()
        {

        }

        public bool Atualizar(Clientes t)
        {
            try
            {
                string sql = "UPDATE CLIENTES SET nome = @nome, cpf = @cpf, id = @id;";                
                return con.Execute_Query(sql);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Clientes> Buscar(string sql)
        {
            DataSet Ds = con.Buscar(sql);
            List<Clientes> clientes = new List<Clientes>();

            try
            {
                foreach (DataRow linha in Ds.Tables["Clientes"].Rows)
                {
                    clientes.Add(new Clientes()
                    {
                        cpf = linha["cpf"].ToString(),
                         nome = linha["nome"].ToString(),
                         id = int.Parse(linha["id"].ToString())
                    });
                }
                return clientes;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Clientes BuscarPeloId(int id)
        {
            Clientes cliente = new Clientes();
            DataSet Ds = con.Buscar("SELECT * FROM CLIENTES WHERE Id = '"+id+"';");

            foreach (DataRow linha in Ds.Tables["Clientes"].Rows)
            {
                cliente = new Clientes()
                {
                    nome = linha["nome"].ToString(),
                    id = int.Parse(linha["id"].ToString()),
                    cpf = linha["cpf"].ToString()
                };
            }
            return cliente;
        }

        public string Inserir(Clientes t)
        {
            try
            {
                string sql = "INSERT INTO CLIENTE(NOME, CPF) Values('" + t.nome +"', '" + t.cpf +"');";
                var str = con.Execute_QueryStr(sql);
                return str;
            }
            catch (Exception)
            {
                return "Catch do Inserir!";
                throw;
            }
           
        }

        public bool Remover(int id )
        {
            string sql = "delete from Clientes Where Id = '" + id + "';";

            try
            {
                return con.Execute_Query(sql);

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}