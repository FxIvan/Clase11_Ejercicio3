using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11_Ejercicio3
{
    public class Municipalidad : ICloneable
    {
        public string NombreMunicipalidad { get; set; }

        public object Clone()
        {
            // Devuelve una copia superficial de Municipalidad (suficiente, ya que solo tiene tipos primitivos)
            return this.MemberwiseClone();
        }
    }

    public class Empleado : ICloneable
    {
        public string Provincia { get; set; }
        public Municipalidad Ciudad { get; set; }

        // 🔸 Clonación superficial
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        // 🔹 Clonación profunda
        public Empleado CloneDeep()
        {
            // Primero clonamos el empleado
            Empleado clon = (Empleado)this.MemberwiseClone();

            // Luego clonamos el objeto interno (Ciudad)
            if (this.Ciudad != null)
            {
                clon.Ciudad = (Municipalidad)this.Ciudad.Clone();
            }

            return clon;
        }
    }
}
