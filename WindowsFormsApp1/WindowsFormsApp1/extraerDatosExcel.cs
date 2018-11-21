using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class extraerDatosExcel
    {
        public extraerDatosExcel() { }

        public extraerDatosExcel(int x)
        {
            int y = 0;

            if (x == y)
            {// Creamos una instancia de paquete de Excel de OfficeOpenXml
                using (ExcelPackage paquete = new ExcelPackage())
                {
                    // Creamos un flujo a partir del archivo de Excel, y lo cargamos en el paquete
                    using (FileStream flujo = File.OpenRead(@"C:\Users\Hector\Desktop\Agua del Valle\ejemplo2.xlsx"))
                    {
                        paquete.Load(flujo);
                    }

                    // Obtenemos la primera hoja del documento
                    ExcelWorksheet hoja1 = paquete.Workbook.Worksheets.First();

                    // Empezamos a leer a partir de la segunda fila
                    for (int numFila = 1; ; numFila++)
                    {
                        // Obtenemos el valor de la celda de la primera columna, como texto
                        string codigo = hoja1.Cells[numFila, 1].Text;

                        Conector.guardarMiVariable(codigo);

                        Console.WriteLine(codigo + "<-----Fila:" + numFila);

                        // Si la celda está en blanco, finalizamos la lectura
                        if (string.IsNullOrEmpty(codigo)) break;



                        // Si no, procedemos a leer las otras 2 celdas
                        // string nombre = hoja1.Cells[numFila, 2].Text;

                        // Notar que los valores numéricos son obtenidos como doubles
                        //double precio = (double)hoja1.Cells[numFila, 3].Value;

                        // Imprimimos en pantalla
                        //Console.WriteLine("{0} - {1} - {2:#.00}", codigo, nombre, precio);
                    }
                }
                y++;
            }
            else
            if(x != y)
            {
                Console.WriteLine("SE COMPLETO LA PRIMERA OLEADA");
            }
            Console.WriteLine("RESULTO");
        }
    }
}

//UNA FUNCION QUE NO PERMITA AGREGAR EL 151 EL NULO
