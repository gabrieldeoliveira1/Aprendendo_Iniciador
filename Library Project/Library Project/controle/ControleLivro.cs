using Library_Project.modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project.controle
{
    //Controle de usuario 
    public class ControleLivro
    {
        //chamo o objeto da conexao
        Conexao con = new Conexao();


        //metodo para cadastrar 
        //Esse cadastrar é apenas demostrativo (SEM UTILIDADE PRATICA)
        public bool cadastrar_Livro(ModeloLivro livro)
        {
            bool resultado = false;
            try
            {
                //inicializar a variavel resultado da opercao
                string sql = "insert into livro(Nome_Livro, QTD_Estoque, Numb_Paginas, Edicao_Livro, IMG_Livro, Descricao_Livro)values(@Nome_Livro, @QTD_Estoque, @Numb_Paginas, @Edicao_Livro, @IMG_Livro, @Descricao_Livro)";
                //monto o valor de atributos da tabela usuario
                string[] campos = { "@Nome_Livro", "@QTD_Estoque", "@Numb_Paginas", "@Edicao_Livro", "@IMG_Livro", "@Descricao_Livro" };
                //monto o vetor com os valores do formulario
                string[] valores = { livro.Nome_Livro, livro.QTD_estoque.ToString(), livro.Numb_Paginas.ToString(), livro.Edicao_Livro.ToString(), livro.IMG_Livro, livro.Descricao_Livro };
                //testar o insert no banco de dados
                if (con.cadastrar_CMD_MYSql(0, campos, valores, sql, "@CD_Livro") >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            


            return resultado;

     
        }
    }
}
