using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BEAN
{
    public class ClienteBEAN
    {
        //propfull ambiguo
        private char genero;

        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        //prop nuevo
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }

        //explicara la diferencia entre prop y propfull
    }
}
