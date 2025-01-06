namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            menu1ToolStripMenuItem = new ToolStripMenuItem();
            menu2ToolStripMenuItem = new ToolStripMenuItem();
            sub21ToolStripMenuItem = new ToolStripMenuItem();
            sub22ToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(286, 72);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Escriba aquí";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(338, 63);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(412, 203);
            button1.Name = "button1";
            button1.Size = new Size(103, 60);
            button1.TabIndex = 1;
            button1.Text = "Cambiar Texto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(374, 295);
            label1.Name = "label1";
            label1.Size = new Size(194, 36);
            label1.TabIndex = 2;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(134, 670);
            button2.Name = "button2";
            button2.Size = new Size(103, 60);
            button2.TabIndex = 3;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.InactiveCaption;
            menuStrip1.ImageScalingSize = new Size(22, 22);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu1ToolStripMenuItem, menu2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1900, 47);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            menu1ToolStripMenuItem.Padding = new Padding(8);
            menu1ToolStripMenuItem.Size = new Size(83, 43);
            menu1ToolStripMenuItem.Text = "menu1";
            // 
            // menu2ToolStripMenuItem
            // 
            menu2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sub21ToolStripMenuItem, sub22ToolStripMenuItem });
            menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            menu2ToolStripMenuItem.Padding = new Padding(8);
            menu2ToolStripMenuItem.Size = new Size(83, 43);
            menu2ToolStripMenuItem.Text = "menu2";
            // 
            // sub21ToolStripMenuItem
            // 
            sub21ToolStripMenuItem.BackColor = SystemColors.InactiveCaption;
            sub21ToolStripMenuItem.Name = "sub21ToolStripMenuItem";
            sub21ToolStripMenuItem.Size = new Size(247, 30);
            sub21ToolStripMenuItem.Text = "sub2.1";
            // 
            // sub22ToolStripMenuItem
            // 
            sub22ToolStripMenuItem.BackColor = SystemColors.InactiveCaption;
            sub22ToolStripMenuItem.Name = "sub22ToolStripMenuItem";
            sub22ToolStripMenuItem.Size = new Size(247, 30);
            sub22ToolStripMenuItem.Text = "sub2.2";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Location = new Point(412, 406);
            button3.Name = "button3";
            button3.Size = new Size(103, 60);
            button3.TabIndex = 5;
            button3.Text = "Registro Personas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1900, 1029);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu1ToolStripMenuItem;
        private ToolStripMenuItem menu2ToolStripMenuItem;
        private ToolStripMenuItem sub21ToolStripMenuItem;
        private ToolStripMenuItem sub22ToolStripMenuItem;
        private Button button3;
    }
}
