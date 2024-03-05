using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escuela_de_computacion
{
    internal class Fecha
    {
        //Atributos
        public int dia;
        public int mes;
        public int año;

        //contructor
        public Fecha()
        {
            this.dia = 01;
            this.mes = 01;
            this.año = 2021;
        }

        public Fecha(int Dia, int Mes, int Año)
        {
            this.dia = Dia;
            this.mes = Mes; 
            this.año = Año;
        }

        //Metodo
        public void modificarFecha()
        {
            dia = 0;
            mes = 0;
            año = 0;
            Console.WriteLine("Ingrese el dia");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año");
            año = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        public void MostrarFecha()
        {
            Console.WriteLine(dia + "/" + mes + "/" + año);
        }

        public void MostrarFechaPalabras()
        {
            switch (mes)
            {
                case 1:
                    Console.WriteLine(dia + " de " + "Enero" + " del  " + año);
                    break;
                case 2:
                    Console.WriteLine(dia + " de " + "Febrero" + " del  " + año);
                    break;
                case 3:
                    Console.WriteLine(dia + " de " + "Marzo" + " del  " + año);
                    break;
                case 4:
                    Console.WriteLine(dia + " de " + "Abril" + " del  " + año);
                    break;
                case 5:
                    Console.WriteLine(dia + " de " + "Mayo" + " del  " + año);
                    break;
                case 6:
                    Console.WriteLine(dia + " de " + "Junio" + " del  " + año);
                    break;
                case 7:
                    Console.WriteLine(dia + " de " + "Julio" + " del  " + año);
                    break;
                case 8:
                    Console.WriteLine(dia + " de " + "Agosto" + " del  " + año);
                    break;
                case 9:
                    Console.WriteLine(dia + " de " + "Septiembre" + " del  " + año);
                    break;
                case 10:
                    Console.WriteLine(dia + " de " + "Octubre" + " del  " + año);
                    break;
                case 11:
                    Console.WriteLine(dia + " de " + "Noviembre" + " del  " + año);
                    break;
                case 12:
                    Console.WriteLine(dia + " de " + "Diciembre" + " del  " + año);
                    break;
                default:
                    Console.WriteLine("Mes erroneo");
                    break;
            }


        }

    }
}
