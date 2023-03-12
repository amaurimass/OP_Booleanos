using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_OP_Booleanos
{
    public class Exercicio01_OP_Booleanos

    {
        public static void Main()

        {
            int convidadosNoivo = 300;
            int convidadosNoiva = 600;
            int convidadospresentesNoivo = 400;
            int convidadospresentesNoiva = 400;

            if (convidadosNoiva > convidadosNoivo && convidadosNoivo >= convidadosNoiva || convidadosNoivo < convidadosNoiva)
                Console.WriteLine("O numero de convidados da noiva e maior que do noivo");

            if (convidadosNoivo < convidadosNoiva || convidadosNoivo != convidadosNoiva || convidadosNoivo <= convidadosNoiva)
                Console.WriteLine("O numero de convidados da noivo e menor que do noiva");

            if (convidadospresentesNoivo > convidadosNoivo || convidadospresentesNoiva > convidadosNoiva)
                Console.WriteLine("Existem penetras pois o numero convidados presentes é maior que o numero de convidados do noivo ou da noiva.");

            if (convidadospresentesNoiva == convidadospresentesNoivo)
                Console.WriteLine("O número de convidados do noivo é igual ao número de convidados da noiva");
        }

    }
}
