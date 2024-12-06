using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keythi.Prototipos.Ejercicio2.DatosDeUnAuto
{
    internal class DatosDeUnAutoModelo
    {
        public string IngresarAuto(Auto auto)
        {
            if(string.IsNullOrWhiteSpace(auto.Modelo))
            {
                return "El modelo es requerido";
            }
            if(auto.Modelo.Length > 30)
            {
                return "El modelo debe tener un maximo de 30 caracteres";
            }

            if(auto.Año < 2000 || auto.Año > 2021)
            {
                return "EL año debe estar entre 2000 y 2021";
            }

           if(auto.Precio <= 0)
           {
                return "El precio debe ser mayor a 0";
           }

            return null;
        }
    }
}
