using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new();
        Alumno alumno1 = new Alumno(1, "Juan Perez", 8.5);
        Alumno alumno2 = new Alumno(2, "Maria Gomez", 9.2);
        Alumno alumno3 = new Alumno(3, "Ignacio Fernandez", 7.8);

        casoList.AgregarAlumnos(alumno1);
        casoList.AgregarAlumnos(alumno2);
        casoList.AgregarAlumnos(alumno3);

        foreach(Alumno alu in casoList.RetornarListaAlumnos()){
            Console.WriteLine(alu.ToString());
        }

        Alumno? alumnoEncontrado;
        alumnoEncontrado = casoList.BuscarAlumno("Ignacio Fernandez");
        Console.WriteLine(alumnoEncontrado.ToString());

        alumnoEncontrado = casoList.BuscarAlumno("Belen Castro");
        if(alumnoEncontrado == null)
        {
            Console.WriteLine("No existe");
        }
        else
        {
            Console.WriteLine(alumnoEncontrado.ToString());
        }

        casoList.EliminarAlumno(alumno3);
        foreach(Alumno alu in casoList.RetornarListaAlumnos()){
            Console.WriteLine(alu.ToString());
        }

        casoList.EliminarAlumno(0);
        foreach (Alumno alu in casoList.RetornarListaAlumnos())
        {
            Console.WriteLine(alu.ToString());
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new();

        Alumno alumno4 = new Alumno(4, "Sofía Martínez", 8.9);
        Alumno alumno5 = new Alumno(5, "Tomás López", 6.7);
        Alumno alumno6 = new Alumno(6, "Valentina Ruiz", 9.5);

        casoDictionary.AgregarAlumno(alumno4, 100);
        casoDictionary.AgregarAlumno(alumno5, 101);
        casoDictionary.AgregarAlumno(alumno6, 102);

        foreach(var alumno in casoDictionary.RetornarDictionary())
        {
            Console.WriteLine(alumno.ToString());
        }

        Alumno? alumnoEncontrado;
        alumnoEncontrado = casoDictionary.BuscarAlumno(100);
        Console.WriteLine(alumnoEncontrado.ToString());

        alumnoEncontrado = casoDictionary.BuscarAlumno(200);
        if(alumnoEncontrado == null)
        {
            Console.WriteLine("No existe");
        }
        else
        {
            Console.WriteLine(alumnoEncontrado.ToString());
        }

        casoDictionary.EliminarAlumno(100);
        foreach (var alumno in casoDictionary.RetornarDictionary())
        {
            Console.WriteLine(alumno.ToString());
        }


    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new();
        Libro? libro;

        libro = casoLinq.GetPrimero();
        Console.WriteLine(libro.ToString());

    }
}
