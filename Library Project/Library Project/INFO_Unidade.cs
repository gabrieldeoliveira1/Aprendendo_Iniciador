using Library_Project.controle;
using Library_Project.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class INFO_Unidade : Form
    {
        ModeloUnidade unidade = new ModeloUnidade();
        ModeloLivro livro = new ModeloLivro();
        ControleLivro controle = new ControleLivro();
        int codi = 0;
        DataTable nom;
        String nome_livro = "";
        String codi1 = "";

        public INFO_Unidade(ModeloUnidade unidade, ModeloLivro livro)
        {
            codi = unidade.CD_Unidade;
            codi1 = livro.CD_Livro;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void INFO_Unidade_Load(object sender, EventArgs e)
        {
            Conexao cn = new Conexao();
            try
            {
                DataTable dados;
                dados = cn.obterdados("select Table_Livro.Nome_Livro, Table_Unidade.Nome_Unidade, Table_Livro.Descricao_Livro from Table_Livro Inner Join Table_Unidade on Table_Unidade.CD_Unidade = Table_Livro.CFK_Unidade where Table_Livro.CD_Livro = '" + codi1 + "'");

                nom = dados;

                label1.Text = nom.Rows[0]["Nome_Livro"].ToString();
                label3.Text = nom.Rows[0]["Nome_Unidade"].ToString();
                label4.Text = nom.Rows[0]["Descricao_Livro"].ToString();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

