using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu salario bruto");
                double salariob = double.Parse(Console.ReadLine());

            Console.WriteLine("vale alimentação");
                double alimentação = double.Parse(Console.ReadLine());

            Console.WriteLine("Numero de filhos");
                double nfilhos = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor por filho ");
                double vfilhos = double.Parse(Console.ReadLine());

            Console.WriteLine("Numero de horas");
                double nhoras = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de horas");
                double vhoras = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do INSS"); 
                double INSS = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do IRPF");
                double IRPF = double.Parse(Console.ReadLine());


            double salarioL = salariob + alimentação + (nfilhos * vfilhos) + (nhoras * vhoras) - INSS - IRPF;

            Console.WriteLine("Salario Liquido: R$" + salarioL);

            Console.ReadKey();
        }
    }
}
