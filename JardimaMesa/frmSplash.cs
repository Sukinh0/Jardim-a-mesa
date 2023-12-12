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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void pgbSplash_Click(object sender, EventArgs e)
        {

        }

        private void imgSplashLogo_Click(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            //se o progressbar for menor que 100 incrementar o timer em 2
            if (pgbSplash.Value < 100)
            {
                pgbSplash.Value = pgbSplash.Value +2;
            }
            else
            {
                //se o progressbar for maior que 100 desativa o timer e chama a tela de login
                tmrSplash.Enabled = false;
                this.Visible = false;

                //instanciando e chamando a tela de login e ocultando a tela de carregamento
                frmLogin log = new frmLogin();
                log.Show();
                this.Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
