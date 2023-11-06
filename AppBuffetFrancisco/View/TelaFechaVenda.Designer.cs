namespace AppBuffetFrancisco.View
{
    partial class TelaFechaVenda
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(269, 44);
            label1.Name = "label1";
            label1.Size = new Size(257, 32);
            label1.TabIndex = 0;
            label1.Text = "Francisco Evento LTDA.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(229, 138);
            label2.Name = "label2";
            label2.Size = new Size(328, 32);
            label2.TabIndex = 1;
            label2.Text = "Rua da Alegria. 171 -SBC - SP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(246, 89);
            label3.Name = "label3";
            label3.Size = new Size(297, 32);
            label3.TabIndex = 2;
            label3.Text = "CNPJ : 12.321.958/0001-00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(110, 195);
            label4.Name = "label4";
            label4.Size = new Size(117, 30);
            label4.TabIndex = 3;
            label4.Text = "00/00/0000";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(346, 195);
            label5.Name = "label5";
            label5.Size = new Size(79, 30);
            label5.TabIndex = 4;
            label5.Text = "235959";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(483, 195);
            label6.Name = "label6";
            label6.Size = new Size(98, 30);
            label6.TabIndex = 5;
            label6.Text = "CCF 0001";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(624, 195);
            label7.Name = "label7";
            label7.Size = new Size(111, 30);
            label7.TabIndex = 6;
            label7.Text = "COD: 0001";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(275, 260);
            label8.Name = "label8";
            label8.Size = new Size(77, 30);
            label8.TabIndex = 7;
            label8.Text = "TOTAL:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(434, 260);
            label9.Name = "label9";
            label9.Size = new Size(92, 30);
            label9.TabIndex = 8;
            label9.Text = "R$ 00,00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(275, 328);
            label10.Name = "label10";
            label10.Size = new Size(251, 30);
            label10.TabIndex = 9;
            label10.Text = "PAGAMENTO RECEBIDO";
            // 
            // TelaFechaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFechaVenda";
            Text = "TelaFechaVenda";
            Load += TelaFechaVenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}