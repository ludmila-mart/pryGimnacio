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
            lblNombre.Location = new Point(11, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(282, 23);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(477, 60);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(100, 24);
            chkEstudiante.TabIndex = 2;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(282, 56);
            numericUpDown1.Minimum = new decimal(new int[] { 14, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
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
            gbxDatos.Location = new Point(17, 13);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(761, 106);
            gbxDatos.TabIndex = 5;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos del Socio";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(11, 35);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(37, 20);
            lblPlan.TabIndex = 6;
            lblPlan.Text = "Plan";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(198, 35);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(47, 20);
            lblTurno.TabIndex = 7;
            lblTurno.Text = "Turno";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            comboBox1.Location = new Point(11, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            comboBox2.Location = new Point(198, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 9;
            // 
            // gbxSeleccion
            // 
            gbxSeleccion.Controls.Add(comboBox2);
            gbxSeleccion.Controls.Add(comboBox1);
            gbxSeleccion.Controls.Add(lblTurno);
            gbxSeleccion.Controls.Add(lblPlan);
            gbxSeleccion.Location = new Point(17, 136);
            gbxSeleccion.Name = "gbxSeleccion";
            gbxSeleccion.Size = new Size(408, 156);
            gbxSeleccion.TabIndex = 10;
            gbxSeleccion.TabStop = false;
            gbxSeleccion.Text = "Selección de Plan y Horario";
            // 
            // lblMese
            // 
            lblMese.AutoSize = true;
            lblMese.Location = new Point(21, 35);
            lblMese.Name = "lblMese";
            lblMese.Size = new Size(50, 20);
            lblMese.TabIndex = 11;
            lblMese.Text = "Meses";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(21, 82);
            numericUpDown2.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 12;
            // 
            // gbxDuración
            // 
            gbxDuración.Controls.Add(numericUpDown2);
            gbxDuración.Controls.Add(lblMese);
            gbxDuración.Location = new Point(442, 136);
            gbxDuración.Name = "gbxDuración";
            gbxDuración.Size = new Size(336, 156);
            gbxDuración.TabIndex = 13;
            gbxDuración.TabStop = false;
            gbxDuración.Text = "Duración de la inscrpción";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(145, 31);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(180, 24);
            chkCasillero.TabIndex = 14;
            chkCasillero.Text = "Casillero(3.000 al mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // chkPaseLibre
            // 
            chkPaseLibre.AutoSize = true;
            chkPaseLibre.Location = new Point(399, 31);
            chkPaseLibre.Name = "chkPaseLibre";
            chkPaseLibre.Size = new Size(197, 24);
            chkPaseLibre.TabIndex = 15;
            chkPaseLibre.Text = "Pase Libre(30.000 al mes)";
            chkPaseLibre.UseVisualStyleBackColor = true;
            // 
            // gbxAdicionales
            // 
            gbxAdicionales.Controls.Add(chkPaseLibre);
            gbxAdicionales.Controls.Add(chkCasillero);
            gbxAdicionales.Location = new Point(17, 298);
            gbxAdicionales.Name = "gbxAdicionales";
            gbxAdicionales.Size = new Size(759, 84);
            gbxAdicionales.TabIndex = 16;
            gbxAdicionales.TabStop = false;
            gbxAdicionales.Text = "Servicios Adicionales";
            // 
            // chkEfectivo
            // 
            chkEfectivo.AutoSize = true;
            chkEfectivo.Location = new Point(5, 39);
            chkEfectivo.Name = "chkEfectivo";
            chkEfectivo.Size = new Size(84, 24);
            chkEfectivo.TabIndex = 17;
            chkEfectivo.Text = "Efectivo";
            chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // chkTarjeta
            // 
            chkTarjeta.AutoSize = true;
            chkTarjeta.Location = new Point(162, 39);
            chkTarjeta.Name = "chkTarjeta";
            chkTarjeta.Size = new Size(75, 24);
            chkTarjeta.TabIndex = 18;
            chkTarjeta.Text = "Tarjeta";
            chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(318, 28);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(54, 20);
            lblCuotas.TabIndex = 19;
            lblCuotas.Text = "Cuotas";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "3", "6" });
            comboBox3.Location = new Point(318, 67);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 20;
            // 
            // gbxPago
            // 
            gbxPago.Controls.Add(comboBox3);
            gbxPago.Controls.Add(lblCuotas);
            gbxPago.Controls.Add(chkTarjeta);
            gbxPago.Controls.Add(chkEfectivo);
            gbxPago.Location = new Point(17, 388);
            gbxPago.Name = "gbxPago";
            gbxPago.Size = new Size(495, 111);
            gbxPago.TabIndex = 21;
            gbxPago.TabStop = false;
            gbxPago.Text = "Forma de Pago";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(587, 405);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(149, 42);
            btnConfirmar.TabIndex = 22;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(587, 455);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(149, 42);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmGimnacio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(btnLimpiar);
            Controls.Add(btnConfirmar);
            Controls.Add(gbxPago);
            Controls.Add(gbxAdicionales);
            Controls.Add(gbxDuración);
            Controls.Add(gbxSeleccion);
            Controls.Add(gbxDatos);
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
