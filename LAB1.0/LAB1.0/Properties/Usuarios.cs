using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._0
{
    class Usuarios
    {
        public int a1, a2, a3, a4, a5, In;
        public string UsAd = "Jhon", ConAd = "123", UsTr = "Alberto", ConTr = "456";
        public string M, K, PR, BR;      

        static Invent Inv = new Invent();
        static Creacion create = new Creacion();
        static FacturaFinal Fact = new FacturaFinal();



        public void user()
        {
            Console.WriteLine("¿Como desea inicar sesion:? \n 1. ADMIN \n 2. EMPLEADO \n 3. Salida ");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bienvenido a Los Patos Corp");

            if (a1 == 1)
            {
                Console.WriteLine("Ingrese Nombre: ");
                M = Console.ReadLine();

                if (UsAd == M)
                {
                    Console.WriteLine("Ingrese su Contraseña");         
                    K = Console.ReadLine();

                    if (ConAd == K)
                    {
                        Console.WriteLine("Buen dia. Elija una opcion: \n 1. Inventario \n 2. Usuarios \n 3. Facturas \n 4. Salir");
                        a2 = int.Parse(Console.ReadLine());

                        if (a2 == 1)
                        {
                            Console.WriteLine("Elija una opcion: \n 1. Visualizar el inventario \n 2. Actualizar el inventario");
                            a4 = int.Parse(Console.ReadLine());

                            if (a4 == 1)

                            {
                                Inv.Inventor();
    
                            }

                            if (a4 == 2)
                            {
                                Inv.Inven();
                            }
                        }

                        else if (a2 == 2)
                        {
                            Console.WriteLine("Elija una opcion: \n 1. Crear un nuevo usuario \n 2. Ver usuarios creados");
                            a5 = int.Parse(Console.ReadLine());

                            if (a5 == 1)

                            {
                                create.Crear();
                            }

                            if (a5 == 2)
                            {
                                create.RegPan();
                            }
                        }


                        else if (a2 == 3)
                        {
                            Fact.LecFac();
                        }

                        else if (a2 == 4)
                        {
                            Console.WriteLine("¿Regresar al inicio? [1. Si/2. No]");
                            In = int.Parse(Console.ReadLine());

                            if (In == 1)
                            {
                                user();
                            }

                            if(In==2)
                            {
                                Console.WriteLine("Buen dia");
                            }

                        }

                    }
                }

            }

            if (a1 == 2)
            {
                Console.WriteLine("Ingrese Nombre: ");
                PR = Console.ReadLine();

                if (UsTr == PR)
                {
                    Console.WriteLine("Ingrese Contraseña: ");
                    BR = Console.ReadLine();

                    if (ConTr == BR)
                    {
                        Console.WriteLine("Buen dia. Elija una opcion: \n 1. Cargar productos al inventario \n 2. Facturar una compra \n 3. Salida");
                        a3 = int.Parse(Console.ReadLine());

                        if (a3 == 1)
                        {
                            Inv.Inven();
                        }

                        else if (a3 == 2)
                        {
                            Fact.facturas();

                        }

                        else if (a3 == 3)
                        {
                            Console.WriteLine("¿Regresar al inicio? [1. Si/2. No]");
                            In = int.Parse(Console.ReadLine());

                            if(In==1)
                            {
                                user();

                            }

                            if(In==2)
                            {
                                Console.WriteLine("Buen dia ");
                            }

                        }
                    }
                }
            }

            if (a1 == 3)
            {
                Console.WriteLine("Tenga un excelente dia");
            }
            Console.ReadKey();
        }
    }
}