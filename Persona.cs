using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Datos;

namespace WinFormsApp1;

public class Persona
{
    private readonly int id;
    private int dni;
    private string name;
    private string email;

    public Persona()
    {
        id = PersonaDatos.Personas.Count + 1;
        Dni = 0;
        Name = "";
        Email = "";
    }

    public Persona(int dni, string name, string email)
    {
        id = PersonaDatos.Personas.Count + 1;
        Dni = dni;
        Name = name;
        Email = email;
    }

    public int Id { get => id; }
    public int Dni
    {
        get => dni; 
        set
        {
            if (value >= 0)
            {
                dni = value;
            }
        }
    }
    public string Name { get => name; set => name = value; }
    public string Email { get => email; set => email = value; }

    public override string ToString()
    {
        return Dni + " " + Name + " " + Email;
    }

    /// <summary>
    /// Devuelve los atributos del objeto en formato CSV.
    /// </summary>
    /// <returns>string con los atributos del objeto.</returns>
    public string ToCSV()
    {
        return $"{Id},{Dni},{Name},{Email}\n";
    }
}
