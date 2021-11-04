using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbCliente")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string NombreCliente { get; set; }

        public List<Venta> Venta { get; set; }
    }
}
