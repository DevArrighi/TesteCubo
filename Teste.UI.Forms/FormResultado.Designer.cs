namespace Teste.UI.Forms
{
    partial class FormResultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ofdArquivoLog = new System.Windows.Forms.OpenFileDialog();
            this.gdvResultado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gdvRanking = new System.Windows.Forms.DataGridView();
            this.lvlRanking = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicaoChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPiloto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePiloto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeVoltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoTotalProva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VelocidadeMedia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTempoChegadas = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResultado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(262, 27);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(53, 23);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Abrir";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 29);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(250, 20);
            this.txtPath.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.btnSelecionar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivo de Log";
            // 
            // gdvResultado
            // 
            this.gdvResultado.AllowUserToAddRows = false;
            this.gdvResultado.AllowUserToDeleteRows = false;
            this.gdvResultado.AllowUserToResizeRows = false;
            this.gdvResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gdvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PosicaoChegada,
            this.CodigoPiloto,
            this.NomePiloto,
            this.QuantidadeVoltas,
            this.TempoTotalProva,
            this.VelocidadeMedia});
            this.gdvResultado.Location = new System.Drawing.Point(6, 19);
            this.gdvResultado.MultiSelect = false;
            this.gdvResultado.Name = "gdvResultado";
            this.gdvResultado.ReadOnly = true;
            this.gdvResultado.Size = new System.Drawing.Size(724, 167);
            this.gdvResultado.TabIndex = 3;
            this.gdvResultado.VirtualMode = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTempoChegadas);
            this.groupBox2.Controls.Add(this.lvlRanking);
            this.groupBox2.Controls.Add(this.gdvRanking);
            this.groupBox2.Controls.Add(this.gdvResultado);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 435);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // gdvRanking
            // 
            this.gdvRanking.AllowUserToAddRows = false;
            this.gdvRanking.AllowUserToDeleteRows = false;
            this.gdvRanking.AllowUserToResizeRows = false;
            this.gdvRanking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gdvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gdvRanking.Location = new System.Drawing.Point(6, 217);
            this.gdvRanking.MultiSelect = false;
            this.gdvRanking.Name = "gdvRanking";
            this.gdvRanking.ReadOnly = true;
            this.gdvRanking.Size = new System.Drawing.Size(428, 167);
            this.gdvRanking.TabIndex = 4;
            this.gdvRanking.VirtualMode = true;
            // 
            // lvlRanking
            // 
            this.lvlRanking.AutoSize = true;
            this.lvlRanking.Location = new System.Drawing.Point(6, 197);
            this.lvlRanking.Name = "lvlRanking";
            this.lvlRanking.Size = new System.Drawing.Size(177, 13);
            this.lvlRanking.TabIndex = 5;
            this.lvlRanking.Text = "Ranking melhor volta de cada piloto";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PosicaoChegada";
            this.dataGridViewTextBoxColumn1.HeaderText = "Posição Melhor Volta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 99;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomePiloto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome Piloto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 82;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumeroVolta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Num. Volta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TempoTotalProva";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tempo Total de Prova";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // PosicaoChegada
            // 
            this.PosicaoChegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PosicaoChegada.DataPropertyName = "PosicaoChegada";
            this.PosicaoChegada.HeaderText = "Posição Chegada";
            this.PosicaoChegada.Name = "PosicaoChegada";
            this.PosicaoChegada.ReadOnly = true;
            this.PosicaoChegada.Width = 106;
            // 
            // CodigoPiloto
            // 
            this.CodigoPiloto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CodigoPiloto.DataPropertyName = "CodigoPiloto";
            this.CodigoPiloto.HeaderText = "Código Piloto";
            this.CodigoPiloto.Name = "CodigoPiloto";
            this.CodigoPiloto.ReadOnly = true;
            this.CodigoPiloto.Width = 87;
            // 
            // NomePiloto
            // 
            this.NomePiloto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NomePiloto.DataPropertyName = "NomePiloto";
            this.NomePiloto.HeaderText = "Nome Piloto";
            this.NomePiloto.Name = "NomePiloto";
            this.NomePiloto.ReadOnly = true;
            this.NomePiloto.Width = 82;
            // 
            // QuantidadeVoltas
            // 
            this.QuantidadeVoltas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QuantidadeVoltas.DataPropertyName = "QuantidadeVoltas";
            this.QuantidadeVoltas.HeaderText = "Quantidade Voltas";
            this.QuantidadeVoltas.Name = "QuantidadeVoltas";
            this.QuantidadeVoltas.ReadOnly = true;
            this.QuantidadeVoltas.Width = 109;
            // 
            // TempoTotalProva
            // 
            this.TempoTotalProva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TempoTotalProva.DataPropertyName = "TempoTotalProva";
            this.TempoTotalProva.HeaderText = "Tempo Total de Prova";
            this.TempoTotalProva.Name = "TempoTotalProva";
            this.TempoTotalProva.ReadOnly = true;
            this.TempoTotalProva.Width = 101;
            // 
            // VelocidadeMedia
            // 
            this.VelocidadeMedia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VelocidadeMedia.DataPropertyName = "VelocidadeMedia";
            this.VelocidadeMedia.HeaderText = "Velocidade Média";
            this.VelocidadeMedia.Name = "VelocidadeMedia";
            this.VelocidadeMedia.ReadOnly = true;
            // 
            // lblTempoChegadas
            // 
            this.lblTempoChegadas.AutoSize = true;
            this.lblTempoChegadas.Location = new System.Drawing.Point(440, 197);
            this.lblTempoChegadas.Name = "lblTempoChegadas";
            this.lblTempoChegadas.Size = new System.Drawing.Size(177, 13);
            this.lblTempoChegadas.TabIndex = 6;
            this.lblTempoChegadas.Text = "Ranking melhor volta de cada piloto";
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormResultado";
            this.Text = "Leitor de Log - Corrida de Kart";
            this.Load += new System.EventHandler(this.FormResultado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResultado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRanking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog ofdArquivoLog;
        private System.Windows.Forms.DataGridView gdvResultado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lvlRanking;
        private System.Windows.Forms.DataGridView gdvRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicaoChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPiloto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePiloto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeVoltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoTotalProva;
        private System.Windows.Forms.DataGridViewTextBoxColumn VelocidadeMedia;
        private System.Windows.Forms.Label lblTempoChegadas;
    }
}

