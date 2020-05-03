using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace RedStock
{
    public partial class telaLogin : Form
    {
        

        public telaLogin()
        {
            InitializeComponent();
           
        }

       
        private void telaLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoginSair_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja sair do Sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Close();

            }
        }
                
        private void btnLoginEntrar_Click(object sender, EventArgs e)
        {

            //Strings do Banco de Dados

            //SqlConnection con = new SqlConnection("Data Source=SQLEXPRESS;Initial Catalog=AdventureWorks2017;Integrated Security=True");
            //SqlCommand selectUser = new SqlCommand("SELECT LOGIN_NAME, LOGIN_PASSWORD FROM LOGIN_SISTEMA WHERE LOGIN_NAME='" + txtLoginUsuario.Text + "' AND LOGIN_PASSWORD='" + txtLoginSenha.Text + "'", con);

            // Condição para verificar

                         
            if (txtLoginUsuario.Text == "master" && txtLoginSenha.Text == "master")
            {
                this.Hide();
                Form f = new formPrincipalRedStock();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else
            {

                MessageBox.Show("Por favor, preencha o usuário e/ou senha.", "Aviso");
                // Return para não deixar avançar
                return;

            }


        }
                
    }
}
