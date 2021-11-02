using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BEAN
{
    public class usuarioBEAN
    {
        //7 campos
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int AñoNacimiento { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public double Dinero { get; set; }
    }
}
