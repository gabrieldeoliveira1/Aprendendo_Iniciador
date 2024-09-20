using Library_Project.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project.controle
{
    internal class ClUsercontrole
    {
        Conexao conexao = new Conexao();

        public bool SignUp(ClUserModelo Perfil)
        {
            bool Resultado = false;

            try
            {

                String SQL_Insert = "insert into Table_User(ID_Aluno, Nome_Completo, NameUser, Senha, IMG_User, CFK_Ano, CFK_Cargo)values(@ID_Aluno, @Nome_Completo, @UserName, @Password, @IMG_User, @CFK_Ano, @CFK_Cargo)";

                string[] campos = { "@ID_Aluno", "@Nome_Completo", "@UserName", "@Password", "@IMG_User", "@CFK_Ano", "@CFK_Cargo" };
                //monto o vetor com os valores do formulario
                string[] valores = { Perfil.ID_Aluno.ToString(), Perfil.NomeComp.ToString(), Perfil.UserName.ToString(), Perfil.Password.ToString(), Perfil.Caminho_FT.ToString(), Perfil.Index_Ano.ToString(), Perfil.Index_Cargo.ToString() };

                //testar o insert no banco de dados
                if (conexao.cadastrar_CMD_MYSql(0, campos, valores, SQL_Insert, "@ID_Aluno") >= 1)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


            return Resultado;
        }




    }
}