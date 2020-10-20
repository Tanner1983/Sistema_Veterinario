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
    public partial class VerAgenda : Form
    {
        public VerAgenda()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        string asistencia = "", idc = "";
        private void VerAgenda_Load(object sender, EventArgs e)
        {
            toolBack.SetToolTip(this.pick_back, "Vuelve al menú");
            toolAsistencia.SetToolTip(this.pick_vacuna, "Guardar Asistencia");

            DataTable fichas = fn.ObtenerDatos("SELECT * FROM tb_agendavacuna WHERE asistenciav='" + "N" + "'");
            dtg_vacuna.DataSource = fichas;

            DataTable fichas2 = fn.ObtenerDatos("SELECT * FROM tb_agendaconsulta WHERE asistenciac='" + "N" + "'");
            dtg_consulta.DataSource = fichas2;
        }

        private void pick_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agenda ss = new Agenda();           
            ss.Show();
        }

        private void VerAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dtg_consulta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            pick_vacuna.Focus();
        }

        private void pick_consulta_Click(object sender, EventArgs e)
        {
            idc = dtg_consulta.CurrentRow.Cells[0].Value.ToString();
            asistencia = dtg_consulta.CurrentRow.Cells[6].Value.ToString();

            DialogResult result = MessageBox.Show("Desea Guardar los cambios", "Modificar Asistencia ?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string modificar = @"UPDATE tb_agendaconsulta SET 
                                       asistenciac='" + asistencia + "' WHERE id_consulta ='" + idc + "'";
                    if (fn.Modificar(modificar))
                    {
                        MessageBox.Show("Agenda modificada correctamente");
                        DataTable fichas2 = fn.ObtenerDatos("SELECT * FROM tb_agendaconsulta");
                        dtg_consulta.DataSource = fichas2;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }


            }
        }

        private void pick_asis_Click(object sender, EventArgs e)
        {
            idc = dtg_vacuna.CurrentRow.Cells[0].Value.ToString();
            asistencia = dtg_vacuna.CurrentRow.Cells[8].Value.ToString();

            DialogResult result = MessageBox.Show("Desea Guardar los cambios", "Modificar Asistencia ?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string modificar = @"UPDATE tb_agendavacuna SET 
                                       asistenciav='" + asistencia + "' WHERE id_agenda ='" + idc + "'";
                    if (fn.Modificar(modificar))
                    {
                        MessageBox.Show("Agenda modificada correctamente");
                        DataTable fichas2 = fn.ObtenerDatos("SELECT * FROM tb_agendavacuna");
                        dtg_vacuna.DataSource = fichas2;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }


            }
        }
    }
}
