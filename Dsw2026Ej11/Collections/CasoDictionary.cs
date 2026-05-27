using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> dictionaryAlumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno, int legajo)
    {
        dictionaryAlumnos.Add(legajo, alumno);
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        if (dictionaryAlumnos.ContainsKey(legajo))
        {
            return dictionaryAlumnos[legajo];
        }
        else
        {
            return null;
        }
    }

    public Dictionary<int, Alumno> RetornarDictionary()
    {
        return dictionaryAlumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        if (dictionaryAlumnos.ContainsKey(legajo))
        {
            dictionaryAlumnos.Remove(legajo);
        }
    }
}
