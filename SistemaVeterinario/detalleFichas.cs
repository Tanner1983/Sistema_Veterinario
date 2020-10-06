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
    public partial class detalleFichas : Form
    {
        public detalleFichas()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        DataTable fichas = new DataTable();
        int idp;
        string chip = "";
        private void btn_back_Click(object sender, EventArgs e)
        {
            
        }

        private void detalleFichas_Load(object sender, EventArgs e)
        {
            toolBack.SetToolTip(this.pick_back, "Vuelve al menú");
            tooleliminar.SetToolTip(this.pick_eliminar, "Elimina al Paciente");
            toolmodificar.SetToolTip(this.pickEditar, "Modifica el Paciente");

            int id = Convert.ToInt32(txt_id.Text);
            try
            {                
                DataTable dt = fn.ObtenerDatos("SELECT paciente.*, dueno.* FROM tb_paciente AS paciente INNER JOIN tb_propietario AS dueno ON paciente.rutprop = dueno.rutprop WHERE paciente.id_paciente='" + id + "'");

                DateTime fecha = new DateTime();
                fecha = Convert.ToDateTime(dt.Rows[0][7]);
                DateTime hoy = DateTime.Now;
                int edad = hoy.Year - fecha.Year;
                idp = (int)dt.Rows[0][0]; 
                int indes= (int)dt.Rows[0][3];

                txt_NomPac.Text = (string)dt.Rows[0][1];
                txt_rutpro.Text = (string)dt.Rows[0][2];
                txt_raza.Text = (string)dt.Rows[0][4];
                txt_sexo.Text = (string)dt.Rows[0][5];
                txt_color.Text = (string)dt.Rows[0][6];
                txt_edad.Text = edad.ToString();
                txt_nchip.Text = Convert.ToString((int)dt.Rows[0][9]);
                txt_cast.Text = (string)dt.Rows[0][10];
                txt_celo.Text = (string)dt.Rows[0][11];
                txt_ta.Text = (string)dt.Rows[0][13];
                txt_rcl.Text = (string)dt.Rows[0][12];
                txt_marca.Text = (string)dt.Rows[0][14];
                txt_fa.Text = Convert.ToString((int)dt.Rows[0][15]);
                txt_enfpre.Text = (string)dt.Rows[0][16];
                txt_medact.Text = (string)dt.Rows[0][17];
                txt_nompro.Text = (string)dt.Rows[0][20];
                txt_email.Text = (string)dt.Rows[0][21];
                txt_dir.Text = (string)dt.Rows[0][22];
                txt_comun.Text = (string)dt.Rows[0][23];
                txt_fono.Text = Convert.ToString((int)dt.Rows[0][24]);
                txt_conv.Text = (string)dt.Rows[0][25];
                txt_deuda.Text = Convert.ToString((int)dt.Rows[0][26]);

                DataTable dt2 = fn.LlenarCmb("SELECT id_especie, nomespecie FROM tb_especie");
                cmb_esp.DataSource = dt2;
                cmb_esp.ValueMember = "id_especie";
                cmb_esp.DisplayMember = "nomespecie";
                cmb_esp.SelectedIndex = indes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                DataTable fichas = fn.ObtenerDatos("SELECT * FROM `tb_historiapaciente` WHERE `id_paciente`='" + id + "'");
                dtg_historial.DataSource = fichas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void pick_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fichas ss = new Fichas();
            ss.btn_select.Visible = false;
            ss.btn_selectVacuna.Visible = false;
            ss.Show();
        }

        private void pick_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Eliminar al paciente", "Eliminar Paciente ?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DialogResult result2 = MessageBox.Show("Si elimina los datos del Paciente, se eliminan todo su historial, Esta seguro?", "Eliminar Paciente ?", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                {
                    try
                    {
                        string eliminar = "DELETE FROM tb_paciente where id_paciente ='" + idp + "'";
                        if (fn.Eliminar(eliminar))
                        {
                            MessageBox.Show("Paciente eliminado correctamente");
                            this.Hide();
                            Fichas ss = new Fichas();
                            ss.btn_select.Visible = false;
                            ss.btn_selectVacuna.Visible = false;
                            ss.Show();
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

        private void pickEditar_Click(object sender, EventArgs e)
        {
            int nchip = Int32.Parse(txt_nchip.Text);
            int fa = Int32.Parse(txt_fa.Text);


            DialogResult result = MessageBox.Show("Desea Guardar los cambios", "Modificar Cliente ?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try {
                    string modificar = @"UPDATE tb_paciente SET 
                                       nomPac='" + txt_NomPac.Text + "',raza='" + txt_raza.Text + "', sexopac='" + txt_sexo.Text + "', colopac = '" + txt_color.Text + "', chip ='" + chip + "', nchipac ='" + nchip + "', reclpac='" + txt_rcl.Text + "', tapac='" + txt_ta.Text + "', Malimento='" + txt_marca.Text + "', falimentacion='" + fa + "', enfprevias='" + txt_enfpre.Text + "', medprevias='" + txt_medact.Text + "' WHERE id_paciente ='" + idp + "'";
                    if (fn.Modificar(modificar))
                    {
                        MessageBox.Show("Paciente modificado correctamente");
                        this.Hide();
                        Fichas ss = new Fichas();
                        ss.btn_select.Visible = false;
                        ss.btn_selectVacuna.Visible = false;
                        ss.Show();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
                
            }
        }

        private void txt_nchip_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_nchip_TextChanged(object sender, EventArgs e)
        {
            int val = Int32.Parse(txt_nchip.Text);
            if (val > 0)
            {
                chip = "S";
            }
            else
            {
                chip = "N";
            }
        }
    }
}
