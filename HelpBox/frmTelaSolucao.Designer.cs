namespace HelpBox
{
    partial class frmTelaSolucao
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
            tlpSolucao = new TableLayoutPanel();
            tlpCabecalho = new TableLayoutPanel();
            btnSair = new Button();
            lblSolucionarCham = new Label();
            dgvChamados = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnCateg = new DataGridViewTextBoxColumn();
            ColumnPrio = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewButtonColumn();
            menuStripInicio = new MenuStrip();
            stripUsuarioInicio = new ToolStripMenuItem();
            stripLogoutInicio = new ToolStripMenuItem();
            stripSobreInicio = new ToolStripMenuItem();
            stripSobreHInicio = new ToolStripMenuItem();
            stripManualInicio = new ToolStripMenuItem();
            stripMSistemaInicio = new ToolStripMenuItem();
            tlpSolucao.SuspendLayout();
            tlpCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamados).BeginInit();
            menuStripInicio.SuspendLayout();
            SuspendLayout();
            // 
            // tlpSolucao
            // 
            tlpSolucao.ColumnCount = 1;
            tlpSolucao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSolucao.Controls.Add(tlpCabecalho, 0, 0);
            tlpSolucao.Controls.Add(dgvChamados, 0, 1);
            tlpSolucao.Dock = DockStyle.Fill;
            tlpSolucao.Location = new Point(0, 24);
            tlpSolucao.Name = "tlpSolucao";
            tlpSolucao.RowCount = 2;
            tlpSolucao.RowStyles.Add(new RowStyle());
            tlpSolucao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSolucao.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSolucao.Size = new Size(800, 426);
            tlpSolucao.TabIndex = 2;
            // 
            // tlpCabecalho
            // 
            tlpCabecalho.AutoSize = true;
            tlpCabecalho.ColumnCount = 2;
            tlpCabecalho.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCabecalho.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCabecalho.Controls.Add(btnSair, 1, 0);
            tlpCabecalho.Controls.Add(lblSolucionarCham, 0, 0);
            tlpCabecalho.Dock = DockStyle.Fill;
            tlpCabecalho.Location = new Point(3, 3);
            tlpCabecalho.Name = "tlpCabecalho";
            tlpCabecalho.RowCount = 1;
            tlpCabecalho.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCabecalho.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCabecalho.Size = new Size(794, 39);
            tlpCabecalho.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Right;
            btnSair.BackColor = Color.FromArgb(192, 0, 0);
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnSair.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.ControlLightLight;
            btnSair.Location = new Point(690, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(101, 33);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // lblSolucionarCham
            // 
            lblSolucionarCham.Anchor = AnchorStyles.Left;
            lblSolucionarCham.AutoSize = true;
            lblSolucionarCham.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSolucionarCham.ForeColor = SystemColors.WindowText;
            lblSolucionarCham.Location = new Point(3, 7);
            lblSolucionarCham.Name = "lblSolucionarCham";
            lblSolucionarCham.Size = new Size(197, 25);
            lblSolucionarCham.TabIndex = 0;
            lblSolucionarCham.Text = "Solucionar Chamado";
            // 
            // dgvChamados
            // 
            dgvChamados.AllowUserToAddRows = false;
            dgvChamados.AllowUserToDeleteRows = false;
            dgvChamados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamados.BackgroundColor = Color.AliceBlue;
            dgvChamados.BorderStyle = BorderStyle.None;
            dgvChamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamados.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnCateg, ColumnPrio, ColumnDate, ColumnStatus, Column1 });
            dgvChamados.Dock = DockStyle.Fill;
            dgvChamados.GridColor = SystemColors.MenuBar;
            dgvChamados.Location = new Point(3, 48);
            dgvChamados.Name = "dgvChamados";
            dgvChamados.ReadOnly = true;
            dgvChamados.RowHeadersVisible = false;
            dgvChamados.Size = new Size(794, 375);
            dgvChamados.TabIndex = 3;
            dgvChamados.CellContentClick += dgvChamados_CellContentClick;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID Chamado";
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            // 
            // ColumnCateg
            // 
            ColumnCateg.HeaderText = "Categoria";
            ColumnCateg.Name = "ColumnCateg";
            ColumnCateg.ReadOnly = true;
            // 
            // ColumnPrio
            // 
            ColumnPrio.HeaderText = "Prioridade";
            ColumnPrio.Name = "ColumnPrio";
            ColumnPrio.ReadOnly = true;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Data de Abertura";
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Text = "Solucionar";
            Column1.UseColumnTextForButtonValue = true;
            // 
            // menuStripInicio
            // 
            menuStripInicio.BackColor = Color.LightSteelBlue;
            menuStripInicio.Items.AddRange(new ToolStripItem[] { stripUsuarioInicio, stripSobreInicio, stripManualInicio });
            menuStripInicio.Location = new Point(0, 0);
            menuStripInicio.Name = "menuStripInicio";
            menuStripInicio.Size = new Size(800, 24);
            menuStripInicio.TabIndex = 3;
            menuStripInicio.Text = "menuStrip2";
            // 
            // stripUsuarioInicio
            // 
            stripUsuarioInicio.DropDownItems.AddRange(new ToolStripItem[] { stripLogoutInicio });
            stripUsuarioInicio.Name = "stripUsuarioInicio";
            stripUsuarioInicio.Size = new Size(59, 20);
            stripUsuarioInicio.Text = "Usuario";
            // 
            // stripLogoutInicio
            // 
            stripLogoutInicio.Name = "stripLogoutInicio";
            stripLogoutInicio.Size = new Size(180, 22);
            stripLogoutInicio.Text = "Fazer LogOut";
            // 
            // stripSobreInicio
            // 
            stripSobreInicio.DropDownItems.AddRange(new ToolStripItem[] { stripSobreHInicio });
            stripSobreInicio.Name = "stripSobreInicio";
            stripSobreInicio.Size = new Size(49, 20);
            stripSobreInicio.Text = "Sobre";
            // 
            // stripSobreHInicio
            // 
            stripSobreHInicio.Name = "stripSobreHInicio";
            stripSobreHInicio.Size = new Size(161, 22);
            stripSobreHInicio.Text = "Sobre a HelpBox";
            // 
            // stripManualInicio
            // 
            stripManualInicio.DropDownItems.AddRange(new ToolStripItem[] { stripMSistemaInicio });
            stripManualInicio.Name = "stripManualInicio";
            stripManualInicio.Size = new Size(59, 20);
            stripManualInicio.Text = "Manual";
            // 
            // stripMSistemaInicio
            // 
            stripMSistemaInicio.Name = "stripMSistemaInicio";
            stripMSistemaInicio.Size = new Size(175, 22);
            stripMSistemaInicio.Text = "Manual do Sistema";
            // 
            // frmTelaSolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpSolucao);
            Controls.Add(menuStripInicio);
            MainMenuStrip = menuStripInicio;
            MinimumSize = new Size(816, 489);
            Name = "frmTelaSolucao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Helpox - Gerenciamento de Chamados.";
            WindowState = FormWindowState.Maximized;
            Load += frmTelaPrincipal_Load;
            tlpSolucao.ResumeLayout(false);
            tlpSolucao.PerformLayout();
            tlpCabecalho.ResumeLayout(false);
            tlpCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamados).EndInit();
            menuStripInicio.ResumeLayout(false);
            menuStripInicio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem fazerLogOffToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sobreAHelpBoxToolStripMenuItem;
        private TableLayoutPanel tlpSolucao;
        private TableLayoutPanel tlpCabecalho;
        private Label lblSolucionarCham;
        private Button btnSair;
        private DataGridView dgvChamados;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnCateg;
        private DataGridViewTextBoxColumn ColumnPrio;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewButtonColumn Column1;
        private MenuStrip menuStripInicio;
        private ToolStripMenuItem stripUsuarioInicio;
        private ToolStripMenuItem stripLogoutInicio;
        private ToolStripMenuItem stripSobreInicio;
        private ToolStripMenuItem stripSobreHInicio;
        private ToolStripMenuItem stripManualInicio;
        private ToolStripMenuItem stripMSistemaInicio;
    }
}