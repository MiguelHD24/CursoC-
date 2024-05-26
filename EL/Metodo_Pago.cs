using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Metodo_Pago")]
	public class Metodo_Pago
	 {
		[Key]
		public int IdMetodoPago { get; set; }
		[MaxLength(50)]
		[Required]
		public string Nombre { get; set; }
		[MaxLength(255)]
		[Required]
		public string Descripcion { get; set; }
		[Required]
		public decimal Comision { get; set; }
	 }
}
