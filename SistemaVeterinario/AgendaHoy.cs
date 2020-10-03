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
    public partial class AgendaHoy : Form
    {
        public AgendaHoy()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();            
            Menu ss = new Menu();
            ss.notificacionvacuna.Visible = false;
            ss.Show();
        }

        private void AgendaHoy_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            DateTime ayer = DateTime.Now;
            DateTime manana = DateTime.Now;
            string x = hoy.ToString("yyyy/MM/dd");

            ayer = hoy.AddDays(-1);
            manana = hoy.AddDays(+1);
            string a = ayer.ToString("yyyy/MM/dd");
            string b = manana.ToString("yyyy/MM/dd");           

            DataTable fichas = fn.ObtenerDatos("SELECT agenda.id_paciente, agenda.nomvacuna, agenda.fvacunacion, agenda.hvacunacion, paciente.nompac, paciente.rutprop, dueno.nomprop, dueno.fonoprop FROM tb_agendavacuna AS agenda INNER JOIN tb_paciente AS paciente ON agenda.id_paciente = paciente.id_paciente INNER JOIN tb_propietario AS dueno ON paciente.rutprop = dueno.rutprop WHERE `fvacunacion`='" + x + "' OR `fvacunacion`='" + a + "' OR `fvacunacion`='" + b + "'");
            dtg_agendahoy.DataSource = fichas;
        }
    }
}
