namespace HelpBox
{
    partial class frmTelaPrincipal
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            splicontPrincipal = new SplitContainer();
            tlpMenuLateral = new TableLayoutPanel();
            picFotoUser = new PictureBox();
            lblBoasVindas = new Label();
            lblEmail = new Label();
            btnLogOut = new Button();
            tlpConteudo = new TableLayoutPanel();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            dgvChamados = new DataGridView();
            ColunaIdCham = new DataGridViewTextBoxColumn();
            ColunaCategoria = new DataGridViewTextBoxColumn();
            ColunaAssunto = new DataGridViewTextBoxColumn();
            ColunaPrioridade = new DataGridViewTextBoxColumn();
            ColunaData = new DataGridViewTextBoxColumn();
            ColunaStatus = new DataGridViewTextBoxColumn();
            ColunaSolucionar = new DataGridViewButtonColumn();
            ColunaDetalhes = new DataGridViewButtonColumn();
            btnManual = new Button();
            menuStripPrincipal = new MenuStrip();
            tsmMenuLateral = new ToolStripMenuItem();
            stripUsuarioPrincipal = new ToolStripMenuItem();
            stripLogoutPrincipal = new ToolStripMenuItem();
            stripSobrePrincipal = new ToolStripMenuItem();
            stripSobreHPrincipal = new ToolStripMenuItem();
            stripManualPrincipal = new ToolStripMenuItem();
            stripMSistemaPrincipal = new ToolStripMenuItem();
            timerMenu = new System.Windows.Forms.Timer(components);
            lblPerfil = new Label();
            ((System.ComponentModel.ISupportInitialize)splicontPrincipal).BeginInit();
            splicontPrincipal.Panel1.SuspendLayout();
            splicontPrincipal.Panel2.SuspendLayout();
            splicontPrincipal.SuspendLayout();
            tlpMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoUser).BeginInit();
            tlpConteudo.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChamados).BeginInit();
            menuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // splicontPrincipal
            // 
            splicontPrincipal.Dock = DockStyle.Fill;
            splicontPrincipal.FixedPanel = FixedPanel.Panel1;
            splicontPrincipal.IsSplitterFixed = true;
            splicontPrincipal.Location = new Point(0, 24);
            splicontPrincipal.Name = "splicontPrincipal";
            // 
            // splicontPrincipal.Panel1
            // 
            splicontPrincipal.Panel1.Controls.Add(tlpMenuLateral);
            // 
            // splicontPrincipal.Panel2
            // 
            splicontPrincipal.Panel2.Controls.Add(tlpConteudo);
            splicontPrincipal.Size = new Size(800, 426);
            splicontPrincipal.SplitterDistance = 200;
            splicontPrincipal.TabIndex = 0;
            // 
            // tlpMenuLateral
            // 
            tlpMenuLateral.BackColor = Color.SteelBlue;
            tlpMenuLateral.ColumnCount = 1;
            tlpMenuLateral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenuLateral.Controls.Add(lblPerfil, 0, 0);
            tlpMenuLateral.Controls.Add(picFotoUser, 0, 1);
            tlpMenuLateral.Controls.Add(lblBoasVindas, 0, 2);
            tlpMenuLateral.Controls.Add(lblEmail, 0, 3);
            tlpMenuLateral.Controls.Add(btnLogOut, 0, 4);
            tlpMenuLateral.Dock = DockStyle.Fill;
            tlpMenuLateral.Location = new Point(0, 0);
            tlpMenuLateral.Name = "tlpMenuLateral";
            tlpMenuLateral.RowCount = 4;
            tlpMenuLateral.RowStyles.Add(new RowStyle());
            tlpMenuLateral.RowStyles.Add(new RowStyle());
            tlpMenuLateral.RowStyles.Add(new RowStyle());
            tlpMenuLateral.RowStyles.Add(new RowStyle());
            tlpMenuLateral.RowStyles.Add(new RowStyle());
            tlpMenuLateral.Size = new Size(200, 426);
            tlpMenuLateral.TabIndex = 0;
            // 
            // picFotoUser
            // 
            picFotoUser.Anchor = AnchorStyles.None;
            picFotoUser.Image = Properties.Resources.icon_user;
            picFotoUser.Location = new Point(39, 28);
            picFotoUser.Name = "picFotoUser";
            picFotoUser.Size = new Size(121, 88);
            picFotoUser.SizeMode = PictureBoxSizeMode.Zoom;
            picFotoUser.TabIndex = 0;
            picFotoUser.TabStop = false;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Dock = DockStyle.Fill;
            lblBoasVindas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoasVindas.ForeColor = SystemColors.ControlLightLight;
            lblBoasVindas.Location = new Point(3, 119);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(194, 15);
            lblBoasVindas.TabIndex = 1;
            lblBoasVindas.Text = "Olá, Técnico!";
            lblBoasVindas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(3, 134);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(194, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "emailtest@helpbox.com";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogOut.BackColor = Color.FromArgb(192, 0, 0);
            btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnLogOut.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ControlLightLight;
            btnLogOut.Location = new Point(95, 388);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(102, 35);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Fazer LogOut";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // tlpConteudo
            // 
            tlpConteudo.ColumnCount = 1;
            tlpConteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpConteudo.Controls.Add(panelLogo, 0, 0);
            tlpConteudo.Controls.Add(dgvChamados, 0, 1);
            tlpConteudo.Controls.Add(btnManual, 0, 2);
            tlpConteudo.Dock = DockStyle.Fill;
            tlpConteudo.Location = new Point(0, 0);
            tlpConteudo.Name = "tlpConteudo";
            tlpConteudo.RowCount = 3;
            tlpConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tlpConteudo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpConteudo.RowStyles.Add(new RowStyle());
            tlpConteudo.Size = new Size(596, 426);
            tlpConteudo.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Fill;
            panelLogo.Location = new Point(3, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(590, 104);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Image = Properties.Resources.helpbox_removebg_preview3;
            pictureBox1.Location = new Point(-4, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvChamados
            // 
            dgvChamados.AllowUserToAddRows = false;
            dgvChamados.AllowUserToDeleteRows = false;
            dgvChamados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamados.BackgroundColor = Color.LightSteelBlue;
            dgvChamados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.SteelBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvChamados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvChamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamados.Columns.AddRange(new DataGridViewColumn[] { ColunaIdCham, ColunaCategoria, ColunaAssunto, ColunaPrioridade, ColunaData, ColunaStatus, ColunaSolucionar, ColunaDetalhes });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Azure;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvChamados.DefaultCellStyle = dataGridViewCellStyle8;
            dgvChamados.Dock = DockStyle.Fill;
            dgvChamados.EnableHeadersVisualStyles = false;
            dgvChamados.GridColor = SystemColors.GrayText;
            dgvChamados.Location = new Point(3, 113);
            dgvChamados.Name = "dgvChamados";
            dgvChamados.ReadOnly = true;
            dgvChamados.RowHeadersVisible = false;
            dgvChamados.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvChamados.Size = new Size(590, 269);
            dgvChamados.TabIndex = 1;
            // 
            // ColunaIdCham
            // 
            ColunaIdCham.HeaderText = "ID Chamado";
            ColunaIdCham.Name = "ColunaIdCham";
            ColunaIdCham.ReadOnly = true;
            // 
            // ColunaCategoria
            // 
            ColunaCategoria.HeaderText = "Categoria";
            ColunaCategoria.Name = "ColunaCategoria";
            ColunaCategoria.ReadOnly = true;
            // 
            // ColunaAssunto
            // 
            ColunaAssunto.HeaderText = "Assunto";
            ColunaAssunto.Name = "ColunaAssunto";
            ColunaAssunto.ReadOnly = true;
            // 
            // ColunaPrioridade
            // 
            ColunaPrioridade.HeaderText = "Prioridade";
            ColunaPrioridade.Name = "ColunaPrioridade";
            ColunaPrioridade.ReadOnly = true;
            // 
            // ColunaData
            // 
            ColunaData.HeaderText = "Data de Abertura";
            ColunaData.Name = "ColunaData";
            ColunaData.ReadOnly = true;
            // 
            // ColunaStatus
            // 
            ColunaStatus.HeaderText = "Status";
            ColunaStatus.Name = "ColunaStatus";
            ColunaStatus.ReadOnly = true;
            // 
            // ColunaSolucionar
            // 
            ColunaSolucionar.HeaderText = "";
            ColunaSolucionar.Name = "ColunaSolucionar";
            ColunaSolucionar.ReadOnly = true;
            ColunaSolucionar.Text = "Solucionar";
            ColunaSolucionar.UseColumnTextForButtonValue = true;
            // 
            // ColunaDetalhes
            // 
            ColunaDetalhes.HeaderText = "";
            ColunaDetalhes.Name = "ColunaDetalhes";
            ColunaDetalhes.ReadOnly = true;
            ColunaDetalhes.Text = "Ver Detalhes";
            ColunaDetalhes.UseColumnTextForButtonValue = true;
            // 
            // btnManual
            // 
            btnManual.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnManual.BackColor = Color.MidnightBlue;
            btnManual.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 30);
            btnManual.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnManual.FlatStyle = FlatStyle.Flat;
            btnManual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManual.ForeColor = SystemColors.ControlLightLight;
            btnManual.Location = new Point(450, 388);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(143, 35);
            btnManual.TabIndex = 1;
            btnManual.Text = "Manual do Usuário";
            btnManual.UseVisualStyleBackColor = false;
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.BackColor = Color.SteelBlue;
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { tsmMenuLateral, stripUsuarioPrincipal, stripSobrePrincipal, stripManualPrincipal });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Size = new Size(800, 24);
            menuStripPrincipal.TabIndex = 1;
            menuStripPrincipal.Text = "menuStrip1";
            // 
            // tsmMenuLateral
            // 
            tsmMenuLateral.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsmMenuLateral.ForeColor = SystemColors.ActiveCaptionText;
            tsmMenuLateral.Name = "tsmMenuLateral";
            tsmMenuLateral.Size = new Size(31, 20);
            tsmMenuLateral.Text = "☰";
            tsmMenuLateral.Click += toolStripMenuItem1_Click;
            // 
            // stripUsuarioPrincipal
            // 
            stripUsuarioPrincipal.DropDownItems.AddRange(new ToolStripItem[] { stripLogoutPrincipal });
            stripUsuarioPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stripUsuarioPrincipal.ForeColor = SystemColors.ActiveCaptionText;
            stripUsuarioPrincipal.Name = "stripUsuarioPrincipal";
            stripUsuarioPrincipal.Size = new Size(59, 20);
            stripUsuarioPrincipal.Text = "Usuario";
            // 
            // stripLogoutPrincipal
            // 
            stripLogoutPrincipal.Name = "stripLogoutPrincipal";
            stripLogoutPrincipal.Size = new Size(144, 22);
            stripLogoutPrincipal.Text = "Fazer LogOut";
            // 
            // stripSobrePrincipal
            // 
            stripSobrePrincipal.DropDownItems.AddRange(new ToolStripItem[] { stripSobreHPrincipal });
            stripSobrePrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stripSobrePrincipal.ForeColor = SystemColors.ActiveCaptionText;
            stripSobrePrincipal.Name = "stripSobrePrincipal";
            stripSobrePrincipal.Size = new Size(49, 20);
            stripSobrePrincipal.Text = "Sobre";
            // 
            // stripSobreHPrincipal
            // 
            stripSobreHPrincipal.Name = "stripSobreHPrincipal";
            stripSobreHPrincipal.Size = new Size(161, 22);
            stripSobreHPrincipal.Text = "Sobre a HelpBox";
            // 
            // stripManualPrincipal
            // 
            stripManualPrincipal.DropDownItems.AddRange(new ToolStripItem[] { stripMSistemaPrincipal });
            stripManualPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stripManualPrincipal.ForeColor = SystemColors.ActiveCaptionText;
            stripManualPrincipal.Name = "stripManualPrincipal";
            stripManualPrincipal.Size = new Size(59, 20);
            stripManualPrincipal.Text = "Manual";
            // 
            // stripMSistemaPrincipal
            // 
            stripMSistemaPrincipal.Name = "stripMSistemaPrincipal";
            stripMSistemaPrincipal.Size = new Size(175, 22);
            stripMSistemaPrincipal.Text = "Manual do Sistema";
            // 
            // timerMenu
            // 
            timerMenu.Interval = 10;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // lblPerfil
            // 
            lblPerfil.Anchor = AnchorStyles.Top;
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfil.ForeColor = SystemColors.ControlLightLight;
            lblPerfil.Location = new Point(71, 0);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(58, 25);
            lblPerfil.TabIndex = 2;
            lblPerfil.Text = "Perfil";
            // 
            // frmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(splicontPrincipal);
            Controls.Add(menuStripPrincipal);
            MainMenuStrip = menuStripPrincipal;
            Name = "frmTelaPrincipal";
            Text = "HelpBox - Tela Inicial.";
            WindowState = FormWindowState.Maximized;
            Load += frmTelaPrincipal_Load;
            splicontPrincipal.Panel1.ResumeLayout(false);
            splicontPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splicontPrincipal).EndInit();
            splicontPrincipal.ResumeLayout(false);
            tlpMenuLateral.ResumeLayout(false);
            tlpMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoUser).EndInit();
            tlpConteudo.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChamados).EndInit();
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splicontPrincipal;
        private TableLayoutPanel tlpMenuLateral;
        private PictureBox picFotoUser;
        private Label lblBoasVindas;
        private Label lblEmail;
        private Button btnLogOut;
        private TableLayoutPanel tlpConteudo;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private DataGridView dgvChamados;
        private Button btnManual;
        private DataGridViewTextBoxColumn ColunaIdCham;
        private DataGridViewTextBoxColumn ColunaCategoria;
        private DataGridViewTextBoxColumn ColunaAssunto;
        private DataGridViewTextBoxColumn ColunaPrioridade;
        private DataGridViewTextBoxColumn ColunaData;
        private DataGridViewTextBoxColumn ColunaStatus;
        private DataGridViewButtonColumn ColunaSolucionar;
        private DataGridViewButtonColumn ColunaDetalhes;
        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem stripUsuarioPrincipal;
        private ToolStripMenuItem stripSobrePrincipal;
        private ToolStripMenuItem stripManualPrincipal;
        private ToolStripMenuItem stripLogoutPrincipal;
        private ToolStripMenuItem stripSobreHPrincipal;
        private ToolStripMenuItem stripMSistemaPrincipal;
        private ToolStripMenuItem tsmMenuLateral;
        private System.Windows.Forms.Timer timerMenu;
        private Label lblPerfil;
    }
}