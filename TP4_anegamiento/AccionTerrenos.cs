using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_anegamiento.Composite;

namespace TP4_anegamiento
{
    public static class AccionTerrenos
    {

        public static void AnalizarTerreno(Terreno terreno)
        {
            ConsoleKeyInfo resp;
            if (terreno is Anegado)
            {

                for (int x = 1; x <= 4; x++)
                {
                    do
                    {
                        Console.Write("Seleccione tipo de terreno en cuadrante " + x.ToString() + " [(A)gua-(T)ierra-a(N)egado] ");
                        resp = Console.ReadKey();
                        Console.WriteLine("\n");

                    }
                    while (!(resp.KeyChar == 'A' || resp.KeyChar == 'T' || resp.KeyChar == 'N'));
                    if (resp.KeyChar == 'A')
                    {
                        terreno.AgregarHijo(new SoloAgua(x));
                    }
                    else if (resp.KeyChar == 'T')
                    {
                        terreno.AgregarHijo(new SoloTierra(x));
                    }
                    else if (resp.KeyChar == 'N')
                    {
                        terreno.AgregarHijo(new Anegado(x));
                    }
                }

                // analizo los hijos
                foreach (Terreno hijo in terreno.ObtenerHijos())
                    AnalizarTerreno(hijo);
            }
        }
    }
}
