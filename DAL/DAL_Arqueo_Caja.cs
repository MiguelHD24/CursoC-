using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Arqueo_Caja
	{
		 public static Arqueo_Caja Insert (Arqueo_Caja Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 bd.Arqueo_Caja.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Arqueo_Caja Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Arqueo_Caja.Find(Entidad.IdArqueo);
				 Registro.Fecha_arqueo = Entidad.Fecha_arqueo;
				 Registro.Efectivo = Entidad.Efectivo;
				 Registro.Tarjeta_credito = Entidad.Tarjeta_credito;
				 Registro.Transferencia_bancaria = Entidad.Transferencia_bancaria;
				 Registro.Total_ventas = Entidad.Total_ventas;
				 Registro.Diferencia = Entidad.Diferencia;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Arqueo_Caja Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Arqueo_Caja.Find(Entidad.IdArqueo);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Arqueo_Caja Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Arqueo_Caja.Where(a=>a.IdArqueo == Entidad.IdArqueo).Count() > 0;
			}
		}
		 public static Arqueo_Caja Registro (Arqueo_Caja Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Arqueo_Caja.Where(a=>a.IdArqueo == Entidad.IdArqueo).SingleOrDefault();
			}
		}
		 public static List<Arqueo_Caja> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
			}
		}
	}
}
