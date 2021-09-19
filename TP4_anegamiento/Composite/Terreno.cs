using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_anegamiento.Composite
{
   public abstract class Terreno
    {
        public Terreno(int Pfraccion)
        {
            _fraccion = Pfraccion;
        }
        public int fraccion { get { return _fraccion; } }
        private int _fraccion;

        public abstract double PorcentajeDeAgua { get; }
        public abstract double PorcentajeDeTierra { get; }
        public abstract bool AgregarHijo(Terreno terreno);
        public abstract bool Eliminarhijo(Terreno terreno);
        public abstract List<Terreno> ObtenerHijos();
    }
}
