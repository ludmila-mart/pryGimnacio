
using System;
using System.Windows.Forms;


namespace pryGimnacio
{
    public partial class frmGimnacio : Form
    {
        // ETAPA 4: Constantes a nivel de clase
        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILLERO = 3000m;
        private const decimal PRECIO_PASE_LIBRE = 30000m;
        private const int EDAD_MINIMA = 14;
        private const decimal RECARGO_6_CUOTAS = 0.20m;
        private const decimal RECARGO_3_CUOTAS = 0.10m;
        private const decimal DESCUENTO_EFECTIVO = 0.10m;

        // ETAPA 10: struct SOCIO
        public struct SOCIO
        {
            public string Nombre;
            public int Edad;
            public string Categoria;
            public string Plan;
            public string Horario;
            public int Meses;
            public string FormaPago;
            public decimal Total;
            public decimal ValorCuota;
        }

        // CORREGIDO: el constructor también se llama frmGimnacio
        public frmGimnacio()
        {
            InitializeComponent();

            // Se desuscribe antes de suscribir para evitar que un evento
            // quede ejecutándose dos veces si el Designer ya lo conectó.
            btnConfirmar.Click -= btnConfirmar_Click;
            btnConfirmar.Click += btnConfirmar_Click;

            btnLimpiar.Click -= btnLimpiar_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            textBox1.KeyPress -= textBox1_KeyPress;
            textBox1.KeyPress += textBox1_KeyPress;

            chkTarjeta.CheckedChanged -= chkTarjeta_CheckedChanged;
            chkTarjeta.CheckedChanged += chkTarjeta_CheckedChanged;

            chkEfectivo.CheckedChanged -= chkEfectivo_CheckedChanged;
            chkEfectivo.CheckedChanged += chkEfectivo_CheckedChanged;
        }

