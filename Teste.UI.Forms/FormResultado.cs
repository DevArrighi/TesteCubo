using System;
using System.Windows.Forms;
using Teste.Common;
using Teste.Entities;

namespace Teste.UI.Forms
{
    public partial class FormResultado : Form
    {
        Corrida _corrida;
        string _cur_path;

        public FormResultado()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            ofdArquivoLog.ShowDialog();
            txtPath.Text = ofdArquivoLog.FileName;

            if (!ofdArquivoLog.FileName.Equals(string.Empty))
            {
                var linhas = LeitorLog.LerArquivo(ofdArquivoLog.FileName);
                var listaVolta = Conversao.ConverterLogParaVoltas(linhas);
                _corrida = new Corrida(listaVolta);

                gdvResultado.DataSource = null;
                gdvResultado.DataSource = _corrida.ListaExibição();

                gdvRanking.DataSource = null;
                gdvRanking.DataSource = _corrida.RankingMelhorVoltaPorPiloto();

                lblTempoChegadas.Text = _corrida.TempoChegadaPilotos();
            }
            else
                MessageBox.Show("Selecione um arquivo de log.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            gdvResultado.AutoGenerateColumns = false;
            gdvRanking.AutoGenerateColumns = false;
        }
    }
}
