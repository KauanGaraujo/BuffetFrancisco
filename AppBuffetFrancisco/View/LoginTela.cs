using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBuffetFrancisco.View
{
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            // Para fechar a aplicação
            Application.Exit();
        }

        private void txb_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            // Tem uma variavael do tipo texto que recebe da ferramenta textbox
            string usuario = txb_Usuario.Text;
            string senha = txb_Senha.Text;

            // O algiritmo para verificar as credenciais e permitir o acesso
            if (usuario == "admin" && senha == "123")
            {
                // Vai fechar a tela de login e abrir a tela de menu
                this.Hide(); //This -> (este) Hide -> (escode/oculta)
                // Instanciar a tela de menu.
                MenuTela menu = new MenuTela();
                // A tela meu ira fechar, junto com todo a aplicação
                // Porém. irá abrir a tela menu novamente.
                menu.FormClosed += (s, args) => this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Senha ou Usuario incorreto");
            }

















        }
    }
}
