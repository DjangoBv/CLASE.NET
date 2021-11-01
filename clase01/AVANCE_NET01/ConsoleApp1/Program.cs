using ConsoleApp1.BEAN;
using ConsoleApp1.DAO;
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
            #region POO
            ////instanciando clase
            //ClienteBEAN cliBean = new ClienteBEAN();
            //cliBean.Nombre = "Luis";
            //cliBean.Apellido = "Caccha";
            //cliBean.Edad = 22;
            //cliBean.Genero = 'M';
            //cliBean.Carrera = "Ing. Sistemas";

            //ClienteBEAN cliBean2 = new ClienteBEAN();
            //cliBean2.Nombre = "Pierina";
            //cliBean2.Apellido = "Gutierrez";
            //cliBean2.Edad = 23;
            //cliBean2.Genero = 'F';
            //cliBean2.Carrera = "Negocios Internacionales";

            ////Console.WriteLine("Nombre completo del primer cliente: "+cliBean.Nombre + " " + cliBean.Apellido);
            ////Console.WriteLine("Nombre completo del segundo cliente: "+cliBean2.Nombre + " " + cliBean2.Apellido);

            ////Metodos sin parametros
            //Console.WriteLine(cliBean.concatenarDatos());
            //Console.WriteLine(cliBean2.concatenarDatos());
            //Console.WriteLine("---------------------------------------------");

            ////Metodos con parametros
            //Console.WriteLine(cliBean.concatenarDatosConParametros("Nadia", "Caccha"));
            //Console.ReadLine();
            #endregion

            #region LISTA CON TIPO DE DATOS
            ////coleccion de datos
            ////Listas - list
            ////Diccionarios - dictionary
            ////Colas - queue
            ////Pilas - stack

            //List<int> listaNumeros = new List<int>();
            //listaNumeros.Add(1);
            //listaNumeros.Add(20);
            //listaNumeros.Add(300);

            //Console.WriteLine("Listar con 'for'");
            //for (int i = 0; i < listaNumeros.Count; i++)
            //{
            //    Console.WriteLine(listaNumeros[i]);
            //}

            //Console.WriteLine("Listar con 'foreach'");
            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Ejemplo con lista de datos

            //int val = 0;
            //List<int> listaValor = new List<int>();

            //do
            //{
            //    Console.Write("Ingrese un valor (con 0 acaba el programa): ");
            //    val = Convert.ToInt32(Console.ReadLine());
            //    listaValor.Add(val);
            //} while (val != 0);

            //Console.WriteLine("Lista: ");
            //foreach (var item in listaValor)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region LISTA CON CLASES

            ////forma 1 de introducir informacion
            //ClienteBEAN cliBEAN = new ClienteBEAN();
            //cliBEAN.Nombre = "Renato";
            //cliBEAN.Apellido = "Caccha";

            ////forma 2 de introducir informacion
            //ClienteBEAN cliBEAN2 = new ClienteBEAN()
            //{
            //    Nombre="Pierina",
            //    Apellido="Gutierrez"
            //};

            //List<ClienteBEAN> listaCliente = new List<ClienteBEAN>();
            //listaCliente.Add(cliBEAN);
            //listaCliente.Add(cliBEAN2);
            ////agregado informacion defrente a la lista
            //listaCliente.Add(new ClienteBEAN { 
            //    Nombre = "Nadia", 
            //    Apellido = "Caccha" 
            //});

            //foreach (var item in listaCliente)
            //{
            //    Console.WriteLine(item.Nombre + " " + item.Apellido);
            //}

            #endregion

            #region DICCIONARY
            //key - value
            //int val = 0;

            //Dictionary<int, string> datos = new Dictionary<int, string>();
            //datos.Add(1, "Lunes");
            //datos.Add(2, "Martes");
            //datos.Add(3, "Miercoles");
            //datos.Add(4, "Jueves");
            //datos.Add(5, "Viernes");
            //datos.Add(6, "Sabado");
            //datos.Add(7, "Domingo");

            //Console.WriteLine("Ingrese valor: ");
            //val = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("El dia ingresado es: " + datos[val]);

            #endregion

            #region Ejemplo con Diccionario

            int horasTrabajo = 0, horasExtras = 0, costoHoraExtra = 0, costoTotal = 0, codigoTrabajador = 0;
            string nombreTrabajador = "", continuar = "N";

            //Dictionary<int, int> ListacostoExtra = new Dictionary<int, int>();
            ////hora -  costo por hora
            //ListacostoExtra.Add(0, 10);
            //ListacostoExtra.Add(1, 12);
            //ListacostoExtra.Add(2, 12);
            //ListacostoExtra.Add(3, 12);
            //ListacostoExtra.Add(4, 13);
            //ListacostoExtra.Add(5, 13);
            //ListacostoExtra.Add(6, 15);

            Console.WriteLine("----------------------------------");
            //Lista con propiedades de trabajadorBEAN
            List<trabajorBEAN> listTrabajador = new List<trabajorBEAN>();
            do
            {
                //Instancio clase con tipo de varibale trabajadorBEAN (objeto)
                trabajorBEAN trabBEAN = new trabajorBEAN();
                //Instancio clase con tipo de variable trabajadorDAO (objeto)
                trabajadorDAO trabDAO = new trabajadorDAO();
                Console.Write("Codigo del trabajador: ");
                codigoTrabajador = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nombre del trabajador: ");
                nombreTrabajador = Console.ReadLine();
                Console.Write("Ingrese cantidad de horas trabajadas: ");
                horasTrabajo = Convert.ToInt32(Console.ReadLine());

                //if (horasTrabajo > 8)
                //{
                //    horasExtras = horasTrabajo - 8;
                //    costoHoraExtra = ListacostoExtra[horasExtras] * horasExtras;
                //    costoTotal = (8 * ListacostoExtra[0]) + costoHoraExtra;
                //}
                //else
                //{
                //    horasExtras = 0;
                //    costoHoraExtra = 0;
                //    costoTotal = (8 * ListacostoExtra[0]) + horasExtras;
                //}

                //SOLUCION1
                //Console.Write("Cantidad de horas trabajadas: " + horasTrabajo + "\n");
                //Console.Write("Costo de horas normales: " + ListacostoExtra[0] + "\n");
                //Console.Write("Cantidad de horas extras: " + horasExtras + "\n");
                //Console.Write("Costo Horas extras: " + costoHoraExtra + "\n");
                //Console.Write("Costo Total: " + costoTotal + "\n");

                trabBEAN.Codigo = codigoTrabajador;
                trabBEAN.Nombre = nombreTrabajador;
                trabBEAN.HorasTrabajo = horasTrabajo;
                trabBEAN.CostoTotalTrabajadas = trabDAO.calculoHorasExtras(trabBEAN.HorasTrabajo);

                listTrabajador.Add(trabBEAN);

                Console.Write("Desea continuar (Y/N): ");
                continuar = Console.ReadLine();

            } while (continuar=="Y");

            foreach (var item in listTrabajador)
            {
                Console.WriteLine("Codigo: " + item.Codigo + "\t" + "Nombre: " + item.Nombre + "\t" + "Horas de trabajo: " + item.HorasTrabajo + "\t" + "Costo total de horas trabajadas: " + item.CostoTotalTrabajadas);
            }
            #endregion
        }
    }
}
