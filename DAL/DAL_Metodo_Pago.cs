using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Metodo_Pago
	{
		 public static Metodo_Pago Insert (Metodo_Pago Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 bd.Metodo_Pago.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Metodo_Pago Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Metodo_Pago.Find(Entidad.IdMetodoPago);
				 Registro.Nombre = Entidad.Nombre;
				 Registro.Descripcion = Entidad.Descripcion;
				 Registro.Comision = Entidad.Comision;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Metodo_Pago Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 var Registro = bd.Metodo_Pago.Find(Entidad.IdMetodoPago);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Metodo_Pago Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Metodo_Pago.Where(a=>a.IdMetodoPago == Entidad.IdMetodoPago).Count() > 0;
			}
		}
		 public static Metodo_Pago Registro (Metodo_Pago Entidad)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
				 return bd.Metodo_Pago.Where(a=>a.IdMetodoPago == Entidad.IdMetodoPago).SingleOrDefault();
			}
		}
		 public static List<Metodo_Pago> Lista (bool Activo = true)
		{
			 using (BDDBVENTASDEMO bd = new BDDBVENTASDEMO ())
			{
			}
		}
	}
}
