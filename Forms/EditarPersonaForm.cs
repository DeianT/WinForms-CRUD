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

namespace WinFormsApp1.Forms
{
    public partial class EditarPersonaForm : Form
    {
        public EditarPersonaForm()
        {
            InitializeComponent();
            for (int i = 1; i <= PersonaDatos.Personas.Count; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = PersonaDatos.Personas[comboBox1.SelectedIndex].Dni.ToString();
            textBox2.Text = PersonaDatos.Personas[comboBox1.SelectedIndex].Name;
            textBox3.Text = PersonaDatos.Personas[comboBox1.SelectedIndex].Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni;
            if (!int.TryParse(textBox1.Text, out dni) || dni <= 0)
            {
                MessageBox.Show(ErrorMessage.DniIncorrecto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show(ErrorMessage.CompletarNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = textBox2.Text.Trim();

            if (!Regex.IsMatch(textBox3.Text.Trim(),
                        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                MessageBox.Show(ErrorMessage.EmailIncorrecto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string email = textBox3.Text.Trim();

            if (PersonaDatos.EditPersona(comboBox1.SelectedIndex + 1, dni, name, email))
            {
                MessageBox.Show("Se han guardado los cambios", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else{
                MessageBox.Show("No se pudo realizar la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
