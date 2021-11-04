using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbProducto")]
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string NombreProducto { get; set; }

        public List<DetalleVenta> DetalleVenta { get; set; }
    }
}
