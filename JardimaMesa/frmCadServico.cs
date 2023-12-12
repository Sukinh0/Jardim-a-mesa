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
    public partial class frmCadServico : Form
    {
        //Variavel caminho que cria - salva os dados no arquivo de texto para consultar os dados. Esse arquivo é criado na pasta de publish do programa
        string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "servicos.txt");
        public frmCadServico()
        {
            InitializeComponent();
        }
        //Ao clicar no botão voltar retorna para a tela de menu e fecha a tela de cadastro
        private void btnServVoltar_Click(object sender, EventArgs e)
        {
            //Se clicar no botão voltar mostra a mensagem e se a resposta for sim, volta para a tela de menu
            if (MessageBox.Show("Deseja realmente sair?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Instanciando e chamando a tela de menu
                frmMenu men = new frmMenu();
                men.Show();
                //Ocultando a tela de cadastro
                this.Hide();
            }
        }
        //Ao clicar no botão cadastrar serviço se algum campo não estiver preenchido mostra a mensagem para preencher todos os campos
        private void btnServCadastrar_Click(object sender, EventArgs e)
        {
            //Se alguma das condiçoes não for atendida exibe a mensagem de erro
            if (txbExp.Text == "" || txbDesc.Text == "" || txbValor.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
            else
            {
                //Se todos os campos estiverem preenchidos escreve e salva as informações no arquivo indicado na variavel caminho com o comando StreamWriter
                StreamWriter sw = new StreamWriter(caminho, true);
                sw.WriteLine(txbExp.Text);
                sw.WriteLine(float.Parse(txbValor.Text));
                sw.WriteLine(txbDesc.Text);
                sw.WriteLine("**********************************************************************************************************");
                //Após salvar todos os dados no arquivo mostra a mensagem de reserva efetuada com sucesso
                MessageBox.Show("Experiência cadastrada com sucesso!");
                //Fecha o StreamWriter concluindo efetivamente a reserva
                sw.Close();

                //Limpa todos os campos para uma nova reserva
                txbExp.Clear();
                txbDesc.Clear();
                txbValor.Clear();
            }
        }
    }
}
