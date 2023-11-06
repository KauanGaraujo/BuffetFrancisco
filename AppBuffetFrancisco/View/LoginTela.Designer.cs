namespace AppBuffetFrancisco.View
{
    partial class LoginTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            label2 = new Label();
            label3 = new Label();
            txb_Usuario = new TextBox();
            txb_Senha = new TextBox();
            btn_Acessar = new Button();
            groupBox1 = new GroupBox();
            btn_Sair = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(75, 36);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(89, 82);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // txb_Usuario
            // 
            txb_Usuario.Location = new Point(167, 32);
            txb_Usuario.Name = "txb_Usuario";
            txb_Usuario.Size = new Size(100, 29);
            txb_Usuario.TabIndex = 3;
            txb_Usuario.Text = "admin";
            // 
            // txb_Senha
            // 
            txb_Senha.Location = new Point(167, 78);
            txb_Senha.Name = "txb_Senha";
            txb_Senha.PasswordChar = '*';
            txb_Senha.Size = new Size(100, 29);
            txb_Senha.TabIndex = 4;
            txb_Senha.Text = "123";
            txb_Senha.TextChanged += txb_Senha_TextChanged;
            // 
            // btn_Acessar
            // 
            btn_Acessar.BackColor = SystemColors.ButtonHighlight;
            btn_Acessar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Acessar.Location = new Point(145, 125);
            btn_Acessar.Name = "btn_Acessar";
            btn_Acessar.Size = new Size(139, 36);
            btn_Acessar.TabIndex = 5;
            btn_Acessar.Text = "Acessar";
            btn_Acessar.UseVisualStyleBackColor = false;
            btn_Acessar.Click += btn_Acessar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(btn_Sair);
            groupBox1.Controls.Add(btn_Acessar);
            groupBox1.Controls.Add(txb_Senha);
            groupBox1.Controls.Add(txb_Usuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(316, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 256);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credenciais";
            // 
            // btn_Sair
            // 
            btn_Sair.BackColor = SystemColors.ButtonHighlight;
            btn_Sair.Location = new Point(301, 213);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(73, 31);
            btn_Sair.TabIndex = 6;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = false;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MicrosoftTeams_image__6_;
            pictureBox1.Location = new Point(12, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LoginTela
            // 
            AcceptButton = btn_Acessar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton = btn_Sair;
            ClientSize = new Size(770, 280);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de PDV Buffet Francisco";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txb_Usuario;
        private TextBox txb_Senha;
        private Button btn_Acessar;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btn_Sair;
    }
}