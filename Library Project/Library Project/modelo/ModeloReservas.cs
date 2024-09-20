using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project.modelo
{
    public class ModeloReservas
    {

        //declaro as variaveis do sistema com relacao ao banco de dados
        public int CD_Reservas;
        public string DT_reserva;
        public string DT_previsao_devolucao;
        public string CFK_User;
        public string CFK_Livro;

        public ModeloReservas()
        {

            //iniciar as variaveis zeradas

            CD_Reservas = 0;
            DT_reserva = "";
            DT_previsao_devolucao = "";
            CFK_User = "";
            CFK_Livro = "";


        }
    }


}