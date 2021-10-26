using ConsoleApp1.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteBEAN cliBean = new ClienteBEAN();
            cliBean.Nombre = "Luis";
            cliBean.Apellido = "Caccha";
            cliBean.Edad = 22;
            cliBean.Genero = 'M';
            cliBean.Carrera = "Ing. Sistemas";

            Console.WriteLine(cliBean.Nombre + " " + cliBean.Apellido);
            Console.ReadLine();

        }
    }
}
