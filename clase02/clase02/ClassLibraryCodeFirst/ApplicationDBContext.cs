using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    public class ApplicationDBContext : DbContext
    {
        //Genero el constructor del ApplicationDBContext -> (), y lo uno con mi cadena de conexion
        public ApplicationDBContext() : base("connBD")
        {

        }
        //Persona es un nombre indistinto que no se verá reflejado
        public DbSet<Persona> Persona { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
