using System;
using System.Windows.Forms;
using Teste.Common;
using Teste.Entities;

namespace Teste.UI.Forms
{
    public partial class FormResultado : Form
    {
        Corrida corrida;

        public FormResultado()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            ofdArquivoLog.ShowDialog();
            txtPath.Text = ofdArquivoLog.FileName;

            var linhas = LeitorLog.LerArquivo(ofdArquivoLog.FileName);
            var listaVolta = Conversao.ConverterLogParaVoltas(linhas);
            corrida = new Corrida(listaVolta);

            gdvResultado.DataSource = corrida.ListaExibição();

            gdvRanking.DataSource = corrida.RankingMelhorVoltaPorPiloto();

            lblTempoChegadas.Text = corrida.TempoChegadaPilotos();
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            gdvResultado.AutoGenerateColumns = false;
            gdvRanking.AutoGenerateColumns = false;
        }
    }
}
