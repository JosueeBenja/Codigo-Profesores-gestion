namespace Codigos_profesores_gestion
{
    partial class RegistrarProfesor
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
            ListarProfesor = new ListBox();
            button12 = new Button();
            button11 = new Button();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // ListarProfesor
            // 
            ListarProfesor.FormattingEnabled = true;
            ListarProfesor.ItemHeight = 15;
            ListarProfesor.Location = new Point(551, 195);
            ListarProfesor.Name = "ListarProfesor";
            ListarProfesor.Size = new Size(120, 94);
            ListarProfesor.TabIndex = 41;
            ListarProfesor.SelectedIndexChanged += ListarProfesor_SelectedIndexChanged;
            // 
            // button12
            // 
            button12.Location = new Point(551, 102);
            button12.Name = "button12";
            button12.Size = new Size(133, 55);
            button12.TabIndex = 40;
            button12.Text = "Editar/listar profesor";
            button12.UseVisualStyleBackColor = true;
            button12.Click += botonEditarProfesor_Click;
            // 
            // button11
            // 
            button11.Location = new Point(551, 27);
            button11.Name = "button11";
            button11.Size = new Size(92, 53);
            button11.TabIndex = 39;
            button11.Text = "Registro del Profesor";
            button11.UseVisualStyleBackColor = true;
            button11.Click += botonRegistrarProfesor_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(175, 351);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 38;
            textBox8.TextChanged += campoNumeroIdentificacion_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(175, 313);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 37;
            textBox7.TextChanged += fechaNacimientoPicker_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(171, 273);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 36;
            textBox6.TextChanged += campoDireccionResidencia_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(169, 230);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 35;
            textBox5.TextChanged += campoCorreoElectronico_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(177, 189);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 34;
            textBox4.TextChanged += campoTelefono_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 33;
            textBox3.TextChanged += campoEspecialidad_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 32;
            textBox2.TextChanged += campoApellido_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 31;
            textBox1.TextChanged += campoNombre_TextChanged;
            // 
            // button10
            // 
            button10.Location = new Point(13, 350);
            button10.Name = "button10";
            button10.Size = new Size(156, 23);
            button10.TabIndex = 30;
            button10.Text = "numero de Identificacion";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(44, 312);
            button9.Name = "button9";
            button9.Size = new Size(125, 23);
            button9.TabIndex = 29;
            button9.Text = "fecha de Nacimiento";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(13, 266);
            button8.Name = "button8";
            button8.Size = new Size(161, 23);
            button8.TabIndex = 28;
            button8.Text = "direccion de Residencia";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(13, 229);
            button7.Name = "button7";
            button7.Size = new Size(150, 23);
            button7.TabIndex = 27;
            button7.Text = "correo Electronico";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(67, 182);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 26;
            button6.Text = "telefono";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(63, 134);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 25;
            button5.Text = "Especialidad";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(61, 86);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 24;
            button4.Text = "Apellido";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(61, 40);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 23;
            button3.Text = "Nombre";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(682, 401);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(44, 401);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegistrarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListarProfesor);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "RegistrarProfesor";
            Text = "RegistrarProfesor";
            Load += RegistrarProfesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListarProfesor;
        private Button button12;
        private Button button11;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}