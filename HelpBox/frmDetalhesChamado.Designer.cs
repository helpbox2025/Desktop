namespace HelpBox
{
    partial class frmDetalhesChamado
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
            groupBoxDetalhes = new GroupBox();
            labelSolucaoIA = new Label();
            txtSolucaoIA = new TextBox();
            txtAbrangencia = new TextBox();
            txtFrequencia = new TextBox();
            txtImpacto = new TextBox();
            labelAbrangencia = new Label();
            labelFrequencia = new Label();
            labelImpacto = new Label();
            txtInicioProb = new TextBox();
            labelProblema = new Label();
            labelCateg = new Label();
            txtCategoria = new TextBox();
            textDescricao = new TextBox();
            labelDescricao = new Label();
            txtAssunto = new TextBox();
            labelAssunto = new Label();
            groupBoxResolucao = new GroupBox();
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelPrincipal = new Panel();
            panelBotoes = new Panel();
            button1 = new Button();
            button2 = new Button();
            groupBoxDetalhes.SuspendLayout();
            groupBoxResolucao.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelPrincipal.SuspendLayout();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDetalhes
            // 
            groupBoxDetalhes.BackColor = Color.LightSteelBlue;
            groupBoxDetalhes.Controls.Add(labelSolucaoIA);
            groupBoxDetalhes.Controls.Add(txtSolucaoIA);
            groupBoxDetalhes.Controls.Add(txtAbrangencia);
            groupBoxDetalhes.Controls.Add(txtFrequencia);
            groupBoxDetalhes.Controls.Add(txtImpacto);
            groupBoxDetalhes.Controls.Add(labelAbrangencia);
            groupBoxDetalhes.Controls.Add(labelFrequencia);
            groupBoxDetalhes.Controls.Add(labelImpacto);
            groupBoxDetalhes.Controls.Add(txtInicioProb);
            groupBoxDetalhes.Controls.Add(labelProblema);
            groupBoxDetalhes.Controls.Add(labelCateg);
            groupBoxDetalhes.Controls.Add(txtCategoria);
            groupBoxDetalhes.Controls.Add(textDescricao);
            groupBoxDetalhes.Controls.Add(labelDescricao);
            groupBoxDetalhes.Controls.Add(txtAssunto);
            groupBoxDetalhes.Controls.Add(labelAssunto);
            groupBoxDetalhes.Dock = DockStyle.Top;
            groupBoxDetalhes.Location = new Point(0, 0);
            groupBoxDetalhes.Name = "groupBoxDetalhes";
            groupBoxDetalhes.Size = new Size(776, 248);
            groupBoxDetalhes.TabIndex = 0;
            groupBoxDetalhes.TabStop = false;
            groupBoxDetalhes.Text = "Detalhes do Chamado";
            // 
            // labelSolucaoIA
            // 
            labelSolucaoIA.AutoSize = true;
            labelSolucaoIA.Location = new Point(482, 123);
            labelSolucaoIA.Name = "labelSolucaoIA";
            labelSolucaoIA.Size = new Size(66, 15);
            labelSolucaoIA.TabIndex = 15;
            labelSolucaoIA.Text = "Solução IA:";
            // 
            // txtSolucaoIA
            // 
            txtSolucaoIA.BackColor = SystemColors.ButtonFace;
            txtSolucaoIA.Location = new Point(510, 147);
            txtSolucaoIA.Multiline = true;
            txtSolucaoIA.Name = "txtSolucaoIA";
            txtSolucaoIA.ReadOnly = true;
            txtSolucaoIA.ScrollBars = ScrollBars.Vertical;
            txtSolucaoIA.Size = new Size(251, 95);
            txtSolucaoIA.TabIndex = 14;
            // 
            // txtAbrangencia
            // 
            txtAbrangencia.BackColor = SystemColors.ButtonFace;
            txtAbrangencia.Location = new Point(560, 52);
            txtAbrangencia.Name = "txtAbrangencia";
            txtAbrangencia.ReadOnly = true;
            txtAbrangencia.Size = new Size(201, 23);
            txtAbrangencia.TabIndex = 13;
            // 
            // txtFrequencia
            // 
            txtFrequencia.Location = new Point(142, 202);
            txtFrequencia.Name = "txtFrequencia";
            txtFrequencia.ReadOnly = true;
            txtFrequencia.Size = new Size(268, 23);
            txtFrequencia.TabIndex = 12;
            // 
            // txtImpacto
            // 
            txtImpacto.Location = new Point(142, 173);
            txtImpacto.Name = "txtImpacto";
            txtImpacto.ReadOnly = true;
            txtImpacto.Size = new Size(268, 23);
            txtImpacto.TabIndex = 11;
            // 
            // labelAbrangencia
            // 
            labelAbrangencia.AutoSize = true;
            labelAbrangencia.Location = new Point(482, 54);
            labelAbrangencia.Name = "labelAbrangencia";
            labelAbrangencia.Size = new Size(77, 15);
            labelAbrangencia.TabIndex = 10;
            labelAbrangencia.Text = "Abrangência.";
            // 
            // labelFrequencia
            // 
            labelFrequencia.AutoSize = true;
            labelFrequencia.Location = new Point(11, 205);
            labelFrequencia.Name = "labelFrequencia";
            labelFrequencia.Size = new Size(68, 15);
            labelFrequencia.TabIndex = 9;
            labelFrequencia.Text = "Frequência.";
            // 
            // labelImpacto
            // 
            labelImpacto.AutoSize = true;
            labelImpacto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelImpacto.Location = new Point(11, 176);
            labelImpacto.Name = "labelImpacto";
            labelImpacto.Size = new Size(124, 15);
            labelImpacto.TabIndex = 8;
            labelImpacto.Text = "Impacto na Demanda.";
            // 
            // txtInicioProb
            // 
            txtInicioProb.BackColor = SystemColors.ButtonFace;
            txtInicioProb.Location = new Point(596, 84);
            txtInicioProb.Name = "txtInicioProb";
            txtInicioProb.ReadOnly = true;
            txtInicioProb.Size = new Size(165, 23);
            txtInicioProb.TabIndex = 7;
            // 
            // labelProblema
            // 
            labelProblema.AutoSize = true;
            labelProblema.Location = new Point(482, 87);
            labelProblema.Name = "labelProblema";
            labelProblema.Size = new Size(110, 15);
            labelProblema.TabIndex = 6;
            labelProblema.Text = "Início do Problema.";
            // 
            // labelCateg
            // 
            labelCateg.AutoSize = true;
            labelCateg.Location = new Point(482, 25);
            labelCateg.Name = "labelCateg";
            labelCateg.Size = new Size(61, 15);
            labelCateg.TabIndex = 5;
            labelCateg.Text = "Categoria.";
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = SystemColors.ButtonFace;
            txtCategoria.Location = new Point(560, 22);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(201, 23);
            txtCategoria.TabIndex = 4;
            // 
            // textDescricao
            // 
            textDescricao.BackColor = SystemColors.ButtonFace;
            textDescricao.Location = new Point(142, 51);
            textDescricao.Multiline = true;
            textDescricao.Name = "textDescricao";
            textDescricao.ReadOnly = true;
            textDescricao.ScrollBars = ScrollBars.Vertical;
            textDescricao.Size = new Size(329, 107);
            textDescricao.TabIndex = 3;
            textDescricao.TextChanged += textDescricao_TextChanged;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(11, 54);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(118, 15);
            labelDescricao.TabIndex = 2;
            labelDescricao.Text = "Descrição do Cliente.";
            // 
            // txtAssunto
            // 
            txtAssunto.BackColor = SystemColors.ButtonFace;
            txtAssunto.Location = new Point(142, 22);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.ReadOnly = true;
            txtAssunto.Size = new Size(329, 23);
            txtAssunto.TabIndex = 1;
            // 
            // labelAssunto
            // 
            labelAssunto.AutoSize = true;
            labelAssunto.Location = new Point(11, 25);
            labelAssunto.Name = "labelAssunto";
            labelAssunto.Size = new Size(53, 15);
            labelAssunto.TabIndex = 0;
            labelAssunto.Text = "Assunto.";
            // 
            // groupBoxResolucao
            // 
            groupBoxResolucao.Controls.Add(textBox1);
            groupBoxResolucao.Dock = DockStyle.Fill;
            groupBoxResolucao.Location = new Point(0, 248);
            groupBoxResolucao.Name = "groupBoxResolucao";
            groupBoxResolucao.Size = new Size(776, 121);
            groupBoxResolucao.TabIndex = 1;
            groupBoxResolucao.TabStop = false;
            groupBoxResolucao.Text = "Solução do Técnico";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(10, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(751, 93);
            textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightSteelBlue;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelPrincipal, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.47619F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.52381F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(groupBoxResolucao);
            panelPrincipal.Controls.Add(groupBoxDetalhes);
            panelPrincipal.Controls.Add(panelBotoes);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(12, 19);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(776, 402);
            panelPrincipal.TabIndex = 3;
            // 
            // panelBotoes
            // 
            panelBotoes.BackColor = Color.LightSteelBlue;
            panelBotoes.Controls.Add(button1);
            panelBotoes.Controls.Add(button2);
            panelBotoes.Dock = DockStyle.Bottom;
            panelBotoes.Location = new Point(0, 369);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(776, 33);
            panelBotoes.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(510, 3);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 5;
            button1.Text = "Salvar Solução";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(630, 3);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 4;
            button2.Text = "Finalizar Chamado";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmTelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chamados.";
            groupBoxDetalhes.ResumeLayout(false);
            groupBoxDetalhes.PerformLayout();
            groupBoxResolucao.ResumeLayout(false);
            groupBoxResolucao.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panelPrincipal.ResumeLayout(false);
            panelBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDetalhes;
        private TextBox txtAssunto;
        private Label labelAssunto;
        private TextBox txtInicioProb;
        private Label labelProblema;
        private Label labelCateg;
        private TextBox txtCategoria;
        private TextBox textDescricao;
        private Label labelDescricao;
        private Label labelAbrangencia;
        private Label labelFrequencia;
        private Label labelImpacto;
        private TextBox txtAbrangencia;
        private TextBox txtFrequencia;
        private TextBox txtImpacto;
        private GroupBox groupBoxResolucao;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelBotoes;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Panel panelPrincipal;
        private Label labelSolucaoIA;
        private TextBox txtSolucaoIA;
    }
}