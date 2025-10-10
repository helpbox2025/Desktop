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
            tlpPrincipal = new TableLayoutPanel();
            tlpCabecalho = new TableLayoutPanel();
            btnSair = new Button();
            labelSolucionaCham = new Label();
            dgvChamados = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnCateg = new DataGridViewTextBoxColumn();
            ColumnPrio = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewButtonColumn();
            tlpPrincipal.SuspendLayout();
            tlpCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamados).BeginInit();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(tlpCabecalho, 0, 0);
            tlpPrincipal.Controls.Add(dgvChamados, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle());
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPrincipal.Size = new Size(800, 450);
            tlpPrincipal.TabIndex = 2;
            // 
            // tlpCabecalho
            // 
            tlpCabecalho.AutoSize = true;
            tlpCabecalho.ColumnCount = 2;
            tlpCabecalho.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCabecalho.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCabecalho.Controls.Add(btnSair, 1, 0);
            tlpCabecalho.Controls.Add(labelSolucionaCham, 0, 0);
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
            btnSair.BackColor = Color.Maroon;
            btnSair.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.ControlLightLight;
            btnSair.Location = new Point(690, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(101, 33);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // labelSolucionaCham
            // 
            labelSolucionaCham.Anchor = AnchorStyles.Left;
            labelSolucionaCham.AutoSize = true;
            labelSolucionaCham.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSolucionaCham.ForeColor = SystemColors.Window;
            labelSolucionaCham.Location = new Point(3, 7);
            labelSolucionaCham.Name = "labelSolucionaCham";
            labelSolucionaCham.Size = new Size(197, 25);
            labelSolucionaCham.TabIndex = 0;
            labelSolucionaCham.Text = "Solucionar Chamado";
            // 
            // dgvChamados
            // 
            dgvChamados.AllowUserToAddRows = false;
            dgvChamados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamados.BackgroundColor = Color.AliceBlue;
            dgvChamados.BorderStyle = BorderStyle.None;
            dgvChamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamados.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnCateg, ColumnPrio, ColumnDate, ColumnStatus, Column1 });
            dgvChamados.Dock = DockStyle.Fill;
            dgvChamados.GridColor = SystemColors.MenuBar;
            dgvChamados.Location = new Point(3, 48);
            dgvChamados.Name = "dgvChamados";
            dgvChamados.RowHeadersVisible = false;
            dgvChamados.Size = new Size(794, 399);
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
            Column1.Text = "Solucionar";
            Column1.UseColumnTextForButtonValue = true;
            // 
            // frmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpPrincipal);
            Name = "frmTelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Helpox - Gerenciamento de Chamados.";
            WindowState = FormWindowState.Maximized;
            Load += frmTelaPrincipal_Load;
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            tlpCabecalho.ResumeLayout(false);
            tlpCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem fazerLogOffToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sobreAHelpBoxToolStripMenuItem;
        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpCabecalho;
        private Label labelSolucionaCham;
        private Button btnSair;
        private DataGridView dgvChamados;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnCateg;
        private DataGridViewTextBoxColumn ColumnPrio;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewButtonColumn Column1;
    }
}