using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Clinica
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPacientes = new FormPacientes();
            formPacientes.MdiParent = this;
            formPacientes.Show();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMedicamentos = new FormMedicamentos();
            formMedicamentos.MdiParent = this;
            formMedicamentos.Show();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDoctores = new FormDoctores();
            formDoctores.MdiParent = this;
            formDoctores.Show();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }
    }
}
