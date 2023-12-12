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
    public partial class frmConsServico : Form
    {
        //Variavel caminho que cria - busca o arquivo de texto para salvar - consultar os dados. Esse arquivo é criado na pasta de publish do programa
        string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "servicos.txt");
        public frmConsServico()
        {
            InitializeComponent();
        }

        private void frmConsServico_Load(object sender, EventArgs e)
        {

        }
        //Ao clicar no botão consultar busca o arquivo de texto da variavel caminho pelo comando do StreamReader e lista todos os dados salvos
        private void btnServConsultar_Click(object sender, EventArgs e)
        {
            //Declara uma lista de string
            List<string> linhas = new List<string>();
            //Declara uma variavel linha
            string linha;

            using(StreamReader sr = new StreamReader(caminho))
            {
                //Enquanto houverem linhas preenchidas continua buscando os dados - linha diferente de null
                while((linha = sr.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
                ltbConsServico.DataSource = (linhas);
            }
        }
        //Ao clicar no botão voltar retorna para a tela de menu e fecha a tela de consulta
        private void btnConsServVoltar_Click(object sender, EventArgs e)
        {
            //Instanciando e chamando a tela de menu
            frmMenu men = new frmMenu();
            men.Show();
            //Oculta a tela de consulta
            this.Hide();
        }
    }
}
