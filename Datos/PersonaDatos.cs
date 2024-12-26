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

    private static void Escribir(Persona persona)
    {
        FileStream fs = new FileStream(archivo, FileMode.Append);
        byte[] data = Encoding.Default.GetBytes(persona.ToCSV().ToCharArray());
        fs.Write(data, 0, data.Length);
        fs.Close();
    }

    public static void AddPersona(Persona persona)
    {
        personas.Add(persona);
        Escribir(persona);
    }
}
