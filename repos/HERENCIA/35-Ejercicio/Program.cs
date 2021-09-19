using System;

namespace _36_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random();
            Competencia formulaUno = new Competencia(10, 20, Competencia.tipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];

            for (int i = 0; i < autos.Length; i++)
            {
                autos[i] = new AutoF1((short)i, azar.Next(1, 5).ToString());
                if ((formulaUno + autos[i]))
                {
                    Console.WriteLine("Se Agrego el siguiente auto a la competencia: {0}", autos[i].MostrarDatos());
                }
                else
                {
                    Console.WriteLine("No se agrego ya que la competencia esta completa: {0}", autos[i].MostrarDatos());
                }
            }
            MotoCross motoCross = new MotoCross(5, "Motos");
            if (formulaUno + motoCross)
            {
                Console.WriteLine("Se agrego la moto");
            }
            else
            {
                Console.WriteLine("no se puede agregar la moto");
            }
            Console.WriteLine();
            Console.WriteLine("<-------------------------------------------------------------------------------------------------->");
            Console.WriteLine(formulaUno.MostrarDatos());
            Console.ReadKey();
        }
    }
}
