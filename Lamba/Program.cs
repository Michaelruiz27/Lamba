using System;
using static Lamba.Estusdiante;
using System.Linq;


class Program
{
    public static void Main(string[] args)
    {
        // Crea una lista de estudiantes con  5 elementos
        List<Estudiantes> estudiantes = new List<Estudiantes>
        {
            new Estudiantes("Luis", 19, 85),
            new Estudiantes("Sofia", 22, 100),
            new Estudiantes("Ricardo", 20, 65),
            new Estudiantes("Isabella", 19, 95),
            new Estudiantes("Gabriel", 18, 80),
            new Estudiantes("Camila", 20, 60)
        };

        // Filtra y muestrar estudiantes mayores de 18 años
        List<Estudiantes> estudiantesMayoresEdad = estudiantes.Where(e => e.Edad > 18).ToList();
        Console.WriteLine("Estudiantes mayores de 18 años:");
        foreach (Estudiantes estudiante in estudiantesMayoresEdad)
        {
            Console.WriteLine($"{estudiante.Nombre}, {estudiante.Edad}, {estudiante.Nota}");
        }

        // Filtra y muestra estudiantes menores o iguales a 18 años
        var estudiantesMenoresoIgual = estudiantes.Where(e => e.Edad <= 18);
        Console.WriteLine("\nEstudiantes menores o iguales a 18 años:");
        foreach (var estudiante in estudiantesMenoresoIgual)
        {
            Console.WriteLine($"{estudiante.Nombre}, {estudiante.Edad}, {estudiante.Nota}");
        }

        // Obtine y muestra el estudiante con la nota más alta
        Estudiantes mejorNotaEstudiante = estudiantes.OrderByDescending(e => e.Nota).FirstOrDefault();
        Console.WriteLine("\nEstudiante con la nota más alta:");
        Console.WriteLine($"{mejorNotaEstudiante.Nombre}, {mejorNotaEstudiante.Edad}, {mejorNotaEstudiante.Nota}");

        // Obtener y mostrar el estudiante con la nota más baja
        var estudiantePeorNota = estudiantes.OrderBy(e => e.Nota).First();
        Console.WriteLine($"\nEstudiante con la nota más baja:");
        Console.WriteLine($"{estudiantePeorNota.Nombre}, {estudiantePeorNota.Edad}, {estudiantePeorNota.Nota}");

        // Ordena y muestra los estudiantes por nombre alfabéticamente
        List<Estudiantes> estudiantesOrdenadosAlfabeticamente = estudiantes.OrderBy(e => e.Nombre).ToList();
        Console.WriteLine("\nEstudiantes ordenados por nombre:");
        foreach (Estudiantes estudiante in estudiantesOrdenadosAlfabeticamente)
        {
            Console.WriteLine($"{estudiante.Nombre}, {estudiante.Edad}, {estudiante.Nota}");
        }

        // Calcula y muestrar el promedio de notas
        double promedioNotasTotal = estudiantes.Average(e => e.Nota);
        Console.WriteLine("\nPromedio de notas:");
        Console.WriteLine($"{promedioNotasTotal:F2}");
    }
}