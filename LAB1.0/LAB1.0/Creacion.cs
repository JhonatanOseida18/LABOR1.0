using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB1._0
{
    class Creacion
    {
        static Usuarios Users = new Usuarios();

        static StreamWriter Escritura;

        static string Ruta = "Accesos.txt";

        static int V, A;

        TextReader Lectura;


        static string Informacion(string info)
        {
 
            Console.WriteLine("Ingrese " + info + ":");
            return (Console.ReadLine());
        }
        static void User(string Usuario, string Contraseña)
        {
     
            Console.WriteLine("ELIJA UNA OPCIÓN: \n 1. ADMIN \n 2. EMPLEADO");
            A = int.Parse(Console.ReadLine());

            if (A == 1)
            {
                Escritura = File.AppendText(Ruta);

                Escritura.WriteLine("Usuario: " + Usuario + "\nContraseña: " + Contraseña);

                Users.UsAd = Usuario;
                Users.ConAd = Contraseña;

                Escritura.Close();
            }

            if (A == 2)
            {
                Escritura = File.AppendText(Ruta);

                Escritura.WriteLine("Usuario: " + Usuario + "\nContraseña: " + Contraseña);

                Users.UsTr = Usuario;
                Users.ConTr = Contraseña;

                Escritura.Close();
            }

        }
        public void Crear()
        {
            char OP = 'S';

            while (OP != 'N')
            {
                User(Informacion("Usuario"), Informacion("Contraseña"));
                Escritura = File.AppendText(Ruta);
             
                Escritura.Close();
             
                Console.WriteLine("Ingresar otro usuario? [S/N]:");
                OP = char.Parse(Console.ReadLine());
              
               
            }

            Console.WriteLine("¿Desea ir al inicio? \n 1. SI \n 2. NO");
            V = int.Parse(Console.ReadLine());

            if (V == 1)
            {
                Users.user();
            }
            if (V == 2)
            {

                Console.WriteLine("Buen Dia");

            }

            Escritura = File.AppendText(Ruta);
         
            Escritura.Close();
     
            Console.WriteLine("TENGA BUEN DIA");
            Console.ReadLine();
        }
        public void RegPan()
        {          
            Lectura = new StreamReader("Accesos.txt");
            Console.WriteLine(Lectura.ReadToEnd());
        }

    }
}
