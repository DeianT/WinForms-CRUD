using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WinFormsApp1.Datos;

public static class PersonaDatos
{
    private const string archivo = @"d:\Users\Deian\source\repos\WinFormsApp1\Datos\persona.csv";
    private static List<Persona> personas = new List<Persona>();

    static PersonaDatos()
    {
        LeerArchivo();
    }

    /// <summary>
    /// Lista que contiene todas las personas registradas.
    /// </summary>
    internal static List<Persona> Personas { get => personas; }

    /// <summary>
    /// Lee el archivo de personas linea por linea y carga las personas en una lista.
    /// </summary>
    private static void LeerArchivo()
    {
        personas.Clear();
        FileStream fsSource = new FileStream(archivo, FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fsSource);
        while (!sr.EndOfStream) //while ((s = sr.ReadLine()) != null)
        {
            string linea = sr.ReadLine();
            string[] datos = linea.Split(',');
            Persona persona = new Persona();
            persona.Dni = int.Parse(datos[1]);
            persona.Name = datos[2];
            persona.Email = datos[3];

            personas.Add(persona);
        }
        fsSource.Close();
        sr.Close();
    }

    /// <summary>
    /// Agrega una línea con los datos de una persona al final del archivo.
    /// </summary>
    /// <param name="persona">La persona cuyos datos se escribirán en el archivo</param>
    private static void EscribirLinea(Persona persona)
    {
        FileStream fs = new FileStream(archivo, FileMode.Append);
        byte[] data = Encoding.Default.GetBytes(persona.ToCSV().ToCharArray());
        fs.Write(data, 0, data.Length);
        fs.Close();
    }

    /// <summary>
    /// Genera un archivo y escribe la lista completa de personas.
    /// </summary>
    private static void EscribirArchivo()
    {
        FileStream fs = new FileStream(archivo, FileMode.Create);
        foreach (Persona persona in personas)
        {
            byte[] data = Encoding.Default.GetBytes(persona.ToCSV().ToCharArray());
            fs.Write(data, 0, data.Length);
        }
        fs.Close();
    }

    /// <summary>
    /// Agrega una persona a la lista y la escribe en el archivo.
    /// </summary>
    /// <param name="persona">La persona a agregar</param>
    public static void AddPersona(Persona persona)
    {
        personas.Add(persona);
        EscribirLinea(persona);
    }

    /// <summary>
    /// Modifica los atributos de una persona y actualiza el archivo (Requiere reescribirlo por completo)
    /// </summary>
    /// <param name="id">Id de la persona a editar.</param>
    /// <param name="newPersona">Persona con los datos a actualizar.</param>
    /// <returns>true si la Id existe, false si no existe</returns>
    public static bool EditPersona(int id, Persona newPersona)
    {
        if (id > personas.Count || id < 1)
        {
            return false;
        }

        return EditPersona(id, newPersona.Dni, newPersona.Name, newPersona.Email);
    }

    /// <summary>
    /// Modifica los atributos de una persona y actualiza el archivo (Requiere reescribirlo por completo)
    /// </summary>
    /// <param name="id">Id de la persona a editar.</param>
    /// <param name="dni">Nuevo DNI de la persona.</param>
    /// <param name="name">Nuevo nombre de la persona.</param>
    /// <param name="email">Nuevo email de la persona.</param>
    /// <returns>true si la Id existe, false si no existe</returns>
    public static bool EditPersona(int id, int dni, string name, string email)
    {
        if (id > personas.Count || id < 1)
        {
            return false;
        }

        Persona persona = personas[id - 1];
        persona.Dni = dni;
        persona.Name = name;
        persona.Email = email;
        EscribirArchivo();

        return true;
    }

    /// <summary>
    /// Elimina una persona de la lista y reescribe el archivo.
    /// </summary>
    /// <param name="id">Id de la persona a eliminar.</param>
    /// <returns>true si la Id existe, false si no existe</returns>
    public static bool DeletePersona(int id)
    {
        if (id > personas.Count || id < 1)
        {
            return false;
        }

        personas.Remove(personas[id - 1]);
        
        EscribirArchivo();
        LeerArchivo();

        return true;
    }
}
