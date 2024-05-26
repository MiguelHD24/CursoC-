using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Negocio")]
	public class Negocio
	 {
		[Key]
		public int IdNegocio { get; set; }
		[MaxLength(60)]
		[Required]
		public string Nombre { get; set; }
		[MaxLength(60)]
		[Required]
		public string RUC { get; set; }
		[MaxLength(60)]
		[Required]
		public string Direccion { get; set; }
		public byte[]? Logo { get; set; }
	 }
}
