using System;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;


namespace pruebacarga
{
    class Program
    {
        static void Main(string[] args)
        {
            leerExcel(@"C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\pruebacarga\Carga.xls");
        }

        static void leerExcel(String archivo) {
            try
            {
                _Application excel = new _Excel.Application();
                Workbook documento;
                Worksheet hoja;
                //opened
                documento = excel.Workbooks.Open(archivo);
                hoja = (Worksheet) documento.Worksheets[1]; //porque es el unico que se quiere abrir

                int filas = hoja.UsedRange.Rows.Count;
                int columnas = hoja.UsedRange.Columns.Count;

                Console.WriteLine("filas: "+filas+" columnas:"+columnas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
