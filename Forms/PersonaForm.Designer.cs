namespace WinFormsApp1
{
    partial class PersonaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            button2 = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 30);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 286);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 30);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(231, 366);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 30);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(253, 496);
            button1.Name = "button1";
            button1.Size = new Size(103, 32);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(692, 201);
            label1.Name = "label1";
            label1.Size = new Size(550, 23);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, dni, name, email });
            dataGridView1.Location = new Point(692, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 56;
            dataGridView1.Size = new Size(636, 206);
            dataGridView1.TabIndex = 5;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 7;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 138;
            // 
            // dni
            // 
            dni.HeaderText = "dni";
            dni.MinimumWidth = 7;
            dni.Name = "dni";
            dni.ReadOnly = true;
            dni.Width = 138;
            // 
            // name
            // 
            name.HeaderText = "name";
            name.MinimumWidth = 7;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 138;
            // 
            // email
            // 
            email.HeaderText = "email";
            email.MinimumWidth = 7;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 138;
            // 
            // button2
            // 
            button2.Location = new Point(260, 589);
            button2.Name = "button2";
            button2.Size = new Size(103, 32);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(692, 502);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(329, 119);
            listBox1.TabIndex = 8;
            // 
            // PersonaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 1029);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "PersonaForm";
            Text = "PersonaForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button2;
        private ListBox listBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
    }
}