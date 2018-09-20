using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistema.INFRA
{
    public class Conexao : IConexao 
    {
        SqlConnection con;

        public Conexao()
        {
            con = new SqlConnection("Server=RENATO-CDS\\MEUSQLEXPRESS; Database=SISTEMA ; User Id=sa ; Password=123 ;");
        }

        public Conexao(string conexao)
        {
           con = new SqlConnection(conexao);
        }


        public DataSet Buscar(string sql)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter(sql, con);
           
                con.Open();
                Adapter.Fill(DS);
                con.Close();

            return DS;
        }

        public bool Execute_Query(string sql)
        {
            throw new NotImplementedException();
        }

        public string Execute_QueryStr(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "ok";
            }
            catch (Exception er)
            {
                con.Close();
                return "Erro: " + er.Message;
                throw;
            }
        }

        public int Execute_Scalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            int count;

            try
            {
                con.Open();
                count = cmd.ExecuteNonQuery();
                con.Close();
                return count;
            }
            catch (Exception)
            {
                con.Close();
                return -1;
                throw;
            }
        }

        public IDbConnection getConexao()
        {
            return con;
        }
    }
}