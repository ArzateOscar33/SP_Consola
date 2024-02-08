using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunicacionSP_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidacionCOM validacionCOM = new ValidacionCOM();

            validacionCOM.ValidarPuertosComParalelo();

            List<string> puertosValidados = validacionCOM.ObtenerPuertosComValidados();

            Console.WriteLine("Puertos COM validados:");
            foreach (var puertoValidado in puertosValidados)
            {
                Console.WriteLine(puertoValidado);
            }
        }
    }
}
