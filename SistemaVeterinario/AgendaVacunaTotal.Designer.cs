namespace SistemaVeterinario
{
    partial class AgendaVacunaTotal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.btn_agendar = new System.Windows.Forms.Button();
            this.msktxt_hora = new System.Windows.Forms.MaskedTextBox();
            this.cmb_vac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.txt_id_vacuna = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_obs);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.btn_agendar);
            this.groupBox1.Controls.Add(this.msktxt_hora);
            this.groupBox1.Controls.Add(this.cmb_vac);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.calendario);
            this.groupBox1.Controls.Add(this.txt_id_vacuna);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.btn_volver);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendamiento de Vacunación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Observacion";
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(106, 104);
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(362, 22);
            this.txt_obs.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(106, 135);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 22);
            this.txt_fecha.TabIndex = 29;
            this.txt_fecha.Leave += new System.EventHandler(this.txt_fecha_Leave);
            // 
            // btn_agendar
            // 
            this.btn_agendar.Location = new System.Drawing.Point(347, 348);
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.Size = new System.Drawing.Size(75, 37);
            this.btn_agendar.TabIndex = 28;
            this.btn_agendar.Text = "Agendar";
            this.btn_agendar.UseVisualStyleBackColor = true;
            this.btn_agendar.Click += new System.EventHandler(this.btn_agendar_Click);
            // 
            // msktxt_hora
            // 
            this.msktxt_hora.Location = new System.Drawing.Point(347, 135);
            this.msktxt_hora.Mask = "00:00";
            this.msktxt_hora.Name = "msktxt_hora";
            this.msktxt_hora.Size = new System.Drawing.Size(57, 22);
            this.msktxt_hora.TabIndex = 27;
            this.msktxt_hora.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_vac
            // 
            this.cmb_vac.FormattingEnabled = true;
            this.cmb_vac.Location = new System.Drawing.Point(347, 72);
            this.cmb_vac.Name = "cmb_vac";
            this.cmb_vac.Size = new System.Drawing.Size(121, 24);
            this.cmb_vac.TabIndex = 26;
            this.cmb_vac.Leave += new System.EventHandler(this.cmb_vac_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Vacuna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "id vacuna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "id Paciente";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(12, 178);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 21;
            this.calendario.Leave += new System.EventHandler(this.calendario_Leave);
            // 
            // txt_id_vacuna
            // 
            this.txt_id_vacuna.Enabled = false;
            this.txt_id_vacuna.Location = new System.Drawing.Point(106, 70);
            this.txt_id_vacuna.Name = "txt_id_vacuna";
            this.txt_id_vacuna.Size = new System.Drawing.Size(48, 22);
            this.txt_id_vacuna.TabIndex = 20;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(347, 40);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 19;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(106, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(48, 22);
            this.txt_id.TabIndex = 18;
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(464, 348);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 37);
            this.btn_volver.TabIndex = 17;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // AgendaVacunaTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(579, 448);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgendaVacunaTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendaVacunaTotal";
            this.Load += new System.EventHandler(this.AgendaVacunaTotal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Button btn_agendar;
        private System.Windows.Forms.MaskedTextBox msktxt_hora;
        private System.Windows.Forms.ComboBox cmb_vac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.TextBox txt_id_vacuna;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.Label label8;
    }
}