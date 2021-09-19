using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_anegamiento.Composite
{
    public class SoloTierra : Terreno
    {


        public SoloTierra(int Pfraccion): base(Pfraccion)
        {

        }

        public override double PorcentajeDeAgua
        {
            get
            {
                return 0;
            }
        }

        public override double PorcentajeDeTierra
        {
            get
            {
                return 100;
            }
        }

        public override bool AgregarHijo(Terreno terreno)
        {
            throw new NotImplementedException();
        }

        public override bool Eliminarhijo(Terreno terreno)
        {
            throw new NotImplementedException();
        }

        public override List<Terreno> ObtenerHijos()
        {
            throw new NotImplementedException();
        }
    }
}
