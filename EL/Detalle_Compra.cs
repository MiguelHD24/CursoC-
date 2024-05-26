using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Detalle_Compra")]
	public class Detalle_Compra
	 {
		[Key]
		public int IdDetalleCompra { get; set; }
		[Required]
		public int IdCompra { get; set; }
		[Required]
		public int IdProducto { get; set; }
		[Required]
		public decimal PrecioCompra { get; set; }
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
