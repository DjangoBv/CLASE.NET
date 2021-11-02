using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1.DAO
{
    public class usuarioDAO
    {
        //usuBEAN.AñoNacimiento=pAñoNacimiento
        public double CalcularAumento(int pAñoNacimiento)
        { 
            double resultado, calculoDinero=0;
            Dictionary<int, double> listaAumentoDinero = new Dictionary<int, double>();
            listaAumentoDinero.Add(1999, 20);
            listaAumentoDinero.Add(2000, 20);
            listaAumentoDinero.Add(2001, 20);
            listaAumentoDinero.Add(2002, 40);
            listaAumentoDinero.Add(2003, 40);
            listaAumentoDinero.Add(2004, 50);

            if (pAñoNacimiento >=1999 && pAñoNacimiento < 2005)
            {
                calculoDinero =  (930 * (listaAumentoDinero[pAñoNacimiento] / 100)) +930;
            }
            else
            {
                Console.WriteLine("ERROR valor ingresado!!!");
            }
            resultado = calculoDinero;
            return resultado;
        }
       
    }
}
