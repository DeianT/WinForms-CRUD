using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Datos;

public static class PersonaDatos
{
    private const string archivo = @"d:\Users\Deian\source\repos\WinFormsApp1\Datos\persona.csv";
    private static List<Persona> personas = new List<Persona>();

    static PersonaDatos()
    {
        LeerArchivo();
    }

    internal static List<Persona> Personas { get => personas; }

    private static void LeerArchivo()
    {
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

    private static void EscribirLinea(Persona persona)
    {
        FileStream fs = new FileStream(archivo, FileMode.Append);
        byte[] data = Encoding.Default.GetBytes(persona.ToCSV().ToCharArray());
        fs.Write(data, 0, data.Length);
        fs.Close();
    }

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

    public static void AddPersona(Persona persona)
    {
        personas.Add(persona);
        EscribirLinea(persona);
    }

    public static bool EditPersona(int id, Persona newPersona)
    {
        if (id > personas.Count || id < 1)
        {
            return false;
        }

        return EditPersona(id, newPersona.Dni, newPersona.Name, newPersona.Email);
    }

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
}
