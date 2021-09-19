using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_anegamiento.Composite
{
    public class Anegado : Terreno
    {

        public Anegado(int _franccion) : base(_franccion)
        {

        }

        private List<Terreno> terrenosHijos = new List<Terreno>();
        public override double PorcentajeDeAgua
        {
            get
            {
                double total = 0d;
                foreach (var item in terrenosHijos)
                {
                    total += item.PorcentajeDeAgua;
                }
                return total / 4d;
            }
        }

        public override double PorcentajeDeTierra
        {
            get
            {
                double total = 0d;
                foreach (var item in terrenosHijos)
                {
                    total += item.PorcentajeDeTierra;
                }
                return total / 4d;
            }
        }

        public override bool AgregarHijo(Terreno terreno)
        {
            try
            {
                terrenosHijos.Add(terreno);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public override bool Eliminarhijo(Terreno terreno)
        {
            try
            {
                terrenosHijos.Remove(terreno);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public override List<Terreno> ObtenerHijos()
        {
            return terrenosHijos;
        }
    }
}
