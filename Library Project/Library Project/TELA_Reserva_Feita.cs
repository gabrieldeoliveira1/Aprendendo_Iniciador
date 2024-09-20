using Library_Project.controle;
using Library_Project.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class TELA_Reserva_Feita : Form
    {
        ModeloUnidade model = new ModeloUnidade();
        ClUsercontrole user = new ClUsercontrole();
        ModeloLivro ModeloLivro = new ModeloLivro();

        Conexao cn = new Conexao();
        string codi = "";
        string codigo = "";
        string cod1 = "";
        public TELA_Reserva_Feita(ClUserModelo user, ModeloLivro modelolivro, ModeloUnidade mduni)
        {
            codigo = modelolivro.CD_Livro;
            cod1 = mduni.CD_Unidade.ToString();
            codi = user.CD_User.ToString();
            InitializeComponent();
        }

        private void TELA_Reserva_Feita_Load(object sender, EventArgs e)
        {

            try
            {
                DataTable unidade;
                unidade = cn.obterdados("Select * from Table_Unidade where CD_Unidade = '" + cod1 + "'");
                label6.Text = unidade.Rows[0]["Nome_Unidade"].ToString();
                label7.Text = unidade.Rows[0]["Local_Unidade"].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Unit: " + ex.Message);
            }
            try
            {
                DataTable livro;

                livro = cn.obterdados("Select * from Table_Livro where CD_Livro = '" + codigo + "'");
                label4.Text = livro.Rows[0]["Nome_Livro"].ToString();
                label5.Text = livro.Rows[0]["CD_Livro"].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Livro: " + ex.Message);
            }

            try
            {
                DataTable dados_aluno;
                dados_aluno = cn.obterdados("Select * from Table_User where CD_User = '" + codi + "'");

                label1.Text = dados_aluno.Rows[0]["ID_Aluno"].ToString();
                label2.Text = dados_aluno.Rows[0]["NameUser"].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Livro: " + ex.Message);
            }


            try
            {
                //Pegando data atual
                String dia = DateTime.Now.Day.ToString();
                String mon = DateTime.Now.Month.ToString();
                String ano = DateTime.Now.Year.ToString(); ;
                String hora = DateTime.Now.Hour.ToString();
                String minutos = DateTime.Now.Minute.ToString();
                String seg = DateTime.Now.Second.ToString();

                string data_Hoje = ano + "-" + mon + "-" + dia + " " + hora + ":" + minutos + ":" + seg;

                //obterdados das informações de data da reserva.


                DataTable dados_data;
                DataTable DT_Pegar = cn.obterdados("select * from Table_reservas");
                if (DT_Pegar.Rows.Count > 0)
                {
                    dados_data = cn.obterdados($"Select ABS(DATEDIFF('{data_Hoje}', DT_previsao_devolucao)) - 1 AS dias_faltando from Table_reservas where CD_Reservas = {DT_Pegar.Rows.Count}");
                    label3.Text = dados_data.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DATA: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCatalogo cat = new FrmCatalogo();
            this.Hide();
            cat.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();   
        }
    }
}
