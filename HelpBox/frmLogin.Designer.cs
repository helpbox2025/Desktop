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
            tlpLogin.Margin = new Padding(3, 4, 3, 4);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 3;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLogin.RowStyles.Add(new RowStyle());
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLogin.Size = new Size(1125, 881);
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
            pnLogin.Location = new Point(96, 134);
            pnLogin.Margin = new Padding(3, 4, 3, 4);
            pnLogin.MinimumSize = new Size(933, 612);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(933, 612);
            pnLogin.TabIndex = 9;
            pnLogin.Paint += pnLogin_Paint;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Maroon;
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 0, 0);
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.ButtonHighlight;
            btnSair.Location = new Point(346, 520);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(105, 48);
            btnSair.TabIndex = 17;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(52, 58, 64);
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 30);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.Control;
            btnEntrar.Location = new Point(513, 520);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(105, 48);
            btnEntrar.TabIndex = 16;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(30, 41, 59);
            txtSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = SystemColors.Window;
            txtSenha.Location = new Point(346, 469);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(268, 27);
            txtSenha.TabIndex = 15;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(30, 41, 59);
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.Window;
            txtUsuario.Location = new Point(346, 424);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(268, 27);
            txtUsuario.TabIndex = 14;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.Transparent;
            lblSenha.Location = new Point(279, 473);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(65, 18);
            lblSenha.TabIndex = 13;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Transparent;
            lblUsuario.Location = new Point(270, 428);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 18);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "Usuário:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = Color.FromArgb(224, 224, 224);
            lblDescricao.Location = new Point(293, 360);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(397, 18);
            lblDescricao.TabIndex = 11;
            lblDescricao.Text = "Para acessar o sistema, digite suas credenciais.";
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoasVindas.ForeColor = Color.FromArgb(224, 224, 224);
            lblBoasVindas.Location = new Point(194, 265);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(609, 89);
            lblBoasVindas.TabIndex = 10;
            lblBoasVindas.Text = "SEJA BEM VINDO!";
            // 
            // pboxLogoHP
            // 
            pboxLogoHP.Image = Properties.Resources.helpbox_removebg_preview;
            pboxLogoHP.Location = new Point(144, -25);
            pboxLogoHP.Margin = new Padding(3, 4, 3, 4);
            pboxLogoHP.Name = "pboxLogoHP";
            pboxLogoHP.Size = new Size(638, 300);
            pboxLogoHP.TabIndex = 9;
            pboxLogoHP.TabStop = false;
            pboxLogoHP.Click += pboxLogoHP_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(1125, 881);
            Controls.Add(tlpLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(1140, 855);
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
