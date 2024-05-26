using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Arqueo_Caja")]
	public class Arqueo_Caja
	 {
		[Key]
		public int IdArqueo { get; set; }
		[Required]
		public DateTime Fecha_arqueo { get; set; }
		[Required]
		public decimal Efectivo { get; set; }
		[Required]
		public decimal Tarjeta_credito { get; set; }
		[Required]
		public decimal Transferencia_bancaria { get; set; }
		[Required]
		public decimal Total_ventas { get; set; }
		[Required]
		public decimal Diferencia { get; set; }
	 }
}
