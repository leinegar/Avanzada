using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Conector
    {
        private static Conector conector;
        private static String Variable;

        //static ArrayList<String> ejemploLista = new ArrayList<String>();
        static List<string> ejemploLista = new List<string>();

        public static Conector obtenerConector()
        {
            if (conector == null)
            {
                conector = new Conector();
            }
            return conector;
        }

        public static void guardarMiVariable(String texto)
        {
            Variable = texto;
            ejemploLista.Add(Variable);
            Console.WriteLine(Variable+"---AGREGADO!!");

        }

        public List<string> obtenerMiVariable()
        {
            return ejemploLista;
        }
    }
}
