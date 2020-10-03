using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemaVeterinario
{
    public partial class Login : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=db_vetsnfco;user=root;Pwd='';SslMode=none");
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string pass = txt_pass.Text;
            try
            {
                cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM tb_usuario where usuario='" + txt_user.Text + "' AND pass='" + txt_pass.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    Menu ss = new Menu();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Ingreso invalido, revisar Usuario y contraseña", "Ingreso incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
