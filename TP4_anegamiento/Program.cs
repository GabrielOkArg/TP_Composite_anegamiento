using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_anegamiento.Composite;

namespace TP4_anegamiento
{
    class Program
    {
        static void Main(string[] args)
        {


            Terreno _nuevoTerreno = new Anegado(0);

            ConsoleKeyInfo _opcion;
            do
            {
                Console.Write("Seleccione tipo de terreno  [(A)gua-(T)ierra-a(N)egado] ");
                _opcion = Console.ReadKey();
                Console.WriteLine("\n");
                if (_opcion.KeyChar == 'N') // Si es anegado lo divido en 4
                {
                    _nuevoTerreno = new Anegado(0);
                    AccionTerrenos.AnalizarTerreno(_nuevoTerreno);
                }
                else if (_opcion.KeyChar == 'T')
                {
                    _nuevoTerreno = new SoloTierra(0);

                }
                else if (_opcion.KeyChar == 'A')
                {
                    _nuevoTerreno = new SoloAgua(0);

                }
            }
            while (!(_opcion.KeyChar == 'A' || _opcion.KeyChar == 'T' || _opcion.KeyChar == 'N'));
            Console.WriteLine("total porcentaje agua: " + _nuevoTerreno.PorcentajeDeAgua);
            Console.WriteLine("total porcentaje tierra: " + _nuevoTerreno.PorcentajeDeTierra);
            Console.ReadKey();

        }
    }
}
