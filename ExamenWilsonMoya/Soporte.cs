using Datos;
using System;
using System.Windows.Forms;

namespace ExamenWilsonMoya
{
    public partial class SoporteForm : Form
    {
        public SoporteForm()
        {
            InitializeComponent();
        }
        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();
        decimal precio = 0;
        decimal isv = 0;
        decimal totalAPagar = 0;
        decimal descuento = 0;

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            BuscarClienteForm form = new BuscarClienteForm();
            form.ShowDialog();
            miCliente = new Cliente();
            miCliente = form.cliente;
            IdentidadTextBox.Text = miCliente.Identidad;
            NombreClienteTextBox.Text = miCliente.Nombre;
        }

        private void SoporteForm_Load(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdentidadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdentidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadTextBox.Text))
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientePorIdentidad(IdentidadTextBox.Text);
                NombreClienteTextBox.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                NombreClienteTextBox.Clear();
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Factura registrada exitosamente");
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            miCliente = null;
            FechaDateTimePicker.Value = DateTime.Now;
            IdentidadTextBox.Clear();
            NombreClienteTextBox.Clear();
            comboBox1.Items.Clear();
            PreciotextBox.Clear();
            solicitudtextBox.Clear();
            RespuestatextBox.Clear();
            TotalTextBox.Clear();
            ISVTextBox.Clear();
            DescuentoTextBox.Clear();

        }

        private void solicitudtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuardarButton_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PreciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {



        }

        private void ISVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ISVTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

