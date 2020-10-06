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
    public partial class AgendaConsulta : Form
    {
        public AgendaConsulta()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();        
        int id = 0;

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fichas ss = new Fichas();
            ss.btn_selectconsulta.Visible = true;
            ss.btn_selectVacuna.Visible = false;
            ss.btn_select.Visible = false;
            ss.Show();
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txt_id.Text);
            DataTable dt = fn.ObtenerDatos("SELECT paciente.*, dueno.rutprop, dueno.nomprop, dueno.fonoprop, dueno.mailprop FROM tb_paciente AS paciente INNER JOIN tb_propietario AS dueno ON paciente.rutprop = dueno.rutprop WHERE paciente.id_paciente='" + id + "'");
            txt_nombre.Text = (string)dt.Rows[0][1];
            txt_nombreP.Text = (string)dt.Rows[0][19];
            txt_mail.Text = (string)dt.Rows[0][21];
            txt_fono.Text = Convert.ToString((int)dt.Rows[0][20]);
        }

        private void AgendaConsulta_Load(object sender, EventArgs e)
        {
            toolBack.SetToolTip(this.pick_back, "Vuelve al menú");
            toolguardar.SetToolTip(this.pick_guardar, "Agendar Consulta");
        }
    }
}