        // CORREGIDO: se mantiene el nombre Form1_Load, que es el que el Designer
        // tiene asociado al evento Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Rangos de los NumericUpDown 
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 120;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 12;

            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("Musculación");
                comboBox1.Items.Add("Funcional");
                comboBox1.Items.Add("Natación");
            }

            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Items.Add("Mañana (7 a 12 h)");
                comboBox2.Items.Add("Tarde (14 a 18 h)");
                comboBox2.Items.Add("Noche (18 a 23 h)");
            }

            if (comboBox3.Items.Count == 0)
            {
                comboBox3.Items.Add("1");
                comboBox3.Items.Add("3");
                comboBox3.Items.Add("6");
            }

            EstadoInicial();
        }

        // ETAPA 3: estado inicial
        private void EstadoInicial()
        {
            textBox1.Clear();

            numericUpDown1.Value = 14;
            numericUpDown2.Value = 1;

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            chkPaseLibre.Checked = false;

            chkTarjeta.Checked = false;
            chkEfectivo.Checked = true;

            comboBox3.SelectedIndex = -1;
            comboBox3.Enabled = false;

            btnConfirmar.Enabled = true;
            textBox1.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        // ETAPA 5.a: solo letras y espacios, en mayúsculas
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }

            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        // ETAPA 8: Tarjeta habilita las cuotas
        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTarjeta.Checked)
            {
                chkEfectivo.Checked = false;
                comboBox3.Enabled = true;
                comboBox3.SelectedIndex = 0;
            }
            else
            {
                comboBox3.Enabled = false;
                comboBox3.SelectedIndex = -1;

                // Evita que queden los dos tildes apagados
                if (!chkEfectivo.Checked) chkEfectivo.Checked = true;
            }
        }

        private void chkEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEfectivo.Checked)
            {
                chkTarjeta.Checked = false;
                comboBox3.Enabled = false;
                comboBox3.SelectedIndex = -1;
            }
            else if (!chkTarjeta.Checked)
            {
                chkTarjeta.Checked = true;
            }
        }

        // ETAPAS 5.c a 10: botón Confirmar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del socio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            int edad = (int)numericUpDown1.Value;
            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("No puede inscribirse: la edad mínima es de 14 años.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int meses = (int)numericUpDown2.Value;
            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("Error: La cantidad de meses debe estar entre 1 y 12.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedItem == null || comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un plan y un turno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ETAPA 6: switch de plan y turno
            string planElegido = comboBox1.SelectedItem.ToString();
            decimal precioMensual;

            switch (planElegido)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natación":
                    precioMensual = PRECIO_NATACION;
                    break;
                default:
                    precioMensual = 0;
                    break;
            }

            // Pase libre: el precio mensual pasa a 30.000
            if (chkPaseLibre.Checked) precioMensual = PRECIO_PASE_LIBRE;

            string horarioTurno;
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    horarioTurno = "Mañana (7 a 12 h)";
                    break;
                case 1:
                    horarioTurno = "Tarde (14 a 18 h)";
                    break;
                case 2:
                    horarioTurno = "Noche (18 a 23 h)";
                    break;
                default:
                    horarioTurno = "No especificado";
                    break;
            }

            // ETAPA 7: casillero, subtotal y descuento
            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;

            decimal subtotal = precioMensual * meses;

            decimal porcentajeDescuento;
            if (edad < 18)
            {
                porcentajeDescuento = 0.25m;
            }
            else if (edad >= 65)
            {
                porcentajeDescuento = 0.30m;
            }
            else if (chkEstudiante.Checked)
            {
                porcentajeDescuento = 0.15m;
            }
            else
            {
                porcentajeDescuento = 0m;
            }

            decimal montoConDescuento = subtotal * (1 - porcentajeDescuento);

            // ETAPA 8: forma de pago
            decimal montoFinal;
            int cuotas = 1;
            bool esEfectivo = chkEfectivo.Checked;

            if (esEfectivo)
            {
                montoFinal = montoConDescuento * (1 - DESCUENTO_EFECTIVO);
            }
            else
            {
                if (comboBox3.SelectedItem != null)
                {
                    cuotas = int.Parse(comboBox3.SelectedItem.ToString());
                }

                if (cuotas == 3)
                {
                    montoFinal = montoConDescuento * (1 + RECARGO_3_CUOTAS);
                }
                else if (cuotas == 6)
                {
                    montoFinal = montoConDescuento * (1 + RECARGO_6_CUOTAS);
                }
                else
                {
                    montoFinal = montoConDescuento;
                }
            }

            // ETAPA 9: operador ternario
            string categoriaSocio = edad < 18 ? "Menor" : "Mayor";
            string textoPago = esEfectivo ? "Efectivo" : $"Tarjeta en {cuotas} cuotas";
            decimal valorCuotaCalculado = esEfectivo ? montoFinal : (montoFinal / cuotas);

            // ETAPA 10: struct y MessageBox
            SOCIO unSocio;
            unSocio.Nombre = textBox1.Text;
            unSocio.Edad = edad;
            unSocio.Categoria = categoriaSocio;
            unSocio.Plan = planElegido;
            unSocio.Horario = horarioTurno;
            unSocio.Meses = meses;
            unSocio.FormaPago = textoPago;
            unSocio.Total = montoFinal;
            unSocio.ValorCuota = valorCuotaCalculado;

            string mensaje = "--- RESUMEN DE INSCRIPCIÓN ---\n" +
                             $"Socio: {unSocio.Nombre} ({unSocio.Categoria})\n" +
                             $"Plan: {unSocio.Plan} - Turno: {unSocio.Horario}\n" +
                             $"Meses: {unSocio.Meses}\n" +
                             $"Forma de pago: {unSocio.FormaPago}\n" +
                             "----------------------------------\n" +
                             $"TOTAL A PAGAR: {unSocio.Total:C}\n" +
                             $"Valor de cuota: {unSocio.ValorCuota:C}";

            MessageBox.Show(mensaje, "Gimnasio Siglo - Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EstadoInicial();
        }
        public frmGimnacio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Evento predeterminado de NumericUpDown (lo necesita el Designer)
        }
    }
}


