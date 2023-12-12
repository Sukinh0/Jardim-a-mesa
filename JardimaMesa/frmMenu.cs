using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JardimaMesa
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void btnMCadCli_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de cadastro de clientes
            frmCadCliente CadCli = new frmCadCliente();
            CadCli.Show();
            this.Hide();
        }

        private void btnMCadRes_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de reservas
            frmReseva CadRes = new frmReseva();
            CadRes.Show();
            this.Hide();
        }

        private void btnMCadServ_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de adição de serviços (experiências)
            frmCadServico CadServ = new frmCadServico();
            CadServ.Show();
            this.Hide();
        }

        private void btnMConsCli_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de consulta de clientes
            frmConsCliente ConsCli = new frmConsCliente();
            ConsCli.Show();
            this.Hide();
        }

        private void btnMConsRes_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de consulta de reservas
            frmConsReserva ConsRes = new frmConsReserva();
            ConsRes.Show();
            this.Hide();
        }

        private void btnMConsServ_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de consulta de serviços
            frmConsServico ConsServ = new frmConsServico();
            ConsServ.Show();
            this.Hide();
        }

        private void cADASTRARCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de cadastro de clientes pelo menuStrip
            frmCadCliente CadCli = new frmCadCliente();
            CadCli.Show();
            this.Hide();
        }

        private void cONSULTARCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de consulta de clientes pelo menuStrip
            frmConsCliente ConsCli = new frmConsCliente();
            ConsCli.Show();
            this.Hide();
        }

        private void fAZERRESERVASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de reservas pelo menuStrip
            frmReseva CadRes = new frmReseva();
            CadRes.Show();
            this.Hide();
        }

        private void cONSULTARRESERVASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de consulta de reservas pelo menuStrip
            frmConsReserva ConsRes = new frmConsReserva();
            ConsRes.Show();
            this.Hide();
        }

        private void cADASTRARSERVIÇOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de adicionar serviços (experiências) pelo menuStrip
            frmCadServico CadServ = new frmCadServico();
            CadServ.Show();
            this.Hide();
        }

        private void cONSULTARSERVIÇOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando e Chamando a tela de consultar serviços (experiências) pelo menuStrip
            frmConsServico ConsServ = new frmConsServico();
            ConsServ.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente encerrar essa aplicação?","Mensagem",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
