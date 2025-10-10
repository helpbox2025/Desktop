namespace HelpBox
{
    partial class frmTelaInicial
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
            tlpInicial = new TableLayoutPanel();
            tlpCabecalho = new TableLayoutPanel();
            pbLogoInicial = new PictureBox();
            btnLogOut = new Button();
            lblBemVindo = new Label();
            tlpRodape = new TableLayoutPanel();
            BtnAbrirCham = new Button();
            flpBotoesDir = new FlowLayoutPanel();
            btnManual = new Button();
            btnSolucionarCham = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            fazerLogOutToolStripMenuItem = new ToolStripMenuItem();
            helpBoxToolStripMenuItem = new ToolStripMenuItem();
            sobreAHelpBoxToolStripMenuItem = new ToolStripMenuItem();
            manualDoSistemaToolStripMenuItem = new ToolStripMenuItem();
            acesseAoManualToolStripMenuItem = new ToolStripMenuItem();
            tlpInicial.SuspendLayout();
            tlpCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoInicial).BeginInit();
            tlpRodape.SuspendLayout();
            flpBotoesDir.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpInicial
            // 
            tlpInicial.BackColor = Color.LightSteelBlue;
            tlpInicial.ColumnCount = 1;
            tlpInicial.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInicial.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpInicial.Controls.Add(tlpCabecalho, 0, 0);
            tlpInicial.Controls.Add(tlpRodape, 0, 2);
            tlpInicial.Dock = DockStyle.Fill;
            tlpInicial.Location = new Point(0, 24);
            tlpInicial.Name = "tlpInicial";
            tlpInicial.RowCount = 3;
            tlpInicial.RowStyles.Add(new RowStyle());
            tlpInicial.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInicial.RowStyles.Add(new RowStyle());
            tlpInicial.Size = new Size(800, 426);
            tlpInicial.TabIndex = 0;
            // 
            // tlpCabecalho
            // 
            tlpCabecalho.ColumnCount = 3;
            tlpCabecalho.ColumnStyles.Add(new ColumnStyle());
            tlpCabecalho.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCabecalho.ColumnStyles.Add(new ColumnStyle());
            tlpCabecalho.Controls.Add(pbLogoInicial, 0, 0);
            tlpCabecalho.Controls.Add(btnLogOut, 2, 0);
            tlpCabecalho.Controls.Add(lblBemVindo, 1, 0);
            tlpCabecalho.Dock = DockStyle.Fill;
            tlpCabecalho.Location = new Point(3, 3);
            tlpCabecalho.Name = "tlpCabecalho";
            tlpCabecalho.RowCount = 2;
            tlpCabecalho.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCabecalho.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCabecalho.Size = new Size(794, 338);
            tlpCabecalho.TabIndex = 0;
            // 
            // pbLogoInicial
            // 
            pbLogoInicial.Image = Properties.Resources.helpbox_removebg_preview2;
            pbLogoInicial.Location = new Point(3, 3);
            pbLogoInicial.Name = "pbLogoInicial";
            pbLogoInicial.Size = new Size(575, 237);
            pbLogoInicial.TabIndex = 0;
            pbLogoInicial.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Maroon;
            btnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ControlLightLight;
            btnLogOut.Location = new Point(683, 3);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(108, 46);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Fazer LogOut";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Dock = DockStyle.Fill;
            lblBemVindo.ForeColor = SystemColors.ControlLightLight;
            lblBemVindo.Location = new Point(584, 0);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(93, 318);
            lblBemVindo.TabIndex = 1;
            lblBemVindo.Text = "Seja Bem Vindo!";
            lblBemVindo.TextAlign = ContentAlignment.TopCenter;
            // 
            // tlpRodape
            // 
            tlpRodape.ColumnCount = 2;
            tlpRodape.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRodape.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRodape.Controls.Add(BtnAbrirCham, 0, 0);
            tlpRodape.Controls.Add(flpBotoesDir, 1, 0);
            tlpRodape.Dock = DockStyle.Fill;
            tlpRodape.Location = new Point(3, 323);
            tlpRodape.Name = "tlpRodape";
            tlpRodape.RowCount = 1;
            tlpRodape.RowStyles.Add(new RowStyle());
            tlpRodape.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpRodape.Size = new Size(794, 100);
            tlpRodape.TabIndex = 1;
            // 
            // BtnAbrirCham
            // 
            BtnAbrirCham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAbrirCham.BackColor = Color.LightSteelBlue;
            BtnAbrirCham.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAbrirCham.ForeColor = SystemColors.ControlLightLight;
            BtnAbrirCham.Location = new Point(3, 47);
            BtnAbrirCham.Name = "BtnAbrirCham";
            BtnAbrirCham.Size = new Size(240, 50);
            BtnAbrirCham.TabIndex = 0;
            BtnAbrirCham.Text = "Abrir Chamado";
            BtnAbrirCham.UseVisualStyleBackColor = false;
            BtnAbrirCham.Click += BtnAbrirCham_Click;
            // 
            // flpBotoesDir
            // 
            flpBotoesDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flpBotoesDir.AutoSize = true;
            flpBotoesDir.Controls.Add(btnManual);
            flpBotoesDir.Controls.Add(btnSolucionarCham);
            flpBotoesDir.FlowDirection = FlowDirection.RightToLeft;
            flpBotoesDir.Location = new Point(419, 41);
            flpBotoesDir.Name = "flpBotoesDir";
            flpBotoesDir.Size = new Size(372, 56);
            flpBotoesDir.TabIndex = 1;
            // 
            // btnManual
            // 
            btnManual.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnManual.BackColor = Color.LightSteelBlue;
            btnManual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManual.ForeColor = SystemColors.ControlLightLight;
            btnManual.Location = new Point(249, 3);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(120, 50);
            btnManual.TabIndex = 0;
            btnManual.Text = "Manual do Sistema";
            btnManual.UseVisualStyleBackColor = false;
            // 
            // btnSolucionarCham
            // 
            btnSolucionarCham.Anchor = AnchorStyles.Bottom;
            btnSolucionarCham.BackColor = Color.CornflowerBlue;
            btnSolucionarCham.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSolucionarCham.ForeColor = SystemColors.ControlLightLight;
            btnSolucionarCham.Location = new Point(3, 3);
            btnSolucionarCham.Name = "btnSolucionarCham";
            btnSolucionarCham.Size = new Size(240, 50);
            btnSolucionarCham.TabIndex = 1;
            btnSolucionarCham.Text = "Solucionar Chamados";
            btnSolucionarCham.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, helpBoxToolStripMenuItem, manualDoSistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { fazerLogOutToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(59, 20);
            toolStripMenuItem1.Text = "Usuário";
            // 
            // fazerLogOutToolStripMenuItem
            // 
            fazerLogOutToolStripMenuItem.Name = "fazerLogOutToolStripMenuItem";
            fazerLogOutToolStripMenuItem.Size = new Size(147, 22);
            fazerLogOutToolStripMenuItem.Text = "Fazer LogOut.";
            // 
            // helpBoxToolStripMenuItem
            // 
            helpBoxToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreAHelpBoxToolStripMenuItem });
            helpBoxToolStripMenuItem.Name = "helpBoxToolStripMenuItem";
            helpBoxToolStripMenuItem.Size = new Size(64, 20);
            helpBoxToolStripMenuItem.Text = "HelpBox";
            // 
            // sobreAHelpBoxToolStripMenuItem
            // 
            sobreAHelpBoxToolStripMenuItem.Name = "sobreAHelpBoxToolStripMenuItem";
            sobreAHelpBoxToolStripMenuItem.Size = new Size(161, 22);
            sobreAHelpBoxToolStripMenuItem.Text = "Sobre a HelpBox";
            // 
            // manualDoSistemaToolStripMenuItem
            // 
            manualDoSistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acesseAoManualToolStripMenuItem });
            manualDoSistemaToolStripMenuItem.Name = "manualDoSistemaToolStripMenuItem";
            manualDoSistemaToolStripMenuItem.Size = new Size(120, 20);
            manualDoSistemaToolStripMenuItem.Text = "Manual do Sistema";
            // 
            // acesseAoManualToolStripMenuItem
            // 
            acesseAoManualToolStripMenuItem.Name = "acesseAoManualToolStripMenuItem";
            acesseAoManualToolStripMenuItem.Size = new Size(169, 22);
            acesseAoManualToolStripMenuItem.Text = "Acesse ao Manual";
            // 
            // frmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpInicial);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmTelaInicial";
            Text = "Tela Inicial";
            WindowState = FormWindowState.Minimized;
            tlpInicial.ResumeLayout(false);
            tlpCabecalho.ResumeLayout(false);
            tlpCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoInicial).EndInit();
            tlpRodape.ResumeLayout(false);
            tlpRodape.PerformLayout();
            flpBotoesDir.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpInicial;
        private TableLayoutPanel tlpCabecalho;
        private PictureBox pbLogoInicial;
        private Label lblBemVindo;
        private Button btnLogOut;
        private TableLayoutPanel tlpRodape;
        private Button BtnAbrirCham;
        private FlowLayoutPanel flpBotoesDir;
        private Button btnManual;
        private Button btnSolucionarCham;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem fazerLogOutToolStripMenuItem;
        private ToolStripMenuItem helpBoxToolStripMenuItem;
        private ToolStripMenuItem sobreAHelpBoxToolStripMenuItem;
        private ToolStripMenuItem manualDoSistemaToolStripMenuItem;
        private ToolStripMenuItem acesseAoManualToolStripMenuItem;
    }
}