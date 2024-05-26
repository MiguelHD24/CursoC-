using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Producto")]
	public class Producto
	 {
		[Key]
		public int IdProducto { get; set; }
		[MaxLength(50)]
		[Required]
		public string Codigo { get; set; }
		[MaxLength(50)]
		[Required]
		public string Nombre { get; set; }
		[MaxLength(50)]
		[Required]
		public string Descripcion { get; set; }
		[Required]
		public int IdCategoria { get; set; }
		public int? Stock { get; set; }
		public int? PrecioCompra { get; set; }
		public int? PrecioVenta { get; set; }
		[Required]
		public bool Activo { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualiza { get; set; }
	 }
}
