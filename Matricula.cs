using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioParroquialInmaculada
{
    public partial class Matricula : Form
    {
        public Matricula()
        {
            InitializeComponent();
            Pagos.Items.Add("Matricula");
            Pagos.Items.Add("Domingo familiar");
            Pagos.Items.Add("Tarjetas");
        }

        private void Pagos_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
