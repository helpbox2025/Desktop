namespace HelpBox
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpLogin = new TableLayoutPanel();
            pnLogin = new Panel();
            btnSair = new Button();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            lblUsuario = new Label();
            lblDescricao = new Label();
            lblBoasVindas = new Label();
            pboxLogoHP = new PictureBox();
            tlpLogin.SuspendLayout();
            pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogoHP).BeginInit();
            SuspendLayout();
            // 
            // tlpLogin
            // 
            tlpLogin.ColumnCount = 3;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle());
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogin.Controls.Add(pnLogin, 1, 1);
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.Location = new Point(0, 0);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 3;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLogin.RowStyles.Add(new RowStyle());
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLogin.Size = new Size(984, 661);
            tlpLogin.TabIndex = 18;
            // 
            // pnLogin
            // 
            pnLogin.Controls.Add(btnSair);
            pnLogin.Controls.Add(btnEntrar);
            pnLogin.Controls.Add(txtSenha);
            pnLogin.Controls.Add(txtUsuario);
            pnLogin.Controls.Add(lblSenha);
            pnLogin.Controls.Add(lblUsuario);
            pnLogin.Controls.Add(lblDescricao);
            pnLogin.Controls.Add(lblBoasVindas);
            pnLogin.Controls.Add(pboxLogoHP);
            pnLogin.Location = new Point(84, 101);
            pnLogin.MinimumSize = new Size(816, 459);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(816, 459);
            pnLogin.TabIndex = 9;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(192, 0, 0);
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btnSair.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.ButtonHighlight;
            btnSair.Location = new Point(303, 390);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(92, 36);
            btnSair.TabIndex = 17;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(0, 0, 130);
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 30);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.Control;
            btnEntrar.Location = new Point(449, 390);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(92, 36);
            btnEntrar.TabIndex = 16;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(74, 112, 122);
            txtSenha.Location = new Point(303, 352);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(235, 23);
            txtSenha.TabIndex = 15;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(74, 112, 122);
            txtUsuario.Location = new Point(303, 318);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(235, 23);
            txtUsuario.TabIndex = 14;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.Black;
            lblSenha.Location = new Point(244, 355);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(53, 14);
            lblSenha.TabIndex = 13;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(236, 321);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 14);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "Usuário:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = Color.FromArgb(0, 0, 34);
            lblDescricao.Location = new Point(256, 270);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(322, 14);
            lblDescricao.TabIndex = 11;
            lblDescricao.Text = "Para acessar o sistema, digite suas credenciais.";
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoasVindas.ForeColor = Color.FromArgb(0, 0, 64);
            lblBoasVindas.Location = new Point(170, 199);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(481, 71);
            lblBoasVindas.TabIndex = 10;
            lblBoasVindas.Text = "SEJA BEM VINDO!";
            // 
            // pboxLogoHP
            // 
            pboxLogoHP.Image = Properties.Resources.helpbox_removebg_preview;
            pboxLogoHP.Location = new Point(126, -19);
            pboxLogoHP.Name = "pboxLogoHP";
            pboxLogoHP.Size = new Size(558, 225);
            pboxLogoHP.TabIndex = 9;
            pboxLogoHP.TabStop = false;
            pboxLogoHP.Click += pboxLogoHP_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 112, 122);
            ClientSize = new Size(984, 661);
            Controls.Add(tlpLogin);
            MinimumSize = new Size(1000, 653);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpBox - Login.";
            WindowState = FormWindowState.Maximized;
            tlpLogin.ResumeLayout(false);
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogoHP).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpLogin;
        private Panel pnLogin;
        private Button btnSair;
        private Button btnEntrar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label lblSenha;
        private Label lblUsuario;
        private Label lblDescricao;
        private Label lblBoasVindas;
        private PictureBox pboxLogoHP;
    }
}
