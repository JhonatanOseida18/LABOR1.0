using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB1._0
{
    class FacturaFinal
    {
        static string Ruta = "Factura Final.txt";

        static double p = 0;

        static double v = 0;

        static double sub = 0;

        static StreamWriter Escritura;

        public void facturas()
        {
            char op = 'n';

            SavingCliente(Llenar("Nombre Completo"), Llenar("Correlativo"), Llenar("Nit"), Llenar("Fecha"));

            double total = 0;

            while (op != 's')
            {

                Tienda(Llenar("Producto"));

                sub = Operation(Valor(v), Cantidad(p));

                Escritura = File.AppendText(Ruta);

                Escritura.WriteLine("El sub-total es:" + sub);

                Escritura.Close();

                Console.WriteLine("El Sub-Total es:" + sub);

                Console.WriteLine("Desea salir[s/n]:");

                op = char.Parse(Console.ReadLine());

                total = total + sub;
            }

            Escritura = File.AppendText(Ruta);  

            Escritura.WriteLine("SU TOTAL A CANCELAR ES :" + total);

            Escritura.Close();

            Console.WriteLine("El total es:" + total);

            Console.ReadLine();

        }
        static string Llenar(string info)
        {
            Console.WriteLine("Ingrese " + info + ":");
            return (Console.ReadLine());
        }
        static double Valor(double info)

        {        
                Console.WriteLine("Ingrese Valor del producto" + info + ":");
                return double.Parse(Console.ReadLine());
                     
        }
        static double Cantidad(double info)
        {                    
                Console.WriteLine("Ingrese Cantidad del producto" + info + ":");
                return double.Parse(Console.ReadLine());     
        }
        static void SavingCliente(string Nombres, string Correlativo, string Fecha, string Nit)
        {
            Escritura = File.AppendText(Ruta);
            Escritura.WriteLine(Nombres + "-" + Correlativo + "-" + Nit + "-" + Fecha);
            Escritura.Close();
        }
        static void Tienda(string Producto)
        {
            Escritura = File.AppendText(Ruta);
            Escritura.WriteLine(Producto);
            Escritura.Close();
        }



        static double Operation(double P, double O)
        {
            double resultado;
            resultado = P * O;
            return resultado;
        }

        public void LecFac()
        {
            TextReader Lec;
            Lec = new StreamReader("Factura Final.txt");
            Console.WriteLine(Lec.ReadToEnd());
        }


    }
}
