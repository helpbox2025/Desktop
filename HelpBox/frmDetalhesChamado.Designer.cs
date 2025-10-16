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
            lblAbrangencia = new Label();
            lblFrequencia = new Label();
            lblImpacto = new Label();
            txtInicioProb = new TextBox();
            lblProblema = new Label();
            lblCateg = new Label();
            txtCategoria = new TextBox();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtAssunto = new TextBox();
            lblAssunto = new Label();
            groupBoxResolucao = new GroupBox();
            txtSolucaoTec = new TextBox();
            tlpDetalhes = new TableLayoutPanel();
            panelBotoes = new Panel();
            btnSalvar = new Button();
            btnFinalizar = new Button();
            menuStripDetalhes = new MenuStrip();
            stripUsuarioDetalhes = new ToolStripMenuItem();
            stripLogoutDetalhes = new ToolStripMenuItem();
            stripSobreDetalhes = new ToolStripMenuItem();
            stripSobreHDetalhes = new ToolStripMenuItem();
            stripManualDetalhes = new ToolStripMenuItem();
            stripMSistemaDetalhes = new ToolStripMenuItem();
            groupBoxDetalhes.SuspendLayout();
            groupBoxResolucao.SuspendLayout();
            tlpDetalhes.SuspendLayout();
            panelBotoes.SuspendLayout();
            menuStripDetalhes.SuspendLayout();
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
            groupBoxDetalhes.Controls.Add(lblAbrangencia);
            groupBoxDetalhes.Controls.Add(lblFrequencia);
            groupBoxDetalhes.Controls.Add(lblImpacto);
            groupBoxDetalhes.Controls.Add(txtInicioProb);
            groupBoxDetalhes.Controls.Add(lblProblema);
            groupBoxDetalhes.Controls.Add(lblCateg);
            groupBoxDetalhes.Controls.Add(txtCategoria);
            groupBoxDetalhes.Controls.Add(txtDescricao);
            groupBoxDetalhes.Controls.Add(lblDescricao);
            groupBoxDetalhes.Controls.Add(txtAssunto);
            groupBoxDetalhes.Controls.Add(lblAssunto);
            groupBoxDetalhes.Dock = DockStyle.Fill;
            groupBoxDetalhes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDetalhes.Location = new Point(3, 3);
            groupBoxDetalhes.Name = "groupBoxDetalhes";
            groupBoxDetalhes.Size = new Size(978, 248);
            groupBoxDetalhes.TabIndex = 0;
            groupBoxDetalhes.TabStop = false;
            groupBoxDetalhes.Text = "Detalhes do Chamado";
            // 
            // labelSolucaoIA
            // 
            labelSolucaoIA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSolucaoIA.AutoSize = true;
            labelSolucaoIA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSolucaoIA.Location = new Point(585, 132);
            labelSolucaoIA.Name = "labelSolucaoIA";
            labelSolucaoIA.Size = new Size(66, 15);
            labelSolucaoIA.TabIndex = 15;
            labelSolucaoIA.Text = "Solução IA:";
            // 
            // txtSolucaoIA
            // 
            txtSolucaoIA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSolucaoIA.BackColor = SystemColors.ControlLight;
            txtSolucaoIA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSolucaoIA.Location = new Point(668, 132);
            txtSolucaoIA.Multiline = true;
            txtSolucaoIA.Name = "txtSolucaoIA";
            txtSolucaoIA.ReadOnly = true;
            txtSolucaoIA.ScrollBars = ScrollBars.Vertical;
            txtSolucaoIA.Size = new Size(277, 102);
            txtSolucaoIA.TabIndex = 14;
            // 
            // txtAbrangencia
            // 
            txtAbrangencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAbrangencia.BackColor = SystemColors.ControlLight;
            txtAbrangencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAbrangencia.Location = new Point(668, 61);
            txtAbrangencia.Name = "txtAbrangencia";
            txtAbrangencia.ReadOnly = true;
            txtAbrangencia.Size = new Size(277, 23);
            txtAbrangencia.TabIndex = 13;
            // 
            // txtFrequencia
            // 
            txtFrequencia.BackColor = SystemColors.ControlLight;
            txtFrequencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFrequencia.Location = new Point(142, 211);
            txtFrequencia.Name = "txtFrequencia";
            txtFrequencia.ReadOnly = true;
            txtFrequencia.Size = new Size(415, 23);
            txtFrequencia.TabIndex = 12;
            // 
            // txtImpacto
            // 
            txtImpacto.BackColor = SystemColors.ControlLight;
            txtImpacto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImpacto.Location = new Point(142, 182);
            txtImpacto.Name = "txtImpacto";
            txtImpacto.ReadOnly = true;
            txtImpacto.Size = new Size(415, 23);
            txtImpacto.TabIndex = 11;
            // 
            // lblAbrangencia
            // 
            lblAbrangencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAbrangencia.AutoSize = true;
            lblAbrangencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAbrangencia.Location = new Point(585, 64);
            lblAbrangencia.Name = "lblAbrangencia";
            lblAbrangencia.Size = new Size(77, 15);
            lblAbrangencia.TabIndex = 10;
            lblAbrangencia.Text = "Abrangência.";
            // 
            // lblFrequencia
            // 
            lblFrequencia.AutoSize = true;
            lblFrequencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFrequencia.Location = new Point(11, 214);
            lblFrequencia.Name = "lblFrequencia";
            lblFrequencia.Size = new Size(68, 15);
            lblFrequencia.TabIndex = 9;
            lblFrequencia.Text = "Frequência.";
            // 
            // lblImpacto
            // 
            lblImpacto.AutoSize = true;
            lblImpacto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImpacto.Location = new Point(11, 185);
            lblImpacto.Name = "lblImpacto";
            lblImpacto.Size = new Size(124, 15);
            lblImpacto.TabIndex = 8;
            lblImpacto.Text = "Impacto na Demanda.";
            // 
            // txtInicioProb
            // 
            txtInicioProb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtInicioProb.BackColor = SystemColors.ControlLight;
            txtInicioProb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInicioProb.ForeColor = SystemColors.WindowText;
            txtInicioProb.Location = new Point(701, 93);
            txtInicioProb.Name = "txtInicioProb";
            txtInicioProb.ReadOnly = true;
            txtInicioProb.Size = new Size(244, 23);
            txtInicioProb.TabIndex = 7;
            // 
            // lblProblema
            // 
            lblProblema.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProblema.AutoSize = true;
            lblProblema.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProblema.Location = new Point(585, 96);
            lblProblema.Name = "lblProblema";
            lblProblema.Size = new Size(110, 15);
            lblProblema.TabIndex = 6;
            lblProblema.Text = "Início do Problema.";
            // 
            // lblCateg
            // 
            lblCateg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCateg.AutoSize = true;
            lblCateg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCateg.Location = new Point(585, 34);
            lblCateg.Name = "lblCateg";
            lblCateg.Size = new Size(61, 15);
            lblCateg.TabIndex = 5;
            lblCateg.Text = "Categoria.";
            // 
            // txtCategoria
            // 
            txtCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCategoria.BackColor = SystemColors.ControlLight;
            txtCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(668, 31);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(277, 23);
            txtCategoria.TabIndex = 4;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = SystemColors.ControlLight;
            txtDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(142, 60);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ReadOnly = true;
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtDescricao.Size = new Size(415, 107);
            txtDescricao.TabIndex = 3;
            txtDescricao.TextChanged += textDescricao_TextChanged;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(11, 63);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(118, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição do Cliente.";
            // 
            // txtAssunto
            // 
            txtAssunto.BackColor = SystemColors.ControlLight;
            txtAssunto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAssunto.Location = new Point(142, 31);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.ReadOnly = true;
            txtAssunto.Size = new Size(415, 23);
            txtAssunto.TabIndex = 1;
            // 
            // lblAssunto
            // 
            lblAssunto.AutoSize = true;
            lblAssunto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssunto.Location = new Point(11, 34);
            lblAssunto.Name = "lblAssunto";
            lblAssunto.Size = new Size(53, 15);
            lblAssunto.TabIndex = 0;
            lblAssunto.Text = "Assunto.";
            // 
            // groupBoxResolucao
            // 
            groupBoxResolucao.Controls.Add(txtSolucaoTec);
            groupBoxResolucao.Dock = DockStyle.Fill;
            groupBoxResolucao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxResolucao.Location = new Point(3, 257);
            groupBoxResolucao.Name = "groupBoxResolucao";
            groupBoxResolucao.Size = new Size(978, 253);
            groupBoxResolucao.TabIndex = 1;
            groupBoxResolucao.TabStop = false;
            groupBoxResolucao.Text = "Solução do Técnico";
            // 
            // txtSolucaoTec
            // 
            txtSolucaoTec.Anchor = AnchorStyles.Top;
            txtSolucaoTec.BackColor = SystemColors.ButtonHighlight;
            txtSolucaoTec.Location = new Point(104, 40);
            txtSolucaoTec.Multiline = true;
            txtSolucaoTec.Name = "txtSolucaoTec";
            txtSolucaoTec.ScrollBars = ScrollBars.Vertical;
            txtSolucaoTec.Size = new Size(761, 205);
            txtSolucaoTec.TabIndex = 1;
            // 
            // tlpDetalhes
            // 
            tlpDetalhes.BackColor = Color.LightSteelBlue;
            tlpDetalhes.ColumnCount = 1;
            tlpDetalhes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetalhes.Controls.Add(groupBoxDetalhes, 0, 0);
            tlpDetalhes.Controls.Add(groupBoxResolucao, 0, 1);
            tlpDetalhes.Controls.Add(panelBotoes, 0, 2);
            tlpDetalhes.Dock = DockStyle.Fill;
            tlpDetalhes.Location = new Point(0, 24);
            tlpDetalhes.Name = "tlpDetalhes";
            tlpDetalhes.RowCount = 4;
            tlpDetalhes.RowStyles.Add(new RowStyle());
            tlpDetalhes.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlpDetalhes.RowStyles.Add(new RowStyle());
            tlpDetalhes.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpDetalhes.Size = new Size(984, 663);
            tlpDetalhes.TabIndex = 2;
            // 
            // panelBotoes
            // 
            panelBotoes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelBotoes.BackColor = Color.LightSteelBlue;
            panelBotoes.Controls.Add(btnSalvar);
            panelBotoes.Controls.Add(btnFinalizar);
            panelBotoes.Location = new Point(3, 516);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(978, 33);
            panelBotoes.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.MidnightBlue;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 25);
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Location = new Point(510, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar Solução";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += button1_Click_1;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.Green;
            btnFinalizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 30, 0);
            btnFinalizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.ForeColor = SystemColors.Control;
            btnFinalizar.Location = new Point(630, 3);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(134, 23);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Finalizar Chamado";
            btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // menuStripDetalhes
            // 
            menuStripDetalhes.BackColor = Color.SteelBlue;
            menuStripDetalhes.Items.AddRange(new ToolStripItem[] { stripUsuarioDetalhes, stripSobreDetalhes, stripManualDetalhes });
            menuStripDetalhes.Location = new Point(0, 0);
            menuStripDetalhes.Name = "menuStripDetalhes";
            menuStripDetalhes.Size = new Size(984, 24);
            menuStripDetalhes.TabIndex = 3;
            menuStripDetalhes.Text = "menuStrip1";
            // 
            // stripUsuarioDetalhes
            // 
            stripUsuarioDetalhes.DropDownItems.AddRange(new ToolStripItem[] { stripLogoutDetalhes });
            stripUsuarioDetalhes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stripUsuarioDetalhes.ForeColor = SystemColors.ControlLightLight;
            stripUsuarioDetalhes.Name = "stripUsuarioDetalhes";
            stripUsuarioDetalhes.Size = new Size(61, 20);
            stripUsuarioDetalhes.Text = "Usuário";
            // 
            // stripLogoutDetalhes
            // 
            stripLogoutDetalhes.Name = "stripLogoutDetalhes";
            stripLogoutDetalhes.Size = new Size(148, 22);
            stripLogoutDetalhes.Text = "Fazer LogOut";
            // 
            // stripSobreDetalhes
            // 
            stripSobreDetalhes.DropDownItems.AddRange(new ToolStripItem[] { stripSobreHDetalhes });
            stripSobreDetalhes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stripSobreDetalhes.ForeColor = SystemColors.ControlLightLight;
            stripSobreDetalhes.Name = "stripSobreDetalhes";
            stripSobreDetalhes.Size = new Size(52, 20);
            stripSobreDetalhes.Text = "Sobre";
            // 
            // stripSobreHDetalhes
            // 
            stripSobreHDetalhes.Name = "stripSobreHDetalhes";
            stripSobreHDetalhes.Size = new Size(167, 22);
            stripSobreHDetalhes.Text = "Sobre a HelpBox";
            stripSobreHDetalhes.Click += stripSobreHDetalhes_Click;
            // 
            // stripManualDetalhes
            // 
            stripManualDetalhes.DropDownItems.AddRange(new ToolStripItem[] { stripMSistemaDetalhes });
            stripManualDetalhes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stripManualDetalhes.ForeColor = SystemColors.ControlLightLight;
            stripManualDetalhes.Name = "stripManualDetalhes";
            stripManualDetalhes.Size = new Size(59, 20);
            stripManualDetalhes.Text = "Manual";
            // 
            // stripMSistemaDetalhes
            // 
            stripMSistemaDetalhes.Name = "stripMSistemaDetalhes";
            stripMSistemaDetalhes.Size = new Size(178, 22);
            stripMSistemaDetalhes.Text = "Manual do Sistema";
            // 
            // frmDetalhesChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 687);
            Controls.Add(tlpDetalhes);
            Controls.Add(menuStripDetalhes);
            MainMenuStrip = menuStripDetalhes;
            MinimumSize = new Size(1000, 726);
            Name = "frmDetalhesChamado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpBox - Chamados.";
            groupBoxDetalhes.ResumeLayout(false);
            groupBoxDetalhes.PerformLayout();
            groupBoxResolucao.ResumeLayout(false);
            groupBoxResolucao.PerformLayout();
            tlpDetalhes.ResumeLayout(false);
            panelBotoes.ResumeLayout(false);
            menuStripDetalhes.ResumeLayout(false);
            menuStripDetalhes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxDetalhes;
        private TextBox txtAssunto;
        private Label lblAssunto;
        private TextBox txtInicioProb;
        private Label lblProblema;
        private Label lblCateg;
        private TextBox txtCategoria;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private Label lblAbrangencia;
        private Label lblFrequencia;
        private Label lblImpacto;
        private TextBox txtAbrangencia;
        private TextBox txtFrequencia;
        private TextBox txtImpacto;
        private GroupBox groupBoxResolucao;
        private TableLayoutPanel tlpDetalhes;
        private Panel panelBotoes;
        private TextBox txtSolucaoTec;
        private Button btnSalvar;
        private Button btnFinalizar;
        private Label labelSolucaoIA;
        private TextBox txtSolucaoIA;
        private MenuStrip menuStripDetalhes;
        private ToolStripMenuItem stripUsuarioDetalhes;
        private ToolStripMenuItem stripLogoutDetalhes;
        private ToolStripMenuItem stripSobreDetalhes;
        private ToolStripMenuItem stripSobreHDetalhes;
        private ToolStripMenuItem stripManualDetalhes;
        private ToolStripMenuItem stripMSistemaDetalhes;
    }
}