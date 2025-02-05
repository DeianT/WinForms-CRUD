﻿using System;
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
using WinFormsApp1.Forms;

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
        if (!int.TryParse(textBox1.Text, out dni) || dni <= 0)
        {
            MessageBox.Show(ErrorMessage.DniIncorrecto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        p.Dni = dni;

        if (textBox2.Text.Trim() == "")
        {
            MessageBox.Show(ErrorMessage.CompletarNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        p.Name = textBox2.Text.Trim();

        if (!Regex.IsMatch(textBox3.Text.Trim(),
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
        {
            MessageBox.Show(ErrorMessage.EmailIncorrecto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        p.Email = textBox3.Text.Trim();

        PersonaDatos.AddPersona(p);
        MessageBox.Show("Registrado con éxito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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

    private void button3_Click(object sender, EventArgs e)
    {
        new EditarPersonaForm().ShowDialog();
        ShowData();
        return;
    }

    ~PersonaForm()
    {
        //personadatos.escribir()
    }
}
