using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Categoria")]
	public class Categoria
	 {
		[Key]
		public int IdCategoria { get; set; }
		[MaxLength(100)]
		[Required]
		public string Descripcion { get; set; }
		[Required]
		public bool Activo { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualiza { get; set; }
	 }
}
