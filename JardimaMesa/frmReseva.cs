using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JardimaMesa
{
    public partial class frmReseva : Form
    {
        //Variavel caminho que cria - salva os dados no arquivo de texto para consultar os dados. Esse arquivo é criado na pasta de publish do programa
        string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reservas.txt");
        public frmReseva()
        {
            InitializeComponent();
        }

        //Ao clicar no botão voltar retorna para a tela de menu e fecha a tela de cadastro
        private void btnResVoltar_Click(object sender, EventArgs e)
        {
            //Se clicar no botão voltar mostra a mensagem e se a resposta for sim, volta para a tela de menu
            if(MessageBox.Show("Deseja realmente sair?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Instanciando e chamando a tela de menu
                frmMenu men = new frmMenu();
                men.Show();
                //Ocultando a tela de cadastro
                this.Hide();
            }
        }

        private void frmReseva_Load(object sender, EventArgs e)
        {

        }
        //Ao clicar no botão fazer reserva se algum campo não estiver preenchido mostra a mensagem para preencher todos os campos
        private void btnCadReserva_Click(object sender, EventArgs e)
        {
            //Se alguma das condiçoes não for atendida exibe a mensagem de erro
            if (txbResNome.Text == "" || txbResFone.Text == "" || txbResExp.Text == "" || txbResHora.Text == "" || txbResNPessoas.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
            else
            {
                //Se todos os campos estiverem preenchidos escreve e salva as informações no arquivo indicado na variavel caminho com o comando StreamWriter
                StreamWriter sw = new StreamWriter(caminho, true);
                sw.WriteLine(txbResNome.Text);
                sw.WriteLine(txbResFone.Text);
                sw.WriteLine(txbResHora.Text);
                sw.WriteLine(int.Parse(txbResNPessoas.Text));
                sw.WriteLine(txbResExp.Text);
                sw.WriteLine("**************************************************************************************************************");
                //Após salvar todos os dados no arquivo mostra a mensagem de reserva efetuada com sucesso
                MessageBox.Show("Reserva efetuada com sucesso!");
                //Fecha o StreamWriter concluindo efetivamente a reserva
                sw.Close();

                //Limpa todos os campos para uma nova reserva
                txbResNome.Clear();
                txbResFone.Clear();
                txbResHora.Clear();
                txbResNPessoas.Clear();
                txbResExp.Clear();
            }
        }
    }
}
