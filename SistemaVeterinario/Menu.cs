using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeterinario
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Funciones fn = new Funciones();
        protected void notificacion()
        {
            try {
                notificacionvacuna.Text = "Sistema veterianrio";
                notificacionvacuna.Visible = true;
                notificacionvacuna.BalloonTipTitle = "Notificacion";
                notificacionvacuna.BalloonTipText = "Texto de prueba";
                notificacionvacuna.BalloonTipIcon = ToolTipIcon.Info;             

                notificacionvacuna.ShowBalloonTip(3000);
            }
            catch (Exception ex) {

            }
            
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            FormIngreso ss = new FormIngreso();
            ss.Show();
        }

        private void pictureBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Parametros ss = new Parametros();
            ss.Show();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            Fichas ss = new Fichas();
            ss.btn_selectVacuna.Visible = false;
            ss.btn_select.Visible = false;
            ss.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agenda ss = new Agenda();
            ss.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FichaPaciente ss = new FichaPaciente();
            ss.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;            
            string x = hoy.ToString("yyyy/MM/dd");
            DateTime ayer = DateTime.Now;
            DateTime manana = DateTime.Now;
            
            ayer = hoy.AddDays(-1);
            manana = hoy.AddDays(+1);
            string a = ayer.ToString("yyyy/MM/dd");
            string b = manana.ToString("yyyy/MM/dd");            

            string revisar = "SELECT * FROM tb_agendavacuna WHERE `fvacunacion`='" + x + "' OR `fvacunacion`='" + a + "' OR `fvacunacion`='" + b + "'";
            if (fn.ValidarFecha(revisar))
            {
                notificacion();
                
            }
            else
            {
                notificacionvacuna.Visible = false;
            }
            
        }

        private void notificacionvacuna_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LA wea wena csmaiden");
            notificacionvacuna.Visible = false;
            this.Hide();
            AgendaHoy ss = new AgendaHoy();
            ss.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
