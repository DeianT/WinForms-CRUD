using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        p.Dni = int.Parse(textBox1.Text);
        p.Name = textBox2.Text;
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
