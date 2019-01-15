using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misClientes = new DataTable();

        public VentanaPrincipal()
        {
            InitializeComponent();
            misClientes = miConexion.getClientes();
            dataGridView1.DataSource = misClientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            misClientes = miConexion.getClientesPorNombre(textBox1.Text);
            label3.Text = misClientes.Rows[0]["nombre"].ToString();
        }

        //Método para cerrar la apliación entera cuando se cierra el form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }
    }
}
