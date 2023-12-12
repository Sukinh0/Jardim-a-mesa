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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Se as informações de login forem preenchidas corretamente chama a tela de menu
            if (txtUser.Text == "Adm" && txtSenha.Text == "123")
            {
                //Instanciando e chamando a tela de menu
                frmMenu men = new frmMenu();
                men.Show();
                this.Hide();
                //Mostra a mensagem seja bem vindo ao sistema
                MessageBox.Show("Olá, seja bem vindo ao sistema Jardim Á Mesa!");
            }
            //Se algum dos campos estiver vazio mostra a mensagem de erro
            else if (txtUser.Text == "" || txtSenha.Text == "" )
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
            //Se as informações de login estiverem incorretas mostra a mensagem de erro
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos, tente novamente!");
                txtSenha.Clear();
                txtUser.Clear();
            }
        }
    }
}
