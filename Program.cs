using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola_Tabla_de_amortizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            float MontoPrestamo;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------Calculadora de Prestamos-----------------------" + Environment.NewLine + Environment.NewLine);

                Console.Write("Ingrese el monto total del prestamo: ");
                float.TryParse(Console.ReadLine(), out MontoPrestamo);
            } while (MontoPrestamo < 1) ;
            Console.Clear();
            float InteresAnual;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------Calculadora de Prestamos-----------------------" + Environment.NewLine + Environment.NewLine);
                Console.Write("Ingrese la tasa de interes anual del prestamo: ");
                float.TryParse(Console.ReadLine(), out InteresAnual);
            } while (InteresAnual < 1);
            Console.Clear();
            int Plazo;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------Calculadora de Prestamos-----------------------" + Environment.NewLine + Environment.NewLine);
                Console.Write("Ingrese el plazo del prestramo (en meses): ");
                int.TryParse(Console.ReadLine(), out Plazo);
            } while (Plazo < 1);
            Console.Clear();
            
     

            float InteresMensual;
            InteresMensual = (InteresAnual / 100) / 12;


            float cuota;
            cuota = InteresMensual + 1;
            cuota = (float)Math.Pow(cuota, Plazo);
            cuota = cuota - 1;
            cuota = InteresMensual / cuota;
            cuota = InteresMensual + cuota;
            cuota = MontoPrestamo * cuota;



            Console.WriteLine("-----------------------Calculadora de Prestamos-----------------------" + Environment.NewLine + Environment.NewLine);
            Console.WriteLine($"Monto del Prestamo: RD${MontoPrestamo}");
            Console.WriteLine($"Tasa Anual: {InteresAnual}%");
            Console.WriteLine($"Plazo del prestamo: {Plazo} meses");
            Console.WriteLine($"Cuota: RD${cuota}");

           
            
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Numero de pago \t");
            Console.Write("Cuota \t\t");
            Console.Write("Intereses \t\t");
            Console.Write("Capital\t\t\t");
            Console.Write("Monto del prestamo \t");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t0");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t{0}", MontoPrestamo);

            int fila = 1;
            float Interes, Capital;
            for (int i = 1; i <= Plazo; i++)
            {


                Console.Write("\t{0}\t\t", fila);


                Console.Write("{0}\t", cuota);


                Interes = InteresMensual * MontoPrestamo;
                Console.Write("{0}\t", Interes);


                Capital = cuota - Interes;
                Console.Write("\t{0}\t", Capital);


                MontoPrestamo = MontoPrestamo - Capital;
                Console.Write("\t{0}\t", MontoPrestamo);

                fila = fila + 1;
                Console.WriteLine();

            }
            Console.ReadKey();
        }

    }
}