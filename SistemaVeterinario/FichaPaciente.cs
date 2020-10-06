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
    public partial class FichaPaciente : Form
    {
        public FichaPaciente()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        string conducta = "", desh, linf, mucosas = "", pa = "",oo="", nb="",di="",cr="",me="",ne="",gu="",gp="";
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }

        private void FichaPaciente_Load(object sender, EventArgs e)
        {
            txt_des.Text = "0";
            toolbuscar.SetToolTip(this.pick_buscar, "Permite buscar el id");
            toolcargar.SetToolTip(this.pick_cargar, "Permite cargar datos encontrados");
            toolvolver.SetToolTip(this.pick_back, "Vuelve al menú");
            toolsave.SetToolTip(this.pick_guardar, "Guarda la ficha del paciente");
        }

        private void txt_motivo_TextChanged(object sender, EventArgs e)
        {
            string texto = txt_motivo.Text;
            int caracter = texto.Length;
            lbl_MV.Text = "(" + (caracter.ToString()) + ")";            
        }

        private void txt_diag_TextChanged(object sender, EventArgs e)
        {
            string texto = txt_diag.Text;
            int caracter = texto.Length;
            lbl_Diag.Text = "(" + (caracter.ToString()) + ")";
        }

        private void txt_trata_TextChanged(object sender, EventArgs e)
        {
            string texto = txt_trata.Text;
            int caracter = texto.Length;
            Lbl_Trat.Text = "(" + (caracter.ToString()) + ")";
        }

        private void txt_obs_TextChanged(object sender, EventArgs e)
        {
            string texto = txt_obs.Text;
            int caracter = texto.Length;
            Lbl_Obs.Text = "(" + (caracter.ToString()) + ")";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void chk_rosada_CheckedChanged(object sender, EventArgs e)
        {
            txt_omucosas.Visible = false;
            mucosas = chk_rosada.Text;
            chk_palida.Checked = false; chk_motras.Checked = false; chk_ciano.Checked = false; chk_icte.Checked = false;
        }

        private void chk_palida_CheckedChanged(object sender, EventArgs e)
        {
            txt_omucosas.Visible = false;
            mucosas = chk_palida.Text;
            chk_rosada.Checked = false; chk_motras.Checked = false; chk_ciano.Checked = false; chk_icte.Checked = false;
        }

        private void chk_ciano_CheckedChanged(object sender, EventArgs e)
        {
            txt_omucosas.Visible = false;
            mucosas = chk_ciano.Text;
            chk_palida.Checked = false; chk_motras.Checked = false; chk_rosada.Checked = false; chk_icte.Checked = false;
        }

        private void chk_icte_CheckedChanged(object sender, EventArgs e)
        {
            txt_omucosas.Visible = false;
            mucosas = chk_icte.Text;
            chk_palida.Checked = false; chk_motras.Checked = false; chk_rosada.Checked = false; chk_ciano.Checked = false;
        }

        private void chk_motras_CheckedChanged(object sender, EventArgs e)
        {
            txt_omucosas.Visible = true;            
            chk_palida.Checked = false; chk_ciano.Checked = false; chk_rosada.Checked = false; chk_icte.Checked = false;
        }

        private void txt_omucosas_Leave(object sender, EventArgs e)
        {
            mucosas = txt_omucosas.Text;
        }

        private void pick_buscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fichas ss = new Fichas();
            ss.btn_selectconsulta.Visible = false;
            ss.btn_selectVacuna.Visible = false;
            ss.btn_select.Visible = true;
            ss.Show();
        }

        private void pick_cargar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_id.Text);
                DataTable dt = fn.ObtenerDatos("SELECT * FROM tb_paciente WHERE `id_paciente`='" + id + "'");

                DateTime fecha = new DateTime();
                fecha = Convert.ToDateTime(dt.Rows[0][7]);
                DateTime hoy = DateTime.Now;
                int edad = hoy.Year - fecha.Year;

                txt_NomPac.Text = (string)dt.Rows[0][1];
                txt_nompro.Text = (string)dt.Rows[0][2];
                txt_raza.Text = (string)dt.Rows[0][4];
                txt_sexo.Text = (string)dt.Rows[0][5];
                txt_color.Text = (string)dt.Rows[0][6];
                txt_edad.Text = edad.ToString();
                txt_nchip.Text = Convert.ToString((int)dt.Rows[0][9]);
                txt_cast.Text = (string)dt.Rows[0][10];
                txt_celo.Text = (string)dt.Rows[0][11];
                txt_ta.Text = (string)dt.Rows[0][13];
                txt_recl.Text = (string)dt.Rows[0][12];
                txt_marca.Text = (string)dt.Rows[0][14];
                txt_fa.Text = Convert.ToString((int)dt.Rows[0][15]);
                txt_ep.Text = (string)dt.Rows[0][16];
                txt_ma.Text = (string)dt.Rows[0][17];
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
            Menu ss = new Menu();
            ss.Show();
        }

        private void pick_guardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string x = DateTime.Now.ToString("yyyy-MM-dd");
            /*DateTime fecha = new DateTime();
             * string x = fecha.ToString("yyyy/MM/dd");*/
            if (rb_normal.Checked) { linf = "N"; } else if (rb_anormal.Checked) { linf = "A"; }
            if (rb_pa_n.Checked) { pa = "N"; } else if (rb_pa_a.Checked) { pa = "A"; } else if (rb_pa_ne.Checked) { pa = "E"; }
            if (rb_oo_n.Checked) { oo = "N"; } else if (rb_oo_a.Checked) { oo = "A"; } else if (rb_oo_ne.Checked) { oo = "E"; }
            if (rb_nb_n.Checked) { nb = "N"; } else if (rb_nb_a.Checked) { nb = "A"; } else if (rb_nb_ne.Checked) { nb = "E"; }
            if (rb_d_n.Checked) { di = "N"; } else if (rb_d_a.Checked) { di = "A"; } else if (rb_d_ne.Checked) { di = "E"; }
            if (rb_cr_n.Checked) { cr = "N"; } else if (rb_cr_a.Checked) { cr = "A"; } else if (rb_cr_ne.Checked) { cr = "E"; }
            if (rb_me_n.Checked) { me = "N"; } else if (rb_me_a.Checked) { me = "A"; } else if (rb_me_ne.Checked) { me = "E"; }
            if (rb_n_n.Checked) { ne = "N"; } else if (rb_n_a.Checked) { ne = "A"; } else if (rb_n_ne.Checked) { ne = "E"; }
            if (rb_gu_n.Checked) { gu = "N"; } else if (rb_gu_a.Checked) { gu = "A"; } else if (rb_gu_ne.Checked) { gu = "E"; }
            if (rb_gp_n.Checked) { gp = "N"; } else if (rb_gp_a.Checked) { gp = "A"; } else if (rb_gp_ne.Checked) { gp = "E"; }

            string agregar = @"INSERT INTO `db_vetsnfco3`.`tb_historiapaciente` 
                            (`id_paciente`,`fechavisita`, `exaficonducta`,`exafipeso`,`exafifrecar`,`exafifrres`,`exafitemp`,`exafidesh`,`exafipord`,`exafimucosas`,`exafilinfo`,`exafitllc`,`exafipa`,`exafioo`,`exafinb`,`exafidi`,`exaficr`,`exafime`,`exafine`,`exafigu`,`exafigp`,`motivisita`,`anamvisita`,`diagvisita`,`tratvisita`,`obsevisita`) 
                            VALUES
                            ('" + id + "','" + x + "','" + conducta + "','" + txt_peso.Text + "','" + txt_fc.Text + "','" + txt_fr.Text + "','" + txt_temp.Text + "','" + desh + "','" + txt_des.Text + "','" + mucosas + "','" + linf + "','" + txt_tllc.Text + "','" + pa + "','" + oo + "','" + nb + "','" + di + "','" + cr + "','" + me + "','" + ne + "','" + gu + "','" + gp + "','" + txt_motivo.Text + "','" + txt_anam.Text + "','" + txt_diag.Text + "','" + txt_trata.Text + "','" + txt_obs.Text + "')";
            if (fn.InsertarPropietario(agregar))
            {
                MessageBox.Show("Agregado");
                DialogResult result = MessageBox.Show("Desea Agendar vacunacion", "Agenda Vacunas ?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    AgendaVacuna ss = new AgendaVacuna();
                    ss.txt_id.Text = txt_id.Text;
                    ss.txt_nombre = txt_NomPac;
                    ss.Show();
                }
                else
                {
                    this.Hide();
                    Menu ss = new Menu();
                    ss.Show();
                }
            }
            else
            {
                MessageBox.Show("Error al insertar datos del Paciente");
            }
        }

        private void txt_anam_TextChanged(object sender, EventArgs e)
        {
            string texto = txt_anam.Text;
            int caracter = texto.Length;
            lbl_am.Text = "(" + (caracter.ToString()) + ")";
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_id_KeyUp(object sender, KeyEventArgs e)
        {
            

        }

        private void txt_nompro_Leave(object sender, EventArgs e)
        {
           
        }

        private void btn_carga_Click(object sender, EventArgs e)
        {
            
            
        }

        private void chk_conducta_Leave(object sender, EventArgs e)
        {
           
        }       

        private void chk_otro_CheckedChanged(object sender, EventArgs e)
        {
            txt_oconducta.Visible = true;
        }

        private void chk_aler_CheckedChanged(object sender, EventArgs e)
        {
            txt_oconducta.Visible = false;
            conducta = chk_aler.Text;
            chk_depr.Checked = false; chk_inco.Checked = false; chk_otro.Checked = false;
        }

        private void chk_depr_CheckedChanged(object sender, EventArgs e)
        {
            txt_oconducta.Visible = false;
            conducta = chk_depr.Text;
            chk_aler.Checked = false; chk_inco.Checked = false; chk_otro.Checked = false;
        }

        private void chk_inco_CheckedChanged(object sender, EventArgs e)
        {
            txt_oconducta.Visible = false;
            conducta = chk_inco.Text;
            chk_depr.Checked = false; chk_aler.Checked = false; chk_otro.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_des.Visible = true;lbl_por.Visible = true;
            desh = "S";
        }

        private void rb_desn_CheckedChanged(object sender, EventArgs e)
        {
            txt_des.Visible = false; lbl_por.Visible = false;
            desh = "N";
        }

        private void txt_oconducta_Leave(object sender, EventArgs e)
        {
            chk_depr.Checked = false; chk_inco.Checked = false; chk_aler.Checked = false;
            conducta = txt_oconducta.Text;
        }
    }
}
