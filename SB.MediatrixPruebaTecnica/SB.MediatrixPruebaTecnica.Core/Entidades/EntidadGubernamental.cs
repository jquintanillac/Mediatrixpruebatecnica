using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.MediatrixPruebaTecnica.Core.Dominio
{
    [Table("EntidadGubernamental")]
    public class EntidadGubernamental
    {
        [Key]
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Direccion { get; set; }
        public required string Telefono { get; set; }
    }
}
