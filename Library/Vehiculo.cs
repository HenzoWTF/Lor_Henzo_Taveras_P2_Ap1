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

		public int VehiculoId { get; set; }


        [Required(ErrorMessage = "Debe de insertar una Fecha")]
        public DateTime Fecha { get; set;}


        [Required(ErrorMessage = "Debes de insertar una descripción")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Debes de insertar el costo del vehiculo")]
		[Range(1, double.MaxValue, ErrorMessage = "El costo debe ser mayor que 1")]
		public decimal Costo { get; set; }

        public decimal Gastos { get; set; }

        [ForeignKey("VehiculoId")]
        public ICollection<VehiculosDetalle> vehiculosDetalles { get; set; } = new List<VehiculosDetalle>();
    }
}
