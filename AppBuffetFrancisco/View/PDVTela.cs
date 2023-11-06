using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Schema;

namespace AppBuffetFrancisco.View
{
    public partial class PdvTela : Form
    {
        int totalfinal = 0;
        public PdvTela()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_coxinha_Click(object sender, EventArgs e)
        {
            string registroscoxinha = btn_coxinha.Text = "1";
            textBox1.Text = registroscoxinha;

        }

        private void btn_pao_Click(object sender, EventArgs e)
        {
            string paoqueijo = btn_pao.Text = "2";
            textBox1.Text = paoqueijo;
        }

        private void btn_esfilha_Click(object sender, EventArgs e)
        {
            string registroesfirra = btn_esfilha.Text = "3";
            textBox1.Text = registroesfirra;
        }

        private void btn_pastel_Click(object sender, EventArgs e)
        {
            string registropastel = btn_pastel.Text = "4";
            textBox1.Text = registropastel;
        }

        private void btn_suco_Click(object sender, EventArgs e)
        {
            string registrosuco = btn_suco.Text = "5";
            textBox1.Text = registrosuco;
        }

        private void btn_refri_Click(object sender, EventArgs e)
        {
            string registrorefri = btn_refri.Text = "6";
            textBox1.Text = registrorefri;
        }

        private void btn_sucos_Click(object sender, EventArgs e)
        {
            string registrosucos = btn_sucos.Text = "7";
            textBox1.Text = registrosucos;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            int qtd = ((int)numericUpDown1.Value);


            string[] itens = { "Coxinha", "Pão de Queijo", "Esfirra", "Pastel", "Suco", "Refrigerante", "Sucos" };
            int[] valor = { 8, 7, 8, 8, 12, 10, 12 };

            int total = qtd * valor[codigo - 1];

            totalfinal += total;

            dataGridView1.Rows.Add(itens[codigo - 1], qtd, valor[codigo - 1], total);



            lbl_valortotal.Text = totalfinal.ToString();







        }

        private void lbl_valortotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_valortotal.Text = String.Empty;
            textBox1.Text = String.Empty;
            numericUpDown1.Value = 0;
            dataGridView1.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            TelaFechaVenda tela = new TelaFechaVenda();
            tela.Show();
        }
    }
}
