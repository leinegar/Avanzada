using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using OfficeOpenXml;
using System.IO;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            extraerDatosExcel ejemplo = new extraerDatosExcel();

            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());

            //Conector.guardarMiVariable("Hola, Resulto");
            //Conector.guardarMiVariable("o No D:");

            int x = 0;
            ejemplo = new extraerDatosExcel(x);

            Conector conexionEstatica = Conector.obtenerConector();
            List<String> respuesta = conexionEstatica.obtenerMiVariable();

            Object[] lista = respuesta.ToArray();

            for (int i = 0; i < lista.Length; i++)
            {
                x = 1 + i;
                Console.WriteLine(lista[i] + "<-----FilaEnLaLista:" + x); //Ejemplo de como imrpimir....
            }



        }
    }
}
