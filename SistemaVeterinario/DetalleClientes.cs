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
    public partial class DetalleClientes : Form
    {
        public DetalleClientes()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        DataTable fichas = new DataTable();

        private void DetalleClientes_Load(object sender, EventArgs e)
        {
            toolback.SetToolTip(this.pick_back, "Vuelve al menú");
            toolEditar.SetToolTip(this.pickEditar, "Modifica datos del cliente");
            toolEliminar.SetToolTip(this.pick_eliminar, "Elimina al cliente");

            string rut = txt_rutpro.Text;
            try
            {
                DataTable dt = fn.ObtenerDatos("SELECT * FROM tb_propietario WHERE rutprop='" + rut + "'");               

                txt_nompro.Text = (string)dt.Rows[0][2];
                txt_email.Text = (string)dt.Rows[0][3];
                txt_dir.Text = (string)dt.Rows[0][4];
                txt_comun.Text = (string)dt.Rows[0][5];
                txt_fono.Text = Convert.ToString((int)dt.Rows[0][6]);
                txt_conv.Text = (string)dt.Rows[0][7];
                txt_deuda.Text = Convert.ToString((int)dt.Rows[0][8]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                DataTable fichas = fn.ObtenerDatos("SELECT * FROM `tb_paciente` WHERE `rutprop`='" + rut + "'");
                dtg_mascotas.DataSource = fichas;
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
            DialogResult result = MessageBox.Show("Desea Eliminar al ciente", "Eliminar Cliente ?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DialogResult result2 = MessageBox.Show("Si elimina los datos del cliente, se eliminan sus mascotas, Esta seguro?", "Eliminar Cliente ?", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                {
                    MessageBox.Show("Cliente eliminado correctamente");
                    this.Hide();
                    Fichas ss = new Fichas();
                    ss.btn_select.Visible = false;
                    ss.btn_selectVacuna.Visible = false;
                    ss.Show();
                }
            }
        }
    }
}
