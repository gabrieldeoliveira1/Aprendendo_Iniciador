using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library_Project
{
    public class Conexao
    {
        static private string servidor = "sql10.freemysqlhosting.net";
        //nome do bd
        static private string DB = "sql10731213";
        //usuario bd
        static private string usuario = "sql10731213";
        //senha de acesso ao bd
        static private string senhas = "ITTmkP4d2a";
        //variavel de conexao ao bd
        public MySqlConnection conn = null;
        //caminho da conexao ao bd
        static private string StrConexao = "server=" + servidor + ";database=" + DB + ";userid=" + usuario + ";password=" + senhas;


        //Metodo de conexao
        public MySqlConnection getConexao()
        {
            //cria uma conexao ao bd
            conn = new MySqlConnection(StrConexao);
            //retorna a conexao estabelecida;
            return conn;
        }

        //metodo de cadastro de livro
        //variavel "campos" sao os atributos da entidade
        //variavel "valores" sao os conteudos preenchidos no form
        //variavel sql é o comando a ser realizado
        public int cadastrar_CMD_MYSql(int codigo, string[] campos, object[] valores, string SQL, String PK_Table)
        {

            //VALIDACAO DO SCRIPT
            int registro = 0;


            try
            {
                //atribuir a conexao obtida

                conn = getConexao();
                //Abre a conexao
                conn.Open();
                //Prepara a execução do SQL
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                //monto o script sql
                //pegar os campos do vetor
                for (int i = 0; i < valores.Length; i++)
                {
                    //monta a lista de parametros juntando os campos e valores
                    //pega os valores do formulario com os campos do bd
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }

                if (registro > 0)
                {
                    //se o codigo existir no registro, sera substituido aqui para execução
                    cmd.Parameters.AddWithValue(PK_Table, codigo);
                }

                //executa o script sql
                registro = cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return registro;

        }


        public DataTable obterdados(string sql)
        {
            //cria uma tabela de dados
            DataTable dt = new DataTable();
            conn = getConexao();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //monto a estrutura das informações obtidas
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
            //adiciona à datatable os valores
            adpt.Fill(dt);
              
            conn.Close();
            return dt;

        }

        }







    }



