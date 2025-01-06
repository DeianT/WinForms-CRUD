namespace WinFormsApp1.Forms
{
    partial class EditarPersonaForm
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(341, 274);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 31);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 384);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 30);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(341, 484);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 30);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(341, 591);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 30);
            textBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(283, 728);
            button1.Name = "button1";
            button1.Size = new Size(103, 60);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(407, 849);
            button2.Name = "button2";
            button2.Size = new Size(103, 60);
            button2.TabIndex = 5;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Location = new Point(341, 556);
            label4.Name = "label4";
            label4.Size = new Size(235, 32);
            label4.TabIndex = 15;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Location = new Point(341, 449);
            label3.Name = "label3";
            label3.Size = new Size(235, 32);
            label3.TabIndex = 14;
            label3.Text = "Nombre";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Location = new Point(341, 349);
            label2.Name = "label2";
            label2.Size = new Size(235, 32);
            label2.TabIndex = 13;
            label2.Text = "DNI";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Location = new Point(341, 239);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 16;
            label1.Text = "Id";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Location = new Point(522, 728);
            button3.Name = "button3";
            button3.Size = new Size(103, 60);
            button3.TabIndex = 17;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // EditarPersonaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1900, 1029);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "EditarPersonaForm";
            Text = "EditarPersonaForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
    }
}