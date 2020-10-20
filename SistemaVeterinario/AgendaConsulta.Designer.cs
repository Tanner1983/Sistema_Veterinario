namespace SistemaVeterinario
{
    partial class AgendaConsulta
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
            this.components = new System.ComponentModel.Container();
            this.AgConsulta = new System.Windows.Forms.GroupBox();
            this.pick_guardar = new System.Windows.Forms.PictureBox();
            this.pick_back = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fono = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_nombreP = new System.Windows.Forms.TextBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.msktxt_hora = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.toolguardar = new System.Windows.Forms.ToolTip(this.components);
            this.toolBack = new System.Windows.Forms.ToolTip(this.components);
            this.AgConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pick_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_back)).BeginInit();
            this.SuspendLayout();
            // 
            // AgConsulta
            // 
            this.AgConsulta.Controls.Add(this.pick_guardar);
            this.AgConsulta.Controls.Add(this.pick_back);
            this.AgConsulta.Controls.Add(this.label8);
            this.AgConsulta.Controls.Add(this.label7);
            this.AgConsulta.Controls.Add(this.label4);
            this.AgConsulta.Controls.Add(this.label2);
            this.AgConsulta.Controls.Add(this.txt_fono);
            this.AgConsulta.Controls.Add(this.txt_mail);
            this.AgConsulta.Controls.Add(this.txt_nombreP);
            this.AgConsulta.Controls.Add(this.txt_obs);
            this.AgConsulta.Controls.Add(this.btn_buscar);
            this.AgConsulta.Controls.Add(this.label6);
            this.AgConsulta.Controls.Add(this.label5);
            this.AgConsulta.Controls.Add(this.txt_fecha);
            this.AgConsulta.Controls.Add(this.msktxt_hora);
            this.AgConsulta.Controls.Add(this.label3);
            this.AgConsulta.Controls.Add(this.label1);
            this.AgConsulta.Controls.Add(this.calendario);
            this.AgConsulta.Controls.Add(this.txt_nombre);
            this.AgConsulta.Controls.Add(this.txt_id);
            this.AgConsulta.Location = new System.Drawing.Point(12, 12);
            this.AgConsulta.Name = "AgConsulta";
            this.AgConsulta.Size = new System.Drawing.Size(555, 424);
            this.AgConsulta.TabIndex = 1;
            this.AgConsulta.TabStop = false;
            this.AgConsulta.Text = "Agendamiento de Consulta";
            // 
            // pick_guardar
            // 
            this.pick_guardar.Image = global::SistemaVeterinario.Properties.Resources.save_78935;
            this.pick_guardar.Location = new System.Drawing.Point(383, 366);
            this.pick_guardar.Name = "pick_guardar";
            this.pick_guardar.Size = new System.Drawing.Size(54, 46);
            this.pick_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pick_guardar.TabIndex = 117;
            this.pick_guardar.TabStop = false;
            this.pick_guardar.Click += new System.EventHandler(this.pick_guardar_Click);
            // 
            // pick_back
            // 
            this.pick_back.Image = global::SistemaVeterinario.Properties.Resources.arrow_left_icon_151610;
            this.pick_back.Location = new System.Drawing.Point(471, 366);
            this.pick_back.Name = "pick_back";
            this.pick_back.Size = new System.Drawing.Size(54, 46);
            this.pick_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pick_back.TabIndex = 116;
            this.pick_back.TabStop = false;
            this.pick_back.Click += new System.EventHandler(this.pick_back_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Observacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Dueño";
            // 
            // txt_fono
            // 
            this.txt_fono.Location = new System.Drawing.Point(343, 68);
            this.txt_fono.Name = "txt_fono";
            this.txt_fono.Size = new System.Drawing.Size(121, 22);
            this.txt_fono.TabIndex = 36;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(103, 95);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(167, 22);
            this.txt_mail.TabIndex = 35;
            // 
            // txt_nombreP
            // 
            this.txt_nombreP.Location = new System.Drawing.Point(103, 67);
            this.txt_nombreP.Name = "txt_nombreP";
            this.txt_nombreP.Size = new System.Drawing.Size(121, 22);
            this.txt_nombreP.TabIndex = 34;
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(103, 123);
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(362, 22);
            this.txt_obs.TabIndex = 33;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(157, 37);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 32;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(103, 156);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 22);
            this.txt_fecha.TabIndex = 29;
            // 
            // msktxt_hora
            // 
            this.msktxt_hora.Location = new System.Drawing.Point(334, 156);
            this.msktxt_hora.Mask = "00:00";
            this.msktxt_hora.Name = "msktxt_hora";
            this.msktxt_hora.Size = new System.Drawing.Size(57, 22);
            this.msktxt_hora.TabIndex = 27;
            this.msktxt_hora.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre";
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
            this.calendario.Location = new System.Drawing.Point(12, 205);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 21;
            this.calendario.Leave += new System.EventHandler(this.calendario_Leave);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(343, 40);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 22);
            this.txt_nombre.TabIndex = 19;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(103, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(48, 22);
            this.txt_id.TabIndex = 18;
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // AgendaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(575, 443);
            this.Controls.Add(this.AgConsulta);
            this.Name = "AgendaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendaConsulta";
            this.Load += new System.EventHandler(this.AgendaConsulta_Load);
            this.AgConsulta.ResumeLayout(false);
            this.AgConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pick_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AgConsulta;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.MaskedTextBox msktxt_hora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar calendario;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.TextBox txt_fono;
        public System.Windows.Forms.TextBox txt_mail;
        public System.Windows.Forms.TextBox txt_nombreP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pick_back;
        private System.Windows.Forms.PictureBox pick_guardar;
        private System.Windows.Forms.ToolTip toolguardar;
        private System.Windows.Forms.ToolTip toolBack;
    }
}