using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maridoces.conexao;

namespace maridoces
{
    public partial class NovoProduto : Form
    {
        public NovoProduto()
        {
            InitializeComponent();

            cbx_sabor.DataSource = SaborDAL.ListarTodosOsSabores(); // lista la no combo box como o tipo, "system.etc"
            cbx_sabor.DisplayMember = "nome_sabor"; //tabela de nomes que vai aparecer na combo box, nome que aparece
            cbx_sabor.ValueMember = "id_sabor"; //pegar informaçã

            cbx_categoria.DataSource = CategoriaDAL.ListarTodosAsCategorias(); // lista la no combo box como o tipo, "system.etc"
            cbx_categoria.DisplayMember = "nome_categoria"; //tabela de nomes que vai aparecer na combo box, nome que aparece
            cbx_categoria.ValueMember = "id_categoria"; //pegar informação de qual coluna, id que vai fazer a busca no banco de dados 
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_sabor_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {







            txt_nomeProduto.Text = "";
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
