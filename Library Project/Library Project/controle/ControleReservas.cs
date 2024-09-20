using Library_Project.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project.controle
{
    public class ControleReservas
    {
        //chamo o objeto da conexao
        Conexao conexao = new Conexao();


        //metodo para cadastrar 

        public bool registrar_Reserva(ModeloReservas reservas)
        {
            bool resultado = false;
            try
            {
                //inicializar a variavel resultado da opercao
                string sql = "insert into Table_reservas(DT_reserva, DT_previsao_devolucao, CFK_User, CFK_Livro)values(@DT_reserva, @DT_previsao_devolucao, @CFK_User, @CFK_Livro)";
                //monto o valor de atributos da tabela usuario
                string[] campos = {"@DT_reserva", "@DT_previsao_devolucao", "@CFK_User", "@CFK_LIvro" };
                //monto o vetor com os valores do formulario
                string[] valores = {  reservas.DT_reserva, reservas.DT_previsao_devolucao, reservas.CFK_User, reservas.CFK_Livro };
                //testar o insert no banco de dados
                if (conexao.cadastrar_CMD_MYSql(0, campos, valores, sql, "@CD_Reservas") >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }



            return resultado;


        }
    }

}

   

