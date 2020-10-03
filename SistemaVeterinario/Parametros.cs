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
    public partial class Parametros : Form
    {
        public Parametros()
        {
            InitializeComponent();
        }

        Funciones fn = new Funciones();

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            grb_Desparasitacion.Visible = false;
            grb_Test.Visible = false;
        }

        private void Parametros_Load(object sender, EventArgs e)
        {
            bool conectado = fn.conectar();
            if (conectado)
            {
                /* MessageBox.Show("Conectado");*/
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }

            DataTable dt = fn.LlenarCmb("SELECT id_especie, nomespecie FROM tb_especie");
            cmb_esp.DataSource = dt;
            cmb_esp.ValueMember = "id_especie";
            cmb_esp.DisplayMember = "nomespecie";

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string esp = cmb_esp.SelectedIndex.ToString();         
            string agregar = "INSERT INTO `db_vetsnfco3`.`tb_raza` (`id_especie`,`nomraza`) VALUES('" + esp + "','" + txt_raza.Text + "')";
                    if (fn.InsertarParametros(agregar))
                    {
                        MessageBox.Show("Agregado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar Raza");
                    }
        }

        private void cmb_esp_Leave(object sender, EventArgs e)
        {
            string esp2 = cmb_esp.Text.ToString();            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            grb_Desparasitacion.Visible = false;
            grb_Test.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string agregar = "INSERT INTO `db_vetsnfco3`.`tb_vacunas` (`nomvacuna`,`desvacuna`) VALUES('" + txt_nomvac.Text + "','" + txt_desvac.Text + "')";
            if (fn.InsertarParametros(agregar))
            {
                MessageBox.Show("Agregado Correctamente");
                txt_nomvac.Text = "";
                txt_desvac.Text = "";
            }
            else
            {
                MessageBox.Show("Error al insertar nueva Vacuna");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string modo = cmb_modo.Text.ToString();            
            string agregar = "INSERT INTO `db_vetsnfco3`.`tb_desparasitacion` (`mododes`,`nomdes`,`tipodes`) VALUES('" + modo + "','" + txt_nomDes.Text + "','" + txt_tipo.Text + "')";
            if (fn.InsertarParametros(agregar))
            {
                MessageBox.Show("Agregado Correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar nueva Vacuna");
            }
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            grb_Desparasitacion.Visible = true;
            grb_Test.Visible = false;
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            grb_Desparasitacion.Visible = false;
            grb_Test.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string agregar = "INSERT INTO `db_vetsnfco3`.`tb_test` (`nomtest`,`destest`) VALUES('" + txt_nomTest.Text + "','" + txt_des.Text + "')";
            if (fn.InsertarParametros(agregar))
            {
                MessageBox.Show("Agregado Correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar nueva Vacuna");
            }
        }
    }
}
