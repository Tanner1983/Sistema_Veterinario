using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace SistemaVeterinario
{
    class Funciones
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=db_vetsnfco3;user=root;Pwd='';SslMode=none");
        private MySqlCommand cmd;
        private MySqlCommandBuilder cmbuilder;
        private MySqlDataAdapter da;
        MySqlDataReader consultar;
        private DataSet ds;
        private DataTable dt;
        public bool conectar()
        {
            bool conectado = false;

            try
            {
                con.Open();
                conectado = true;

            }
            catch (MySqlException ex)
            {
                conectado = false;
            }
            finally
            {
                con.Close();
            }
            return conectado;
        }

        public bool InsertarPropietario(string consulta)
        {
            bool agregado = false;
            int rows = 0;
            con.Open();
            cmd = new MySqlCommand(consulta, con);
            rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                agregado = true;
            }
            con.Close();
            return agregado;
        }

        public bool InsertarParametros(string consulta)
        {
            bool agregado = false;
            int rows = 0;
            con.Open();
            cmd = new MySqlCommand(consulta, con);
            rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                agregado = true;
            }
            con.Close();
            return agregado;
        }

        public bool InsertarPaciente(string consulta)
        {
            bool agregado = false;
            int rows = 0;
            con.Open();
            cmd = new MySqlCommand(consulta, con);
            rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                agregado = true;
            }
            con.Close();
            return agregado;
        }
        public bool InsertarDatosMedicos(string consulta)
        {
            bool agregado = false;
            int rows = 0;
            con.Open();
            cmd = new MySqlCommand(consulta, con);
            rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                agregado = true;
            }
            con.Close();
            return agregado;
        }
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Datos Válidos");
            }
        }

        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Ingrese Solo Numeros");
            }
        }

        public String formatear(String rut)
        {
            int cont = 0;
            String format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {

                    format = rut.Substring(i, 1) + format;

                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }

        public bool validarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        public DataTable LlenarCmb(string consulta)
        {
            con.Open();
            cmd = new MySqlCommand(consulta, con);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable LlenarCmbRaza(string consulta)
        {
            con.Open();
            cmd = new MySqlCommand(consulta, con);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            da.Fill(dt);
            con.Close();
            return dt;
        }

        public int A()
        {
            string stmt = "SELECT LAST_INSERT_ID(id_paciente)from tb_paciente order by LAST_INSERT_ID(id_paciente) desc limit 1";
            int count = 0;

            using (con)
            {
                using (MySqlCommand cmdCount = new MySqlCommand(stmt, con))
                {
                    con.Open();
                    count = Convert.ToInt32(cmdCount.ExecuteScalar());
                }
            }
            con.Close();
            return count;
        }
        public bool BuscarRut(string consulta)
        {
            bool buscar = false;
            con.Open();
            cmd = new MySqlCommand(consulta, con);
            consultar = cmd.ExecuteReader();
            while (consultar.Read())
            {
                buscar = true;

            }
            con.Close();
            return buscar;
        }

        public DataTable ObtenerDatos(string consulta)
        {
            con.Open();
            cmd = new MySqlCommand(consulta, con);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool ValidarFecha(string consulta)
        {
            bool validado = false;            
            con.Open();
            cmd = new MySqlCommand(consulta, con);
            consultar = cmd.ExecuteReader();

            while(consultar.Read())
            {
                validado = true;
            }
            con.Close();
            return validado;
        }

    }
        
}
