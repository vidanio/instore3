using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace player
{
    public partial class MainForm : Form
    {
        private bool enable_salir = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!enable_salir)
            {
                e.Cancel = true;
                this.Hide();
                notifyBarIcon.ShowBalloonTip(100,"HMPro Player","Running in background", ToolTipIcon.Info);
            }
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer cerrar el programa ?", "Mucho Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                enable_salir = true;
                this.Close();
            }
        }

        private void notifyBarIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
