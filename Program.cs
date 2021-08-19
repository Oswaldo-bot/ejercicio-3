using System;
//Un estudiante desea saber cuál será su calificación final en la materia de cálculo,
//dicha calificación se compone de los siguientes porcentajes:
//• 55 % del promedio de sus tres calificaciones parciales.
//• 30% de la calificación del examen final.
//• 15% de la calificación de un trabajo final
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota_Par1, nota_Par2, nota_Par3, nota_Examen, nota_Trabajo, Parciales, PAEx, PANf;
            string Nombre_Alumno;

            Console.Write("Nombre del alumno : ");
            Nombre_Alumno = Console.ReadLine();

            Console.WriteLine("\n Ingrese notas Parciales");
            Console.Write("\n Nota # 1 : ");
            nota_Par1 = Double.Parse(Console.ReadLine());

            Console.Write(" Nota # 2 : ");
            nota_Par2 = Double.Parse(Console.ReadLine());

            Console.Write(" Nota # 3 : ");
            nota_Par3 = Double.Parse(Console.ReadLine());

            Console.Write("\n Ingrese nota del examen : ");
            nota_Examen = Double.Parse(Console.ReadLine());
            Console.Write(" Ingrese nota del trabajo final : ");
            nota_Trabajo = Double.Parse(Console.ReadLine());

            Parciales = ((nota_Par1 + nota_Par2 + nota_Par3) / 3) * 0.55;
            PAEx = nota_Examen * 0.30;
            PANf = nota_Trabajo * 0.15;

            Console.WriteLine("\n Las notas parciales equivalen a      : {0:G2}", Parciales);
            Console.WriteLine(" Las notas del examen equivale a        : {0:G2}", PAEx);
            Console.WriteLine(" Las notas del trabajo final equivale a : {0:G2}", PANf);
        }

    }
}


