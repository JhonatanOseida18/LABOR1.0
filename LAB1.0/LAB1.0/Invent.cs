using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB1._0
{
    class Invent
    {
        Usuarios Users = new Usuarios();

        static string Ruta = "Inven.txt";

        TextReader Lec;

        static int D;

        static StreamWriter Escritura;

        static string Infor(string info)
        {
         
            Console.WriteLine("Ingrese " + info + ":");
            return (Console.ReadLine());
        }
        static void Existencias(string Nombre, string Cantidad, string Valor)
        {
          
            Escritura = File.AppendText(Ruta);
            Escritura.WriteLine("Producto: " + Nombre + "\n Cantidad: " + Cantidad + "\n Valor: " + Valor);
            Escritura.Close();
        }
        public void Inven()
        {
            char OP = 'S';

            while (OP != 'N')
            {
                Existencias(Infor("Producto"), Infor("Cantidad"), Infor("Valor"));

                Escritura = File.AppendText(Ruta);
                
                    
             
                Console.WriteLine("¿Ingresar otro producto? [S/N]:");
                OP = char.Parse(Console.ReadLine());

                           
            }

            Console.WriteLine("¿Regresar al inicio? [1. Si/ 2. No]");
            D = int.Parse(Console.ReadLine());

            Console.Clear();
            if (D == 1)
            {
                Users.user();
            }
            if (D == 2)
            {

                Console.WriteLine("Buen Dia");

            }

            Escritura = File.AppendText(Ruta);
          
            Escritura.Close();
          
            Console.WriteLine("Buen Dia");
            Console.ReadLine();



        }
        public void Inventor()
        {
           
            Lec = new StreamReader("Inven.txt");
            Console.WriteLine(Lec.ReadToEnd());
        }
    }
}
