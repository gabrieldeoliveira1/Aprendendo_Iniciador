using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project.modelo
{
    public class ModeloUnidade
    {

    
    //declaro as variaveis do sistema com relacao ao banco de dados
    public int CD_Unidade;
    public string Nome_Unidade;
    public string Local_Unidade;
    public string IMG_Unidade;
    public string Descricao_Retirada;

    public ModeloUnidade()
    {

            //iniciar as variaveis zeradas

        CD_Unidade = 0;
        Nome_Unidade = "";
        Local_Unidade = "";
        IMG_Unidade = "";
        Descricao_Retirada = "";


    }
}
  

}
