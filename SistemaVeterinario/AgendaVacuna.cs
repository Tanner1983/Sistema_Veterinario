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
    public partial class AgendaVacuna : Form
    {
        public AgendaVacuna()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        string nomvacuna = "", idV="";
        int id = 0;

        private void btn_volver_Click(object sender, EventArgs e)
        {           
             this.Hide();
             Menu ss = new Menu();                
             ss.Show();            
        }

        private void AgendaVacuna_Load(object sender, EventArgs e)
        {
            DataTable dtV = fn.LlenarCmb("SELECT id_vacuna, nomvacuna FROM tb_vacunas");
            cmb_vac.DataSource = dtV;
            cmb_vac.ValueMember = "id_vacuna";
            cmb_vac.DisplayMember = "nomvacuna";
            cmb_vac.SelectedIndex = -1;
        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            txt_fecha.Text = calendario.SelectionRange.Start.ToShortDateString();
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
    }
}
