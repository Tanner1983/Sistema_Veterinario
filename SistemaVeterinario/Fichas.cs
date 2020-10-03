using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace SistemaVeterinario
{
    public partial class Fichas : Form
    {
        public Fichas()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        DataTable fichas = new DataTable();
        string Nombre = "";

        private void btn_volver_Click(object sender, EventArgs e)
        {
           
        }

        private void Fichas_Load(object sender, EventArgs e)
        {
            toolBack.SetToolTip(this.pick_back, "Vuelve al menú");
            DataTable fichas = fn.ObtenerDatos("SELECT paciente.*, dueno.rutprop, dueno.nomprop, dueno.mailprop, dueno.fonoprop FROM tb_paciente AS paciente INNER JOIN tb_propietario AS dueno ON paciente.rutprop = dueno.rutprop ORDER BY paciente.id_paciente");
            dtg_Fichas.DataSource = fichas;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void TxtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            dtg_Fichas.DataSource = fn.ObtenerDatos("Select * from tb_paciente WHERE nompac LIKE('" + TxtFiltrar.Text + "%')");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            Nombre = dtg_Fichas.CurrentRow.Cells[0].Value.ToString();
            this.Hide();
            FichaPaciente ss = new FichaPaciente();
            ss.txt_id.Text = Nombre;
            ss.txt_id.Select();
            ss.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Nombre = dtg_Fichas.CurrentRow.Cells[0].Value.ToString();
            this.Hide();
            AgendaVacunaTotal ss = new AgendaVacunaTotal();
            ss.txt_id.Text = Nombre;
            ss.txt_id.Select();
            ss.Show();
        }

        private void btn_detalle_Click(object sender, EventArgs e)
        {
            Nombre = dtg_Fichas.CurrentRow.Cells[0].Value.ToString();
            this.Hide();
            detalleFichas ss = new detalleFichas();
            ss.lbl_id.Text = "N° de Paciente: " +Nombre;
            ss.txt_id.Text = Nombre;
            ss.Show();          
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Nombre = dtg_Fichas.CurrentRow.Cells[2].Value.ToString();
            this.Hide();
            DetalleClientes ss = new DetalleClientes();            
            ss.txt_rutpro.Text = Nombre;
            ss.Show();
        }

        private void pick_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }
    }
}
