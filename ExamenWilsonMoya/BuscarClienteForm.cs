using Datos;
using System;
using System.Windows.Forms;

namespace ExamenWilsonMoya
{
    public partial class BuscarClienteForm : Form
    {
        public BuscarClienteForm()
        {
            InitializeComponent();
        }
        ClienteDB clienteDB = new ClienteDB();
        public Cliente cliente = new Cliente();
        private void BuscarClienteForm_Load(object sender, EventArgs e)
        {
            ClientesDataGridView.DataSource = clienteDB.DevolverClientes();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (ClientesDataGridView.SelectedRows.Count > 0)
            {
                cliente.Identidad = ClientesDataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                cliente.Nombre = ClientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                cliente.Telefono = ClientesDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                cliente.Correo = ClientesDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                cliente.Direccion = ClientesDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                cliente.FechaNacimiento = Convert.ToDateTime(ClientesDataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                cliente.EstaActivo = Convert.ToBoolean(ClientesDataGridView.CurrentRow.Cells["EstaActivo"].Value);
                this.Close();
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NombreTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ClientesDataGridView.DataSource = clienteDB.DevolverClientesPorNombre(NombreTextBox.Text);
        }

        private void AceptarButton_Click_1(object sender, EventArgs e)
        {
            if (ClientesDataGridView.SelectedRows.Count > 0)
            {
                cliente.Identidad = ClientesDataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                cliente.Nombre = ClientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                cliente.Telefono = ClientesDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                cliente.Correo = ClientesDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                cliente.Direccion = ClientesDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                cliente.FechaNacimiento = Convert.ToDateTime(ClientesDataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                cliente.EstaActivo = Convert.ToBoolean(ClientesDataGridView.CurrentRow.Cells["EstaActivo"].Value);
                this.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelarButton_Click_1(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ClientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

