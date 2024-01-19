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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prematricula prem = new Prematricula();
            prem.TopLevel = false;
            panel2.Controls.Add(prem);
            prem.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Estudiantes estu = new Estudiantes();
            estu.TopLevel = false;
            panel2.Controls.Add(estu);
            estu.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Matricula mat = new Matricula();
            mat.TopLevel = false;
            panel2.Controls.Add(mat);
            mat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagodeColegiatura colegiatura = new PagodeColegiatura();
            colegiatura.TopLevel = false;
            panel2.Controls.Add(colegiatura);
            colegiatura.Show();

        }
    }
}
