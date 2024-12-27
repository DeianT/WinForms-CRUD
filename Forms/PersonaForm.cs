using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Datos;

namespace WinFormsApp1;

public partial class PersonaForm : Form
{
    public PersonaForm()
    {
        InitializeComponent();
        ShowData();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Persona p = new Persona();

        int dni;
        if(!int.TryParse(textBox1.Text, out dni))
        {
            //mostrar error
            return;
        }
        if (dni <= 0)
        {
            //error
            return;
        }
        p.Dni = dni;

        if(textBox2.Text == "")
        {
            //error
            return;
        }
        p.Name = textBox2.Text;

        if (!Regex.IsMatch(textBox3.Text,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
        {
            //error
            return;
        }
        p.Email = textBox3.Text;

        PersonaDatos.AddPersona(p);

        label1.Text = p.ToString();
        ShowData();
    }

    private void ShowData()
    {
        int i = 0;
        listBox1.Items.Clear();
        dataGridView1.Rows.Clear();

        foreach (Persona persona in PersonaDatos.Personas)
        {
            listBox1.Items.Add(persona.ToString());

            dataGridView1.Rows.Insert(i, [
                PersonaDatos.Personas[i].Id,
                PersonaDatos.Personas[i].Dni,
                PersonaDatos.Personas[i].Name,
                PersonaDatos.Personas[i++].Email ]);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}
