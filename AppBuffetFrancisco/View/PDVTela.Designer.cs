namespace AppBuffetFrancisco.View
{
    partial class PdvTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdvTela));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_pastel = new Button();
            btn_esfilha = new Button();
            btn_pao = new Button();
            btn_coxinha = new Button();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btn_sucos = new Button();
            btn_refri = new Button();
            btn_suco = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button8 = new Button();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            prod = new DataGridViewTextBoxColumn();
            qtd = new DataGridViewTextBoxColumn();
            unu = new DataGridViewTextBoxColumn();
            tot = new DataGridViewTextBoxColumn();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            lbl_valortotal = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(361, 30);
            label1.Name = "label1";
            label1.Size = new Size(385, 32);
            label1.TabIndex = 0;
            label1.Text = "BUFFET FRANCISCO - CARDAPIO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_pastel);
            groupBox1.Controls.Add(btn_esfilha);
            groupBox1.Controls.Add(btn_pao);
            groupBox1.Controls.Add(btn_coxinha);
            groupBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(54, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 203);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btn_pastel
            // 
            btn_pastel.Image = Properties.Resources.MicrosoftTeams_image__10_;
            btn_pastel.Location = new Point(209, 121);
            btn_pastel.Name = "btn_pastel";
            btn_pastel.Size = new Size(83, 68);
            btn_pastel.TabIndex = 3;
            btn_pastel.UseVisualStyleBackColor = true;
            btn_pastel.Click += btn_pastel_Click;
            // 
            // btn_esfilha
            // 
            btn_esfilha.Image = Properties.Resources.MicrosoftTeams_image__9_;
            btn_esfilha.Location = new Point(15, 121);
            btn_esfilha.Name = "btn_esfilha";
            btn_esfilha.Size = new Size(80, 68);
            btn_esfilha.TabIndex = 2;
            btn_esfilha.UseVisualStyleBackColor = true;
            btn_esfilha.Click += btn_esfilha_Click;
            // 
            // btn_pao
            // 
            btn_pao.Image = Properties.Resources.MicrosoftTeams_image__7_;
            btn_pao.Location = new Point(209, 21);
            btn_pao.Name = "btn_pao";
            btn_pao.Size = new Size(83, 67);
            btn_pao.TabIndex = 1;
            btn_pao.UseVisualStyleBackColor = true;
            btn_pao.Click += btn_pao_Click;
            // 
            // btn_coxinha
            // 
            btn_coxinha.Image = Properties.Resources.MicrosoftTeams_image__8_;
            btn_coxinha.Location = new Point(15, 21);
            btn_coxinha.Name = "btn_coxinha";
            btn_coxinha.Size = new Size(80, 67);
            btn_coxinha.TabIndex = 0;
            btn_coxinha.UseVisualStyleBackColor = true;
            btn_coxinha.Click += btn_coxinha_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 130);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 2;
            label2.Text = "PRODUTOS";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_sucos);
            groupBox2.Controls.Add(btn_refri);
            groupBox2.Controls.Add(btn_suco);
            groupBox2.Location = new Point(12, 411);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btn_sucos
            // 
            btn_sucos.Image = Properties.Resources.MicrosoftTeams_image__12_;
            btn_sucos.Location = new Point(309, 22);
            btn_sucos.Name = "btn_sucos";
            btn_sucos.Size = new Size(72, 65);
            btn_sucos.TabIndex = 2;
            btn_sucos.UseVisualStyleBackColor = true;
            btn_sucos.Click += btn_sucos_Click;
            // 
            // btn_refri
            // 
            btn_refri.Image = Properties.Resources.MicrosoftTeams_image__11_;
            btn_refri.Location = new Point(170, 22);
            btn_refri.Name = "btn_refri";
            btn_refri.Size = new Size(69, 65);
            btn_refri.TabIndex = 1;
            btn_refri.UseVisualStyleBackColor = true;
            btn_refri.Click += btn_refri_Click;
            // 
            // btn_suco
            // 
            btn_suco.Image = Properties.Resources.MicrosoftTeams_image__14_;
            btn_suco.Location = new Point(20, 22);
            btn_suco.Name = "btn_suco";
            btn_suco.Size = new Size(70, 65);
            btn_suco.TabIndex = 0;
            btn_suco.UseVisualStyleBackColor = true;
            btn_suco.Click += btn_suco_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MicrosoftTeams_image__6_2;
            pictureBox1.Location = new Point(227, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 387);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 5;
            label3.Text = "BEBIDAS";
            // 
            // button8
            // 
            button8.Location = new Point(928, 180);
            button8.Name = "button8";
            button8.Size = new Size(96, 32);
            button8.TabIndex = 6;
            button8.Text = "Adicionar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(586, 184);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 7;
            label4.Text = "Código";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(665, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(72, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { prod, qtd, unu, tot });
            dataGridView1.Location = new Point(586, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(438, 229);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // prod
            // 
            prod.HeaderText = "Produtos";
            prod.Name = "prod";
            // 
            // qtd
            // 
            qtd.HeaderText = "Qtds";
            qtd.Name = "qtd";
            // 
            // unu
            // 
            unu.HeaderText = "Unitario";
            unu.Name = "unu";
            // 
            // tot
            // 
            tot.HeaderText = "Total";
            tot.Name = "tot";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(842, 186);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(44, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(793, 184);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 11;
            label5.Text = "Qtd";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(552, 496);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 12;
            label6.Text = "Valor Total";
            // 
            // lbl_valortotal
            // 
            lbl_valortotal.BackColor = SystemColors.AppWorkspace;
            lbl_valortotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_valortotal.Location = new Point(937, 490);
            lbl_valortotal.Name = "lbl_valortotal";
            lbl_valortotal.Size = new Size(78, 37);
            lbl_valortotal.TabIndex = 13;
            lbl_valortotal.Text = "R$:00";
            lbl_valortotal.TextAlign = ContentAlignment.MiddleCenter;
            lbl_valortotal.Click += lbl_valortotal_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(700, 500);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(809, 500);
            button2.Name = "button2";
            button2.Size = new Size(77, 24);
            button2.TabIndex = 15;
            button2.Text = "FINALIZAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PdvTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 590);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_valortotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button8);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PdvTela";
            Text = "PdvTela";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btn_pastel;
        private Button btn_esfilha;
        private Button btn_pao;
        private Button btn_coxinha;
        private Label label2;
        private GroupBox groupBox2;
        private Button btn_sucos;
        private Button btn_refri;
        private Button btn_suco;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button8;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn prod;
        private DataGridViewTextBoxColumn qtd;
        private DataGridViewTextBoxColumn unu;
        private DataGridViewTextBoxColumn tot;
        private Label lbl_valortotal;
        private Button button1;
        private Button button2;
    }
}