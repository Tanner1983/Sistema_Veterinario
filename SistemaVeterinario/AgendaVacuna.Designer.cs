namespace SistemaVeterinario
{
    partial class AgendaVacuna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_volver = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id_vacuna = new System.Windows.Forms.TextBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_vac = new System.Windows.Forms.ComboBox();
            this.msktxt_hora = new System.Windows.Forms.MaskedTextBox();
            this.btn_agendar = new System.Windows.Forms.Button();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(424, 341);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 43);
            this.btn_volver.TabIndex = 0;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(97, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(48, 22);
            this.txt_id.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(284, 32);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_id_vacuna
            // 
            this.txt_id_vacuna.Enabled = false;
            this.txt_id_vacuna.Location = new System.Drawing.Point(96, 77);
            this.txt_id_vacuna.Name = "txt_id_vacuna";
            this.txt_id_vacuna.Size = new System.Drawing.Size(48, 22);
            this.txt_id_vacuna.TabIndex = 3;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(15, 187);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 6;
            this.calendario.Leave += new System.EventHandler(this.monthCalendar1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "id Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "id vacuna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vacuna";
            // 
            // cmb_vac
            // 
            this.cmb_vac.FormattingEnabled = true;
            this.cmb_vac.Location = new System.Drawing.Point(283, 77);
            this.cmb_vac.Name = "cmb_vac";
            this.cmb_vac.Size = new System.Drawing.Size(121, 24);
            this.cmb_vac.TabIndex = 12;
            this.cmb_vac.Leave += new System.EventHandler(this.cmb_vac_Leave);
            // 
            // msktxt_hora
            // 
            this.msktxt_hora.Location = new System.Drawing.Point(284, 115);
            this.msktxt_hora.Mask = "00:00";
            this.msktxt_hora.Name = "msktxt_hora";
            this.msktxt_hora.Size = new System.Drawing.Size(57, 22);
            this.msktxt_hora.TabIndex = 14;
            this.msktxt_hora.ValidatingType = typeof(System.DateTime);
            // 
            // btn_agendar
            // 
            this.btn_agendar.Location = new System.Drawing.Point(329, 341);
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.Size = new System.Drawing.Size(75, 43);
            this.btn_agendar.TabIndex = 15;
            this.btn_agendar.Text = "Agendar";
            this.btn_agendar.UseVisualStyleBackColor = true;
            this.btn_agendar.Click += new System.EventHandler(this.btn_agendar_Click);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(96, 115);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 22);
            this.txt_fecha.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hora";
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(96, 153);
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(308, 22);
            this.txt_obs.TabIndex = 19;
            // 
            // AgendaVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(536, 402);
            this.Controls.Add(this.txt_obs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.btn_agendar);
            this.Controls.Add(this.msktxt_hora);
            this.Controls.Add(this.cmb_vac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.txt_id_vacuna);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_volver);
            this.Name = "AgendaVacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendaVacuna";
            this.Load += new System.EventHandler(this.AgendaVacuna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.TextBox txt_id_vacuna;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_vac;
        private System.Windows.Forms.MaskedTextBox msktxt_hora;
        private System.Windows.Forms.Button btn_agendar;
        public System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_obs;
    }
}