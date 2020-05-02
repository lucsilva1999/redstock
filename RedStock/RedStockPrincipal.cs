using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace RedStock
{
    public partial class formPrincipalRedStock : Form
    {
        public formPrincipalRedStock()
        {
            InitializeComponent();
        }

        private void formPrincipalRedStock_Load(object sender, EventArgs e)
        {

        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuRedStock_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja sair do Sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                //Sua rotina de exclusão
                //Confirmando exclusão para o usuário
                Close();

            }

        }

        private void verificarAtualizaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //Adicionar código para abrir o prompt e executar o .exe do instalador
            //string strCmdText;
            //strCmdText = "echo Oscar";
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);

        }
    }
}
