using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BairroCadastro.Control;
using Sistema.Models;

namespace BairroCadastro
{
    public partial class frmBairro : Form
    {
        public frmBairro()
        {
            InitializeComponent();
        }
                

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
           


        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.cpf = txt_CPF.Text;
            cliente.id = int.Parse(txt_Id.Text);
            cliente.nome = txt_Nome.Text;

            ClienteController controller = new ClienteController();

            MessageBox.Show(controller.InserirCliente(cliente));
        }
    }
}
