using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MustafaKESKİN2
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void btnLaboratory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratory form2 = new Laboratory();
            form2.Show();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project form3 = new Project();
            form3.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Autor programu: Mustafa Emirhan KESKIN. Nr albumu: 64481.");
        }
    }
}