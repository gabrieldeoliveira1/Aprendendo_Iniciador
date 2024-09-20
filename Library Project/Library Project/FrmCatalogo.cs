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
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();    
            DataTable dt = new DataTable();
            dt = conexao.obterdados("Select * from Table_Livro");
            int registros = 0; //obter o numero de registros
            int x = 0, y = 0; //definir posição x e y da folha
            for(registros = 0; registros < dt.Rows.Count ; registros++)
            {
                //novo painel
                Panel livros = new Panel();
                livros.BorderStyle = BorderStyle.FixedSingle;
                livros.Location = new Point(x, y);
                //definir o tamanho do quadro
                livros.Height = 300;
                livros.Width = 200;
                //criando os objetos manualmente
                Label idlivro = new Label();
                idlivro.Name = "CD_Livro";
                idlivro.Text = dt.Rows[registros]["CD_Livro"].ToString();
                idlivro.Location = new Point(20, 10);

                Label nome_livro = new Label();
                nome_livro.Name = "Nome_Livro";
                nome_livro.Text = dt.Rows[registros]["Nome_Livro"].ToString();
                nome_livro.Location = new Point(20, 35); 

                Label autor = new Label();
                autor.Name = "Autor_Livro";
                autor.Text = dt.Rows[registros]["Autor_Livro"].ToString();
                autor.Location = new Point(20, 70);

                /*
                 * Pegando a foto do banco.
                PictureBox foto = new PictureBox();
                foto.Location = new Point(20, 140);
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][2].ToString());
                */

                Button consultar = new Button();
                consultar.Name = "consultar";
                consultar.Text = "Consultar";
                consultar.Location = new Point(25, 105);

                livros.Controls.Add(idlivro);
                livros.Controls.Add(nome_livro);
                livros.Controls.Add(autor);

                flowLayoutPanel1.Controls.Add(livros);
             

            }
        }
    }
}
