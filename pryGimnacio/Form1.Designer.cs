namespace pryGimnacio
{
    partial class frmGimnacio
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
            lblNombre = new Label();
            lblEdad = new Label();
            chkEstudiante = new CheckBox();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            gbxDatos = new GroupBox();
            lblPlan = new Label();
            lblTurno = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            gbxSeleccion = new GroupBox();
            lblMese = new Label();
            numericUpDown2 = new NumericUpDown();
            gbxDuración = new GroupBox();
            chkCasillero = new CheckBox();
            chkPaseLibre = new CheckBox();
            gbxAdicionales = new GroupBox();
            chkEfectivo = new CheckBox();
            chkTarjeta = new CheckBox();
            lblCuotas = new Label();
            comboBox3 = new ComboBox();
            gbxPago = new GroupBox();
            btnConfirmar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            gbxDatos.SuspendLayout();
            gbxSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            gbxDuración.SuspendLayout();
            gbxAdicionales.SuspendLayout();
            gbxPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(10, 17);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(247, 17);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(417, 45);
            chkEstudiante.Margin = new Padding(3, 2, 3, 2);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 2;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 42);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(247, 42);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Minimum = new decimal(new int[] { 14, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 14, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(numericUpDown1);
            gbxDatos.Controls.Add(textBox1);
            gbxDatos.Controls.Add(chkEstudiante);
            gbxDatos.Controls.Add(lblEdad);
            gbxDatos.Controls.Add(lblNombre);
            gbxDatos.Location = new Point(15, 10);
            gbxDatos.Margin = new Padding(3, 2, 3, 2);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Padding = new Padding(3, 2, 3, 2);
            gbxDatos.Size = new Size(666, 80);
            gbxDatos.TabIndex = 5;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos del Socio";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(10, 26);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 6;
            lblPlan.Text = "Plan";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(173, 26);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 7;
            lblTurno.Text = "Turno";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            comboBox1.Location = new Point(10, 62);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            comboBox2.Location = new Point(173, 62);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 9;
            // 
            // gbxSeleccion
            // 
            gbxSeleccion.Controls.Add(comboBox2);
            gbxSeleccion.Controls.Add(comboBox1);
            gbxSeleccion.Controls.Add(lblTurno);
            gbxSeleccion.Controls.Add(lblPlan);
            gbxSeleccion.Location = new Point(15, 102);
            gbxSeleccion.Margin = new Padding(3, 2, 3, 2);
            gbxSeleccion.Name = "gbxSeleccion";
            gbxSeleccion.Padding = new Padding(3, 2, 3, 2);
            gbxSeleccion.Size = new Size(357, 117);
            gbxSeleccion.TabIndex = 10;
            gbxSeleccion.TabStop = false;
            gbxSeleccion.Text = "Selección de Plan y Horario";
            // 
            // lblMese
            // 
            lblMese.AutoSize = true;
            lblMese.Location = new Point(18, 26);
            lblMese.Name = "lblMese";
            lblMese.Size = new Size(40, 15);
            lblMese.TabIndex = 11;
            lblMese.Text = "Meses";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(18, 62);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(131, 23);
            numericUpDown2.TabIndex = 12;
            // 
            // gbxDuración
            // 
            gbxDuración.Controls.Add(numericUpDown2);
            gbxDuración.Controls.Add(lblMese);
            gbxDuración.Location = new Point(387, 102);
            gbxDuración.Margin = new Padding(3, 2, 3, 2);
            gbxDuración.Name = "gbxDuración";
            gbxDuración.Padding = new Padding(3, 2, 3, 2);
            gbxDuración.Size = new Size(294, 117);
            gbxDuración.TabIndex = 13;
            gbxDuración.TabStop = false;
            gbxDuración.Text = "Duración de la inscrpción";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(127, 23);
            chkCasillero.Margin = new Padding(3, 2, 3, 2);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(143, 19);
            chkCasillero.TabIndex = 14;
            chkCasillero.Text = "Casillero(3.000 al mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // chkPaseLibre
            // 
            chkPaseLibre.AutoSize = true;
            chkPaseLibre.Location = new Point(349, 23);
            chkPaseLibre.Margin = new Padding(3, 2, 3, 2);
            chkPaseLibre.Name = "chkPaseLibre";
            chkPaseLibre.Size = new Size(157, 19);
            chkPaseLibre.TabIndex = 15;
            chkPaseLibre.Text = "Pase Libre(30.000 al mes)";
            chkPaseLibre.UseVisualStyleBackColor = true;
            // 
            // gbxAdicionales
            // 
            gbxAdicionales.Controls.Add(chkPaseLibre);
            gbxAdicionales.Controls.Add(chkCasillero);
            gbxAdicionales.Location = new Point(15, 224);
            gbxAdicionales.Margin = new Padding(3, 2, 3, 2);
            gbxAdicionales.Name = "gbxAdicionales";
            gbxAdicionales.Padding = new Padding(3, 2, 3, 2);
            gbxAdicionales.Size = new Size(664, 63);
            gbxAdicionales.TabIndex = 16;
            gbxAdicionales.TabStop = false;
            gbxAdicionales.Text = "Servicios Adicionales";
            // 
            // chkEfectivo
            // 
            chkEfectivo.AutoSize = true;
            chkEfectivo.Location = new Point(4, 29);
            chkEfectivo.Margin = new Padding(3, 2, 3, 2);
            chkEfectivo.Name = "chkEfectivo";
            chkEfectivo.Size = new Size(68, 19);
            chkEfectivo.TabIndex = 17;
            chkEfectivo.Text = "Efectivo";
            chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // chkTarjeta
            // 
            chkTarjeta.AutoSize = true;
            chkTarjeta.Location = new Point(142, 29);
            chkTarjeta.Margin = new Padding(3, 2, 3, 2);
            chkTarjeta.Name = "chkTarjeta";
            chkTarjeta.Size = new Size(61, 19);
            chkTarjeta.TabIndex = 18;
            chkTarjeta.Text = "Tarjeta";
            chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(278, 21);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 19;
            lblCuotas.Text = "Cuotas";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "3", "6" });
            comboBox3.Location = new Point(278, 50);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(133, 23);
            comboBox3.TabIndex = 20;
            // 
            // gbxPago
            // 
            gbxPago.Controls.Add(comboBox3);
            gbxPago.Controls.Add(lblCuotas);
            gbxPago.Controls.Add(chkTarjeta);
            gbxPago.Controls.Add(chkEfectivo);
            gbxPago.Location = new Point(15, 291);
            gbxPago.Margin = new Padding(3, 2, 3, 2);
            gbxPago.Name = "gbxPago";
            gbxPago.Padding = new Padding(3, 2, 3, 2);
            gbxPago.Size = new Size(433, 83);
            gbxPago.TabIndex = 21;
            gbxPago.TabStop = false;
            gbxPago.Text = "Forma de Pago";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(514, 304);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(130, 32);
            btnConfirmar.TabIndex = 22;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(514, 341);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 32);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmGimnacio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 380);
            Controls.Add(btnLimpiar);
            Controls.Add(btnConfirmar);
            Controls.Add(gbxPago);
            Controls.Add(gbxAdicionales);
            Controls.Add(gbxDuración);
            Controls.Add(gbxSeleccion);
            Controls.Add(gbxDatos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGimnacio";
            Text = "Gimnacio Siglo- Inscripcion de socios";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            gbxSeleccion.ResumeLayout(false);
            gbxSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            gbxDuración.ResumeLayout(false);
            gbxDuración.PerformLayout();
            gbxAdicionales.ResumeLayout(false);
            gbxAdicionales.PerformLayout();
            gbxPago.ResumeLayout(false);
            gbxPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Label lblEdad;
        private CheckBox chkEstudiante;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private GroupBox gbxDatos;
        private Label lblPlan;
        private Label lblTurno;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox gbxSeleccion;
        private Label lblMese;
        private NumericUpDown numericUpDown2;
        private GroupBox gbxDuración;
        private CheckBox chkCasillero;
        private CheckBox chkPaseLibre;
        private GroupBox gbxAdicionales;
        private CheckBox chkEfectivo;
        private CheckBox chkTarjeta;
        private Label lblCuotas;
        private ComboBox comboBox3;
        private GroupBox gbxPago;
        private Button btnConfirmar;
        private Button btnLimpiar;
    }
}
