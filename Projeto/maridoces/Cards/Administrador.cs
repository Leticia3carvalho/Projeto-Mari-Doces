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
    public partial class Administrador : UserControl
    {
        public Administrador()
        {
            InitializeComponent();

            dgv_centraladm.DataSource = ProdutosDAL.ListarTodosOsProdutosDataTable();
        }

        private void btn_NovoProduto_Click(object sender, EventArgs e)
        {
            NovoProduto novoProduto = new NovoProduto();
            novoProduto.ShowDialog();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            dgv_centraladm.DataSource = ProdutosDAL.ListarTodosOsProdutosDataTable();
        }
    }
}
