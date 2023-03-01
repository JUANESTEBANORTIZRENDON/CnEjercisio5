using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnEjercisio5
{
    internal class Program
    {
        /// <summary>
        ///nombre:Juan Esteban Ortiz Rendon
        ///Fecha:28/08/2023
        ///Descripcion:Algoritmo para designar si una persona paga impuestos segun su salario(paga impuestos si su salario es mayor a 3000)
        ///</summary>

        static void Main(string[] args)
        {
            Console.WriteLine("porfavor escriba su nombre");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Escriba el valor de su salario");
            double salario = Convert.ToDouble(Console.ReadLine());

            Impuestos(salario, name);
            Console.ReadKey();
        }
        static double Impuestos(double salario, string name)
        {
            if (salario >= 3000)
            {
                Console.WriteLine("Debes de pagar impuestos señor_" + name);
                return salario;
            }
            else
            {
                Console.WriteLine("no debes pagar impuestos señor_" + name);
                return salario;
            }
        }
    }
}