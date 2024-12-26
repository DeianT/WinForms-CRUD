using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1;

public class Persona
{
    private long id;
    private int dni;
    private string name;
    private string email;

    public Persona()
    {
        id = 0;
        Dni = 0;
        Name = "";
        Email = "";
    }

    public Persona(int dni, string name, string email)
    {
        id = 0;
        Dni = dni;
        Name = name;
        Email = email;
    }

    public long Id { get => id; }
    public int Dni { get => dni; set => dni = value; }
    public string Name { get => name; set => name = value; }
    public string Email { get => email; set => email = value; }

    public override string ToString()
    {
        return Dni + " " + Name + " " + Email;
    }

    public string ToCSV()
    {
        return $"{Id},{Dni},{Name},{Email}\n";
    }
}
