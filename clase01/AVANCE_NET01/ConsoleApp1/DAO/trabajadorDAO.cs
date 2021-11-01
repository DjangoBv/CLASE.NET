using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DAO
{
    public class trabajadorDAO
    {
         public int calculoHorasExtras( int pHoras)
        {
            Dictionary<int, int> ListacostoExtra = new Dictionary<int, int>();
            //hora -  costo por hora
            ListacostoExtra.Add(0, 10);
            ListacostoExtra.Add(1, 12);
            ListacostoExtra.Add(2, 12);
            ListacostoExtra.Add(3, 12);
            ListacostoExtra.Add(4, 13);
            ListacostoExtra.Add(5, 13);
            ListacostoExtra.Add(6, 15);
            int resultado = 0, horasExtras=0, costoHoraExtra = 0, costoTotal = 0;

            if (pHoras > 8)
            {
                horasExtras = pHoras - 8;
                costoHoraExtra = ListacostoExtra[horasExtras] * horasExtras;
                costoTotal = (8 * ListacostoExtra[0]) + costoHoraExtra;
            }
            else
            {
                horasExtras = 0;
                costoHoraExtra = 0;
                costoTotal = (8 * ListacostoExtra[0]) + horasExtras;
            }
            resultado = costoTotal;
            return resultado;
        }
    }
}
