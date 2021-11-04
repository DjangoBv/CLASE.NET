using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbVenta")]
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        public int IdCliente { get; set; }

        public List<DetalleVenta> DetalleVenta { get; set; }
        public Cliente Cliente { get; set; }
    }
}
