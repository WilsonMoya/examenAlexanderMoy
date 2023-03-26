using System;
using System.Windows.Forms;

namespace ExamenWilsonMoya
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void reclamarTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoporteForm SopFormulario = new SoporteForm();
            SopFormulario.MdiParent = this;
            SopFormulario.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
