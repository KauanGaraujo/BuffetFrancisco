using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBuffetFrancisco.View
{
    public partial class MenuTela : Form
    {
        public MenuTela()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciand a tela PDVtela
            
            //tipo objeto    classe
            PdvTela PDV = new PdvTela();
           
            // Mostra a tela PdvTela
            // PdvTela é um objeto
            PDV.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pata fechar a aplicação
            Application.Exit();
        }
    }
}
