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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            splicontPrincipal = new SplitContainer();
            tlpMenuLateral = new TableLayoutPanel();
            lblPerfil = new Label();
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
            splicontPrincipal.Location = new Point(0, 30);
            splicontPrincipal.Margin = new Padding(3, 4, 3, 4);
            splicontPrincipal.Name = "splicontPrincipal";
            // 
            // splicontPrincipal.Panel1
            // 
            splicontPrincipal.Panel1.Controls.Add(tlpMenuLateral);
            // 
            // splicontPrincipal.Panel2
            // 
            splicontPrincipal.Panel2.Controls.Add(tlpConteudo);
            splicontPrincipal.Size = new Size(1125, 886);
            splicontPrincipal.SplitterDistance = 229;
            splicontPrincipal.SplitterWidth = 5;
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
            tlpMenuLateral.Margin = new Padding(3, 4, 3, 4);
            tlpMenuLateral.Name = "tlpMenuLateral";
            tlpMenuLateral.RowCount = 4;
            tlpMenuLateral.RowStyles.Add(new RowStyle());
            tlpMenuLateral.RowStyles.Add(new RowStyle());
            tlpMenuLateral.RowStyles.Add(new RowStyle());
            tlpMenuLateral.RowStyles.Add(new RowStyle());
            tlpMenuLateral.RowStyles.Add(new RowStyle());
            tlpMenuLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMenuLateral.Size = new Size(229, 886);
            tlpMenuLateral.TabIndex = 0;
            // 
            // lblPerfil
            // 
            lblPerfil.Anchor = AnchorStyles.Top;
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfil.ForeColor = SystemColors.ControlLightLight;
            lblPerfil.Location = new Point(77, 0);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(75, 32);
            lblPerfil.TabIndex = 2;
            lblPerfil.Text = "Perfil";
            // 
            // picFotoUser
            // 
            picFotoUser.Anchor = AnchorStyles.None;
            picFotoUser.Image = Properties.Resources.icon_user;
            picFotoUser.Location = new Point(45, 36);
            picFotoUser.Margin = new Padding(3, 4, 3, 4);
            picFotoUser.Name = "picFotoUser";
            picFotoUser.Size = new Size(138, 117);
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
            lblBoasVindas.Location = new Point(3, 157);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(223, 20);
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
            lblEmail.Location = new Point(3, 177);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(223, 20);
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
            btnLogOut.Location = new Point(109, 835);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(117, 47);
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
            tlpConteudo.Margin = new Padding(3, 4, 3, 4);
            tlpConteudo.Name = "tlpConteudo";
            tlpConteudo.RowCount = 3;
            tlpConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 147F));
            tlpConteudo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpConteudo.RowStyles.Add(new RowStyle());
            tlpConteudo.Size = new Size(891, 886);
            tlpConteudo.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Fill;
            panelLogo.Location = new Point(3, 4);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(885, 139);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.Image = Properties.Resources.helpbox_removebg_preview3;
            pictureBox1.Location = new Point(101, -25);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(686, 173);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChamados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamados.Columns.AddRange(new DataGridViewColumn[] { ColunaIdCham, ColunaCategoria, ColunaAssunto, ColunaPrioridade, ColunaData, ColunaStatus, ColunaSolucionar, ColunaDetalhes });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Azure;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvChamados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvChamados.Dock = DockStyle.Fill;
            dgvChamados.EnableHeadersVisualStyles = false;
            dgvChamados.GridColor = SystemColors.GrayText;
            dgvChamados.Location = new Point(3, 151);
            dgvChamados.Margin = new Padding(3, 4, 3, 4);
            dgvChamados.Name = "dgvChamados";
            dgvChamados.ReadOnly = true;
            dgvChamados.RowHeadersVisible = false;
            dgvChamados.RowHeadersWidth = 51;
            dgvChamados.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvChamados.Size = new Size(885, 676);
            dgvChamados.TabIndex = 1;
            dgvChamados.CellContentClick += dgvChamados_CellContentClick;
            // 
            // ColunaIdCham
            // 
            ColunaIdCham.HeaderText = "ID Chamado";
            ColunaIdCham.MinimumWidth = 6;
            ColunaIdCham.Name = "ColunaIdCham";
            ColunaIdCham.ReadOnly = true;
            // 
            // ColunaCategoria
            // 
            ColunaCategoria.HeaderText = "Categoria";
            ColunaCategoria.MinimumWidth = 6;
            ColunaCategoria.Name = "ColunaCategoria";
            ColunaCategoria.ReadOnly = true;
            // 
            // ColunaAssunto
            // 
            ColunaAssunto.HeaderText = "Assunto";
            ColunaAssunto.MinimumWidth = 6;
            ColunaAssunto.Name = "ColunaAssunto";
            ColunaAssunto.ReadOnly = true;
            // 
            // ColunaPrioridade
            // 
            ColunaPrioridade.HeaderText = "Prioridade";
            ColunaPrioridade.MinimumWidth = 6;
            ColunaPrioridade.Name = "ColunaPrioridade";
            ColunaPrioridade.ReadOnly = true;
            // 
            // ColunaData
            // 
            ColunaData.HeaderText = "Data de Abertura";
            ColunaData.MinimumWidth = 6;
            ColunaData.Name = "ColunaData";
            ColunaData.ReadOnly = true;
            // 
            // ColunaStatus
            // 
            ColunaStatus.HeaderText = "Status";
            ColunaStatus.MinimumWidth = 6;
            ColunaStatus.Name = "ColunaStatus";
            ColunaStatus.ReadOnly = true;
            // 
            // ColunaSolucionar
            // 
            ColunaSolucionar.HeaderText = "";
            ColunaSolucionar.MinimumWidth = 6;
            ColunaSolucionar.Name = "ColunaSolucionar";
            ColunaSolucionar.ReadOnly = true;
            ColunaSolucionar.Text = "Solucionar";
            ColunaSolucionar.UseColumnTextForButtonValue = true;
            // 
            // ColunaDetalhes
            // 
            ColunaDetalhes.HeaderText = "";
            ColunaDetalhes.MinimumWidth = 6;
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
            btnManual.Location = new Point(725, 835);
            btnManual.Margin = new Padding(3, 4, 3, 4);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(163, 47);
            btnManual.TabIndex = 1;
            btnManual.Text = "Manual do Usuário";
            btnManual.UseVisualStyleBackColor = false;
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.BackColor = Color.SteelBlue;
            menuStripPrincipal.ImageScalingSize = new Size(20, 20);
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { tsmMenuLateral, stripUsuarioPrincipal, stripSobrePrincipal, stripManualPrincipal });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Padding = new Padding(7, 3, 0, 3);
            menuStripPrincipal.Size = new Size(1125, 30);
            menuStripPrincipal.TabIndex = 1;
            menuStripPrincipal.Text = "menuStrip1";
            // 
            // tsmMenuLateral
            // 
            tsmMenuLateral.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsmMenuLateral.ForeColor = SystemColors.Control;
            tsmMenuLateral.Name = "tsmMenuLateral";
            tsmMenuLateral.Size = new Size(37, 24);
            tsmMenuLateral.Text = "☰";
            tsmMenuLateral.Click += toolStripMenuItem1_Click;
            // 
            // stripUsuarioPrincipal
            // 
            stripUsuarioPrincipal.DropDownItems.AddRange(new ToolStripItem[] { stripLogoutPrincipal });
            stripUsuarioPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stripUsuarioPrincipal.ForeColor = SystemColors.ControlLightLight;
            stripUsuarioPrincipal.ImageTransparentColor = Color.Transparent;
            stripUsuarioPrincipal.Name = "stripUsuarioPrincipal";
            stripUsuarioPrincipal.Size = new Size(77, 24);
            stripUsuarioPrincipal.Text = "Usuario";
            // 
            // stripLogoutPrincipal
            // 
            stripLogoutPrincipal.Name = "stripLogoutPrincipal";
            stripLogoutPrincipal.Size = new Size(185, 26);
            stripLogoutPrincipal.Text = "Fazer LogOut";
            // 
            // stripSobrePrincipal
            // 
            stripSobrePrincipal.DropDownItems.AddRange(new ToolStripItem[] { stripSobreHPrincipal });
            stripSobrePrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stripSobrePrincipal.ForeColor = SystemColors.ButtonHighlight;
            stripSobrePrincipal.Name = "stripSobrePrincipal";
            stripSobrePrincipal.Size = new Size(63, 24);
            stripSobrePrincipal.Text = "Sobre";
            // 
            // stripSobreHPrincipal
            // 
            stripSobreHPrincipal.Name = "stripSobreHPrincipal";
            stripSobreHPrincipal.Size = new Size(207, 26);
            stripSobreHPrincipal.Text = "Sobre a HelpBox";
            stripSobreHPrincipal.Click += stripSobreHPrincipal_Click;
            // 
            // stripManualPrincipal
            // 
            stripManualPrincipal.DropDownItems.AddRange(new ToolStripItem[] { stripMSistemaPrincipal });
            stripManualPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stripManualPrincipal.ForeColor = SystemColors.ButtonHighlight;
            stripManualPrincipal.Name = "stripManualPrincipal";
            stripManualPrincipal.Size = new Size(75, 24);
            stripManualPrincipal.Text = "Manual";
            // 
            // stripMSistemaPrincipal
            // 
            stripMSistemaPrincipal.Name = "stripMSistemaPrincipal";
            stripMSistemaPrincipal.Size = new Size(225, 26);
            stripMSistemaPrincipal.Text = "Manual do Sistema";
            // 
            // timerMenu
            // 
            timerMenu.Interval = 10;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // frmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1125, 916);
            Controls.Add(splicontPrincipal);
            Controls.Add(menuStripPrincipal);
            MainMenuStrip = menuStripPrincipal;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 952);
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