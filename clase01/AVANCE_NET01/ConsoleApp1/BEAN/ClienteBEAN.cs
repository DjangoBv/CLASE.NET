using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BEAN
{
    //ClienteBean equivale a una tabla 
    public class ClienteBEAN
    {
        //Los datos de aquí, equivalen a los campos
        #region POO
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
        #endregion

        #region METODOS
        //sin parametros
        public string concatenarDatos()
        {
            string concatenado = "";

            concatenado = Nombre + " " + Apellido;

            return concatenado;
        }

        //con parametros
        public string concatenarDatosConParametros(string pNombre, string pApellido)
        {
            string concatenado = "";

            concatenado = pNombre + " " + pApellido;

            return concatenado;
        }
        #endregion

    }
}
