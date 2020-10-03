using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace SistemaVeterinario
{
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }
        Funciones fn = new Funciones();
        string raza = "", falim="", sexo = "", tchip="", conv = "", cast="", celo="", ta="",recl="", marca = "", notest="",indtest="", nomvacuna=""; /*Variable comboBox*/
        int prueba = 0, deuda=0, edad=0;
        bool existe;
        private void textBox13_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.SoloLetras(e);
            if (e.KeyChar == (char)(Keys.Enter))
            {                
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_rutpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_dir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {                
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_comun_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.SoloLetras(e);
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_fono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.SoloNumeros(e);
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                cmb_con.SelectedIndex =0;
            }
        }

        private void cmb_con_KeyPress(object sender, KeyPressEventArgs e)
        {           
           if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_NomPac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmb_esp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmb_raza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmb_sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_color_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.SoloLetras(e);
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                cmb_chip.SelectedIndex = 1;

            }
        }

        private void cmb_chip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_nchip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmb_cast_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmb_celo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                cmb_recl.SelectedIndex = 0;
            }
        }

        private void cmb_recl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmb_tipoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(txt_fechV.MaskedTextProvider);
            DateTime fecha = new DateTime();
            fecha = DateTime.Parse(a);
            string x = fecha.ToString("yyyy/MM/dd");
            
            string b = cmb_vac.SelectedIndex.ToString();
            int b2 = Convert.ToInt32(b);

            ListViewItem lista = new ListViewItem(b);
            lista.SubItems.Add(nomvacuna);
            lista.SubItems.Add(a);
            lv_vacunas.Items.Add(lista);
            cmb_vac.SelectedIndex = 0;
            txt_fechV.Text = "";           

        }

        private void cmb_desp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(cmb_desp.SelectedIndex);
            if (a == 0)
            {
                txt_nomdesp.Enabled = true;
                cmb_tipodes.Enabled = false;
            }
            else
            {
                cmb_tipodes.Enabled = true;
                txt_nomdesp.Enabled = false;
            }

        }

        private void cmb_con_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string indcon = cmb_con.SelectedIndex.ToString();
            if (indcon == "0")
            {
                conv = "No";
            }
            else if (indcon == "1")
            {
                conv = "Fun";
            }
            else if (indcon == "2")
            {
                conv = "Doc";
            }
            else
            {
                conv = "Mun";
            }
        }

        private void cmb_sex_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string indsex = cmb_con.SelectedIndex.ToString();
            if (indsex == "0")
            {
                sexo = "Macho";
            }
            else
            {
                sexo = "Hembra";
            }
        }

        private void cmb_chip_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string indchi = cmb_chip.SelectedIndex.ToString();
            if (indchi == "0")
            {
                tchip = "Si";
                txt_nchip.Enabled = true;
            }
            else
            {
                tchip = "No";
                txt_nchip.Enabled = false;
                txt_nchip.Text = "0";
            }
        }

        private void cmb_tipoA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string indta = cmb_tipoA.SelectedIndex.ToString();
            if (indta == "0")
            {
                ta = "Marca";
            }
            else if (indta == "1")
            {
                ta = "Casera";
            }
            else
            {
                ta = "Mixto";
            }
        }

        private void cmb_recl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string indre = cmb_recl.SelectedIndex.ToString();
            if (indre == "0")
            {
                recl = "Hogar";
            }
            else if (indre == "1")
            {
                recl = "Patio";
            }
            else if (indre == "2")
            {
                recl = "Mixto";
            }else
            {
                recl = "Calle";
            }
        }

        private void cmb_celo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string indcelo = cmb_celo.SelectedIndex.ToString();
            if (indcelo == "0")
            {
                celo = "A";
            }
            else
            {
                celo = "P";
            }
        }

        private void cmb_cast_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string indcas = cmb_cast.SelectedIndex.ToString();
            if (indcas == "0")
            {
                cast = "S";
            }
            else
            {
                cast = "N";
            }
        }

        private void cmb_test_Leave(object sender, EventArgs e)
        {
            DataRowView oDataRowView = cmb_test.SelectedItem as DataRowView;
            if (oDataRowView != null)
            {
                notest = oDataRowView.Row["nomtest"] as string;
            }           
        }

        private void cmb_raza_Leave(object sender, EventArgs e)
        {
            DataRowView oDataRowView = cmb_raza.SelectedItem as DataRowView;          
            if (oDataRowView != null)
            {
                raza = oDataRowView.Row["nomraza"] as string;
            }           
        }

        private void cmb_test_SelectedIndexChanged(object sender, EventArgs e)
        {
            notest = cmb_test.SelectedText.ToString();
        }

        private void cmb_raza_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cmb_raza_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_vac_Leave(object sender, EventArgs e)
        {
            DataRowView oDataRowView = cmb_vac.SelectedItem as DataRowView;
            if (oDataRowView != null)
            {
                nomvacuna = oDataRowView.Row["nomvacuna"] as string;
            }
        }

        private void cmb_tipoA_Leave(object sender, EventArgs e)
        {
            string indta = cmb_tipoA.SelectedIndex.ToString();
            if (indta == "0") { txt_marca.Visible = true; lbl_marca.Visible = true; }
            else { txt_marca.Visible = false; lbl_marca.Visible = false;marca = "No aplica"; }
        }

        private void txt_marca_Leave(object sender, EventArgs e)
        {
            marca = txt_marca.Text;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void pick_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }

        private void cmb_falim_Leave(object sender, EventArgs e)
        {
           falim = cmb_falim.SelectedIndex.ToString();           
        }

        private void cmb_raza_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FichaPaciente ss = new FichaPaciente();
            ss.txt_NomPac.Text = txt_NomPac.Text;
            ss.Show();
        }

        private void cmb_raza_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_deuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        

        private void cmb_esp_Leave(object sender, EventArgs e)
        {
            string esp = cmb_esp.SelectedIndex.ToString();
            DataTable dt = fn.LlenarCmbRaza("SELECT * FROM `tb_raza` WHERE id_especie ="+esp);
            cmb_raza.DataSource = dt;
            cmb_raza.ValueMember = "id_raza";
            cmb_raza.DisplayMember = "nomraza";
        }

        private void btn_AgregaTest_Click(object sender, EventArgs e)
        {
            indtest = cmb_test.SelectedIndex.ToString();
            /*notest = cmb_test.SelectedText.ToString();*/
            ListViewItem lista = new ListViewItem(indtest);
            lista.SubItems.Add(notest);
            lv_test.Items.Add(lista);
            cmb_test.SelectedIndex = 0;        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ind = cmb_desp.SelectedIndex.ToString();
            string indT = cmb_tipodes.SelectedIndex.ToString();
            string desp = "",tipo="";
            if (ind == "0")
            {
                desp = "Externa";
            }
            else {
                desp = "Interna";
            }

            if (indT == "0")
            {
                tipo = "Gotas";
            }
            else if (indT == "1")
            {
                tipo = "Pastillas";
            }
            else
            {
                tipo = "No aplica";
            }
            string a = txt_fechad.Text;
            DateTime fecha = new DateTime();
            fecha = DateTime.Parse(a);
            string x = fecha.ToString("yyyy/MM/dd");
            ListViewItem item = new ListViewItem();
            item = lv_desp.Items.Add(ind);
            item.SubItems.Add(desp);
            item.SubItems.Add(x);
            item.SubItems.Add(tipo);
            item.SubItems.Add(txt_nomdesp.Text);
            cmb_tipodes.SelectedIndex = -1;
            txt_nomdesp.Text = "";
            txt_fechad.Text = "";
            cmb_desp.SelectedIndex = -1;          
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (GroupBox c in this.Controls.OfType<GroupBox>())
            {
                c.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = "");
            }
            txt_fecha.Text = string.Empty;
            txt_fechad.Text = string.Empty;
            txt_fechV.Text = string.Empty;
            lv_desp.Items.Clear();
            lv_vacunas.Items.Clear();
            lv_desp.Items.Clear();
            cmb_raza.SelectedIndex = -1;
            cmb_esp.SelectedIndex = -1;
            cmb_vac.SelectedIndex = -1;
            cmb_test.SelectedIndex = -1;
            cmb_esp.SelectedIndex = -1;
            cmb_cast.SelectedIndex = -1;
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            toolback.SetToolTip(this.pick_back, "Vuelve al menú");
            bool conectado = fn.conectar();
            if (conectado)
            {
               /* MessageBox.Show("Conectado");*/
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
            /* 	*/
            DataTable dt = fn.LlenarCmb("SELECT id_especie, nomespecie FROM tb_especie");
            cmb_esp.DataSource = dt;
            cmb_esp.ValueMember = "id_especie";
            cmb_esp.DisplayMember = "nomespecie";
            cmb_esp.SelectedIndex = -1;

            DataTable dtV = fn.LlenarCmb("SELECT id_vacuna, nomvacuna FROM tb_vacunas");
            cmb_vac.DataSource = dtV;
            cmb_vac.ValueMember = "id_vacuna";
            cmb_vac.DisplayMember = "nomvacuna";
            cmb_vac.SelectedIndex = -1;

            DataTable dtT = fn.LlenarCmb("SELECT id_test, nomtest FROM tb_test");
            cmb_test.DataSource = dtT;
            cmb_test.ValueMember = "id_test";
            cmb_test.DisplayMember = "nomtest";
            cmb_test.SelectedIndex = -1;

            prueba = fn.A();
            prueba = prueba + 1;
            label28.Text = prueba.ToString();

            txt_deuda.Text = "0";
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nchip = Int32.Parse(txt_nchip.Text);
            int fono = Int32.Parse(txt_fono.Text);
            deuda = Int32.Parse(txt_deuda.Text);
            string mail = txt_email.Text;
            string esp = cmb_esp.SelectedIndex.ToString();                    
            /*raza = cmb_raza.SelectedText.ToString();*/

            string a = txt_fecha.Text;
            DateTime hoy = DateTime.Now;

            DateTime fecha = new DateTime();
            
            fecha = DateTime.Parse(a);
            edad = hoy.Year - fecha.Year -1;            
            string x = fecha.ToString("yyyy/MM/dd");

            if (existe == true)
            {
                string agregar2 = @"INSERT INTO `db_vetsnfco3`.`tb_paciente` (`nomPac`, `rutprop`, `id_especie`,`raza`, `sexopac`, `colopac`, `fechpac`, `chip`, `nchipac`, `castpac`, `celopac`, `reclpac`, `tapac`, `Malimento`, `falimentacion`, `enfprevias`, `medprevias`) 
                                  VALUES('" + txt_NomPac.Text + "','" + txt_rutpro.Text + "','" + esp + "','" + raza + "','" + sexo + "','" + txt_color.Text + "','" + x + "','" + tchip + "','" + nchip + "','" + cast + "','" + celo + "','" + recl + "','" + ta + "','" + marca + "','" + falim + "','" + txt_enfpre.Text + "','" + txt_medact.Text + "')";
                if (fn.InsertarPaciente(agregar2))
                {
                    /* Carga de listView Test*/
                    for (int i = 0; i < lv_test.Items.Count; i++)
                    {
                        indtest = lv_test.Items[i].SubItems[0].Text;
                        notest = lv_test.Items[i].SubItems[1].Text;
                        string agregar = "INSERT INTO `db_vetsnfco3`.`tb_regtest` (`id_paciente`,`id_test`,`nomtest`) VALUES('" + prueba + "','" + indtest + "','" + notest + "')";
                        if (fn.InsertarDatosMedicos(agregar))
                        {
                           /* MessageBox.Show("Agregado");*/
                        }
                        else
                        {
                            MessageBox.Show("Error al insertar Test");
                        }
                    }
                    /* Carga de listView Vacunas*/                   
                    for (int i = 0; i < lv_vacunas.Items.Count; i++)
                    {
                        string idV = lv_vacunas.Items[i].SubItems[0].Text;
                        string nom = lv_vacunas.Items[i].SubItems[1].Text;
                        DateTime fechav = new DateTime();
                        fechav = Convert.ToDateTime(lv_vacunas.Items[i].SubItems[2].Text);                        
                        string f = fecha.ToString("yyyy/MM/dd");

                        string agregar = "INSERT INTO `db_vetsnfco3`.`tb_regvacuna` (`id_paciente`, `id_vacuna`, `nomvacuna`, `fecha_vacuna`) VALUES('" + prueba + "','" + Convert.ToInt32(idV) + "','" + nom + "','" + f + "')";
                        if (fn.InsertarDatosMedicos(agregar))
                        {
                            /* MessageBox.Show("Agregado");*/
                        }
                        else
                        {
                            MessageBox.Show("Error al insertar Vacuna");
                        }
                    }
                    /* Carga de listView Desparacitacion*/
                    for (int i = 0; i < lv_desp.Items.Count; i++)
                    {
                        string modo = lv_desp.Items[i].SubItems[0].Text;
                        string f = lv_desp.Items[i].SubItems[1].Text;
                        string tipo = lv_desp.Items[i].SubItems[1].Text;
                        string nombre = lv_desp.Items[i].SubItems[1].Text;
                        string agregar = "INSERT INTO `db_vetsnfco3`.`tb_regdes` (`id_paciente`,`mododes`,`fechdes`,`tip_desp`,`des_desp`) VALUES('" + prueba + "','" + modo + "','" + f + "','" + tipo + "','" + nombre + "')";
                        if (fn.InsertarDatosMedicos(agregar))
                        {
                            /* MessageBox.Show("Agregado");*/
                        }
                        else
                        {
                            MessageBox.Show("Error al insertar Desparacitacion");
                        }
                    
                    }

                    DialogResult result = MessageBox.Show("Desea ir a Ficha medica", "Ficha medica ?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        FichaPaciente ss = new FichaPaciente();
                        ss.txt_id.Text = prueba.ToString();
                        ss.txt_NomPac.Text = txt_NomPac.Text;
                        ss.txt_nompro.Text = txt_nompro.Text;
                        ss.txt_raza.Text = raza;
                        ss.txt_sexo.Text = sexo;
                        ss.txt_color.Text = txt_color.Text;
                        ss.txt_edad.Text = edad.ToString();
                        ss.txt_nchip.Text = nchip.ToString();
                        ss.txt_cast.Text = cast;
                        ss.txt_celo.Text = celo;
                        ss.txt_recl.Text = recl;
                        ss.txt_ta.Text = ta;
                        ss.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Error al insertar datos del Paciente");
                }
            }
            else
            {
                string agregar = "INSERT INTO `db_vetsnfco3`.`tb_propietario` (`rutprop`, `nomprop`, `mailprop`, `dirprop`, `comunprop`, `fonoprop`, `convprop`, `rdeuda`) VALUES('" + txt_rutpro.Text + "','" + txt_nompro.Text + "','" + mail + "','" + txt_dir.Text + "','" + txt_comun.Text + "','" + fono + "','" + conv + "','" + deuda + "')";
                if (fn.InsertarPropietario(agregar))
                {
                    /*MessageBox.Show("Agregado");*/
                    string agregar2 = "INSERT INTO `db_vetsnfco3`.`tb_paciente` (`nomPac`, `rutprop`, `id_especie`,`raza`, `sexopac`, `colopac`, `fechpac`, `chip`, `nchipac`, `castpac`, `celopac`, `reclpac`, `tapac`) VALUES('" + txt_NomPac.Text + "','" + txt_rutpro.Text + "','" + esp + "','" + raza + "','" + sexo + "','" + txt_color.Text + "','" + x + "','" + tchip + "','" + nchip + "','" + cast + "','" + celo + "','" + recl + "','" + ta + "')";
                    if (fn.InsertarPaciente(agregar2))
                    {
                        /* Carga de listView Test*/
                        for (int i = 0; i < lv_test.Items.Count; i++)
                        {
                            indtest = lv_test.Items[i].SubItems[0].Text;
                            notest = lv_test.Items[i].SubItems[1].Text;
                            string agregar3 = "INSERT INTO `db_vetsnfco3`.`tb_regtest` (`id_paciente`,`id_test`,`nomtest`) VALUES('" + prueba + "','" + indtest + "','" + notest + "')";
                            if (fn.InsertarDatosMedicos(agregar))
                            {
                                /* MessageBox.Show("Agregado");*/
                            }
                            else
                            {
                                MessageBox.Show("Error al insertar Test");
                            }
                        }
                        /* Carga de listView Vacunas*/
                        for (int i = 0; i < lv_vacunas.Items.Count; i++)
                        {
                            string idV = lv_vacunas.Items[i].SubItems[0].Text;
                            string nom = lv_vacunas.Items[i].SubItems[1].Text;
                            DateTime fechav = new DateTime();
                            fechav = Convert.ToDateTime(lv_vacunas.Items[i].SubItems[2].Text);
                            string f = fecha.ToString("yyyy/MM/dd");

                            string agregar3 = "INSERT INTO `db_vetsnfco3`.`tb_regvacuna` (`id_paciente`, `id_vacuna`, `nomvacuna`, `fecha_vacuna`) VALUES('" + prueba + "','" + Convert.ToInt32(idV) + "','" + nom + "','" + f + "')";
                            if (fn.InsertarDatosMedicos(agregar))
                            {
                                /* MessageBox.Show("Agregado");*/
                            }
                            else
                            {
                                MessageBox.Show("Error al insertar Vacuna");
                            }
                        }
                        /* Carga de listView Desparacitacion*/
                        for (int i = 0; i < lv_desp.Items.Count; i++)
                        {
                            string modo = lv_desp.Items[i].SubItems[0].Text;
                            string f = lv_desp.Items[i].SubItems[1].Text;
                            string tipo = lv_desp.Items[i].SubItems[1].Text;
                            string nombre = lv_desp.Items[i].SubItems[1].Text;
                            string agregar3 = "INSERT INTO `db_vetsnfco3`.`tb_regdes` (`id_paciente`,`mododes`,`fechdes`,`tip_desp`,`des_desp`) VALUES('" + prueba + "','" + modo + "','" + f + "','" + tipo + "','" + nombre + "')";
                            if (fn.InsertarDatosMedicos(agregar))
                            {
                                /* MessageBox.Show("Agregado");*/
                            }
                            else
                            {
                                MessageBox.Show("Error al insertar Desparacitacion");
                            }

                        }
                        DialogResult result = MessageBox.Show("Desea ir a Ficha medica", "Ficha medica ?", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            this.Hide();
                            FichaPaciente ss = new FichaPaciente();
                            ss.txt_id.Text = prueba.ToString();
                            ss.txt_NomPac.Text = txt_rutpro.Text + ", " + txt_NomPac.Text;
                            ss.txt_nompro.Text = txt_nompro.Text;
                            ss.txt_raza.Text = raza;
                            ss.txt_sexo.Text = sexo;
                            ss.txt_color.Text = txt_color.Text;
                            ss.txt_edad.Text = edad.ToString(); 
                            ss.txt_nchip.Text = nchip.ToString();
                            ss.txt_cast.Text = cast;
                            ss.txt_celo.Text = celo;
                            ss.txt_recl.Text = recl;
                            ss.txt_ta.Text = ta;
                            ss.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar datos del Paciente");
                    }
                }
                else
                {
                    MessageBox.Show("Error al insertar datos del propietario");
                }
            }
            
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txt_email.Text, expresion))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txt_email,"Ingrese un correo electronico válido");
                txt_email.Focus();
                return;
            }
        }

        private void txt_rutpro_Leave(object sender, EventArgs e)
        {
           if (fn.validarRut(txt_rutpro.Text))
            {
                Funciones auxR = new Funciones();
                this.txt_rutpro.Text = auxR.formatear(this.txt_rutpro.Text);
            }
            else
            {
                MessageBox.Show("Rut inválido");
                txt_rutpro.Focus();
            }
            string rut = txt_rutpro.Text;
            string Buscar = "SELECT * FROM tb_propietario WHERE `rutprop`='" +rut+"'";            
            if (fn.BuscarRut(Buscar))
            {
                existe = true;
                MessageBox.Show("Usuario ya esta registrado");
                DataTable dt = fn.ObtenerDatos("SELECT * FROM tb_propietario WHERE `rutprop`='" + rut + "'");
                txt_nompro.Text = (string)dt.Rows[0][2];
                txt_email.Text = (string)dt.Rows[0][3];
                txt_dir.Text = (string)dt.Rows[0][4];
                txt_comun.Text = (string)dt.Rows[0][5];
                txt_fono.Text = Convert.ToString((int)dt.Rows[0][6]);
                txt_deuda.Text = Convert.ToString((int)dt.Rows[0][8]);
                txt_nompro.ReadOnly = true;
                txt_email.ReadOnly = true;
                txt_dir.ReadOnly = true;
                txt_comun.ReadOnly = true;
                txt_fono.ReadOnly = true;
                txt_deuda.ReadOnly = true;
            }
            else
            {
                existe = false;
            }

        }
        
    }
}
