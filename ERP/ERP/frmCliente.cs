using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            // var Pessoa = new Pessoa();
            // new frmPessoa() { Nome=txtNome.Text,lblCPF=mskCPF.Text,lblTelefone=mskTelefone.text,txtEmail.Text}.sa

            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.CPF = mskCPF.Text;
            p.Email = txtEmail.Text;
            p.Telefone = mskTelefone.Text;
            p.Salvar();

            MessageBox.Show("Pessoa cadastrada com sucesso nº " + p.Id.ToString());

        }

        private void tbpListar_Click(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //Método Estático
            dtgListarPessoas.DataSource = Pessoa.Listar();

        }
    }
}
