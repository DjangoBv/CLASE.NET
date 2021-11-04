using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbPersona")]
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }
        //nivel de validaciones
        [Required]
        [StringLength(50)]
        //nivel de esquema
        [Column("NombrePersona", TypeName ="varchar")]
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public int IdTipoDoc { get; set; }

        public TipoDocumento TipoDocumento { get; set; }
    }
}
