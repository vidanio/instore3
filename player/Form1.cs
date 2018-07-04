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
        private bool enable_admin = false; // when 1st configured change it to true

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!enable_salir)
            {
                e.Cancel = true; // no cierra, evita el cierre del Form y por tanto de la app
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtboxMusicFolder.Text = @"C:\";
            fldbrwMusicFolder.SelectedPath = txtboxMusicFolder.Text;
            if (!enable_admin) tabMenu.SelectTab(2);
            else tabMenu.SelectTab(0);
            // ToolTips de todos los controles
            //    toolTipMain.SetToolTip(this.tabMusic,this.tabMusic.ToolTipText);

        }

        private void txtboxMusicFolder_Click(object sender, EventArgs e)
        {
            if (fldbrwMusicFolder.ShowDialog() == DialogResult.OK)
            {
                txtboxMusicFolder.Text = fldbrwMusicFolder.SelectedPath;
            }
        }

        private void txtboxMessage_Click(object sender, EventArgs e)
        {
            if (openMsgToPlay.ShowDialog() == DialogResult.OK)
            {
                txtboxMessage.Text = openMsgToPlay.FileName;
            }
        }

        private void tbarMusic_Scroll(object sender, EventArgs e)
        {
            if (tbarMusic.Value >= tbarMin.Value)
                lblMusicVol.Text = tbarMusic.Value.ToString();
            else {
                tbarMusic.Value = tbarMin.Value;
            }
        }

        private void tbarPubli_Scroll(object sender, EventArgs e)
        {
            if (tbarPubli.Value >= tbarMin.Value)
                lblPubliVol.Text = tbarPubli.Value.ToString();
            else
            {
                tbarPubli.Value = tbarMin.Value;
            }
        }

        private void tbarMsg_Scroll(object sender, EventArgs e)
        {
            if (tbarMsg.Value >= tbarMin.Value)
                lblMsgVol.Text = tbarMsg.Value.ToString();
            else
            {
                tbarMsg.Value = tbarMin.Value;
            }
        }

        private void tbarMin_Scroll(object sender, EventArgs e)
        {
            // calculamos el maximo valor que puede tener FadeOut
            int max = 0;

            max = Math.Min(tbarMusic.Value, tbarPubli.Value);
            max = Math.Min(max, tbarMsg.Value);

            if (max >= tbarMin.Value)
                lblFadeVol.Text = tbarMin.Value.ToString();
            else
            {
                tbarMin.Value = max;
            }
        }

        private void timeDesde_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(timeDesde.Value, timeHasta.Value) > 0)
            {
                timeDesde.Value = timeHasta.Value;
            }
        }

        private void timeHasta_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(timeDesde.Value, timeHasta.Value) > 0)
            {
                timeHasta.Value = timeDesde.Value;
            }
        }

        private void btnURLServer_Click(object sender, EventArgs e)
        {
            errorSignal.Clear();
            if ((txtboxURLServer.Text.Contains("http://") == false) && (txtboxURLServer.Text.Contains("https://") == false))
            {
                errorSignal.SetError(txtboxURLServer, "URL no válida !!!");
            }
        }

        private void tabMenu_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!enable_admin) return; // You must configure all 1st before accessing the rest of tabs
            if (e.TabPageIndex == 2)
            {
                MessageBox.Show("This is the admin area");
                // si queremos que se quede en el mismo tab y no pase al 2 (admin) ponemos:
                // e.Cancel = true;

                // Cosas del axWMP control: (https://docs.microsoft.com/es-es/windows/desktop/WMP/object-model-reference-for-scripting) 
                // axWMPMain.URL                            -> string con la URL del fichero a reproducir o la ruta OpenFileDialog.FileName
                // axWMPMain.Ctlcontrols.play()             -> play
                // axWMPMain.Ctlcontrols.stop()             -> stop
                // axWMPMain.settings.volume                -> int de 0 a 100
                // axWMPMain.settings.mute                  -> bool
                // axWMPMain.currentMedia.duration          -> devuelve double con la duración en segundos del media actual
                // axWMPMain.Ctlcontrols.currentPosition    -> devuelve double con la posición actual de reproducción del media actual
                // axWMPMain.currentMedia.name              -> devuelve string con el nombre del media actual
                // axWMPMain.Ctlcontrols.currentItem.name   -> devuelve string con el nombre del media actual
                // axWMPMain.playState                      -> enum  WMPLib.WMPPlayState.wmppsPlaying/wmppsReady/wmppsMediaEnded
                // (int) axWMPMain.playState                -> int 3/10/8 (https://docs.microsoft.com/es-es/windows/desktop/WMP/player-playstate)
                // axWMPMain.PlayStateChange                -> evento
            }
        }
    }
}
