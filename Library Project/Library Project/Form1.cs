using Library_Project.modelo;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form1 : Form
    {
        ModeloLivro modeloLivro = new ModeloLivro();
        ModeloUnidade unidade = new ModeloUnidade();
        ModeloReservas Modeloreserva = new ModeloReservas();
        ClUserModelo clUser = new ClUserModelo();
        Conexao cn = new Conexao();
        public Form1()

        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //passou o valor selecionado fixo
            modeloLivro.CD_Livro = comboBox1.Text;
            // modeloLivro.CD_Livro = "320C111L2021";
            DataTable dt_unit = cn.obterdados("Select * from Table_Livro where Order_Livro = '" + (comboBox1.SelectedIndex + 1).ToString() + "'");
            modeloLivro.Index_Unidade = (int)dt_unit.Rows[0]["CFK_Unidade"];
            unidade.CD_Unidade = modeloLivro.Index_Unidade;
            INFO_Livro info = new INFO_Livro(modeloLivro, clUser, unidade);
            info.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // isso é apenas para teste 
            DataTable dt_unit = cn.obterdados("Select * from Table_Livro where Order_Livro = '" + (comboBox1.SelectedIndex + 1).ToString() + "'");
            //continuação
            modeloLivro.Index_Unidade = (int)dt_unit.Rows[0]["CFK_Unidade"];
            unidade.CD_Unidade = modeloLivro.Index_Unidade;
            modeloLivro.CD_Livro = comboBox1.Text;

            INFO_Unidade info = new INFO_Unidade(unidade, modeloLivro);
            info.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.DataSource = cn.obterdados("Select CD_Livro, Nome_Livro from Table_Livro");
                //livro.Descricao_Livro = dados.Rows[0][7].ToString();
                comboBox1.DisplayMember = "CD_Livro";
                comboBox1.ValueMember = "Nome_Livro";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
