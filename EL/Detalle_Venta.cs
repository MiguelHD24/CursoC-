using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Detalle_Venta")]
	public class Detalle_Venta
	 {
		[Key]
		public int IdDetalleVenta { get; set; }
		[Required]
		public int IdVenta { get; set; }
		[Required]
		public int IdProducto { get; set; }
		[Required]
		public decimal PrecioVenta { get; set; }
		[Required]
		public int Cantidad { get; set; }
		[Required]
		public decimal SubTotal { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
	 }
}
