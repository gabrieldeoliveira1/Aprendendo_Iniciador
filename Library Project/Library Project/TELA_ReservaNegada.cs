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
    public partial class TELA_ReservaNegada : Form
    {
        ModeloLivro modeloLivro = new ModeloLivro();
        ClUsercontrole user = new ClUsercontrole();
        ModeloLivro ModeloLivro = new ModeloLivro();
        ClUserModelo clUser = new ClUserModelo();

        Conexao cn = new Conexao();
        string codi = "";
        public TELA_ReservaNegada(ClUserModelo user)
        {
            codi = user.ID_Aluno;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TELA_ReservaNegada_Load(object sender, EventArgs e)
        {
            DataTable dados_user = new DataTable();
            dados_user = cn.obterdados("Select * from Table_User where ID_Aluno = '" + codi + "'");

            label1.Text = dados_user.Rows[0]["ID_Aluno"].ToString();
            label2.Text = dados_user.Rows[0]["NameUser"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCatalogo cat = new FrmCatalogo();
            this.Hide();
            cat.ShowDialog();
        }
    }
}
