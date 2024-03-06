using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Vehiculo
    {
        [Key]

        [Required(ErrorMessage = "Debes de insertar un Id")]
        public int VehiculoId { get; set; }


        [Required(ErrorMessage = "Debe de insertar una Fecha")]
        public DateTime Fecha { get; set;}


        [Required(ErrorMessage = "Debes de insertar una descripción")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Debes de insertar el costo del vehiculo")]
        public decimal? Costo { get; set; }

        public decimal Gastos { get; set; }

        [ForeignKey("DetalleId")]
        public ICollection<VehiculosDetalle> vehiculosDetalles { get; set; } = new HashSet<VehiculosDetalle>();
    }
}
