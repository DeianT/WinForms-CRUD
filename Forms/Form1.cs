namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        label1.Text = textBox1.Text;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text = button1.Text;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        new PersonaForm().Show();
    }
}
