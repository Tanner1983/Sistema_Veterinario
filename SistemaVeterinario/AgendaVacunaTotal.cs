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
    public partial class AgendaVacunaTotal : Form
    {
        public AgendaVacunaTotal()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        string nomvacuna = "", idV = "";
        int id = 0;

        private void AgendaVacunaTotal_Load(object sender, EventArgs e)
        {
            DataTable dtV = fn.LlenarCmb("SELECT id_vacuna, nomvacuna FROM tb_vacunas");
            cmb_vac.DataSource = dtV;
            cmb_vac.ValueMember = "id_vacuna";
            cmb_vac.DisplayMember = "nomvacuna";
            cmb_vac.SelectedIndex = -1;
        }

        private void cmb_vac_Leave(object sender, EventArgs e)
        {
            DataRowView oDataRowView = cmb_vac.SelectedItem as DataRowView;
            if (oDataRowView != null)
            {
                nomvacuna = oDataRowView.Row["nomvacuna"] as string;
            }
            idV = cmb_vac.SelectedIndex.ToString();
            txt_id_vacuna.Text = idV;
        }

        private void calendario_Leave(object sender, EventArgs e)
        {
            txt_fecha.Text = calendario.SelectionRange.Start.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fichas ss = new Fichas();
            ss.btn_selectconsulta.Visible = false;
            ss.btn_selectVacuna.Visible = true;
            ss.btn_select.Visible = false;
            ss.Show();
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txt_id.Text);
            DataTable dt = fn.ObtenerDatos("SELECT * FROM tb_paciente WHERE `id_paciente`='" + id + "'");
            txt_nombre.Text = (string)dt.Rows[0][1];
        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime();
            fecha = DateTime.Parse(txt_fecha.Text);
            string x = fecha.ToString("yyyy/MM/dd");

            DateTime hora = new DateTime();
            hora = DateTime.Parse(msktxt_hora.Text);
            string h = hora.ToString("hh:mm:ss");

            string revisar = "SELECT `id_agenda`,`fvacunacion`,`hvacunacion` FROM tb_agendavacuna WHERE `fvacunacion`='" + x + "'AND `hvacunacion`='" + h + "'";
            if (fn.ValidarFecha(revisar))
            {
                MessageBox.Show("Hora ya registrada");
            }
            else
            {
                string agregar = "INSERT INTO `db_vetsnfco3`.`tb_agendavacuna` (`id_paciente`,`nompac`,`id_vacuna`,`nomvacuna`,`fvacunacion`,`hvacunacion`,`desvacunacion`) VALUES('" + id + "','" + txt_nombre.Text + "','" + idV + "','" + nomvacuna + "','" + x + "','" + h + "','" + txt_obs.Text + "')";
                if (fn.InsertarPropietario(agregar))
                {
                    MessageBox.Show("Agendado");
                }
                else
                {
                    MessageBox.Show("Error al agendar la hora");
                }
            }

            
        }

        private void txt_fecha_Leave(object sender, EventArgs e)
        {            
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agenda ss = new Agenda();
            ss.Show();
        }
    }
}
