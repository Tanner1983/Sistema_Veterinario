namespace SistemaVeterinario
{
    partial class VerAgenda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_consulta = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_vacuna = new System.Windows.Forms.DataGridView();
            this.toolBack = new System.Windows.Forms.ToolTip(this.components);
            this.toolAsistencia = new System.Windows.Forms.ToolTip(this.components);
            this.pick_vacuna = new System.Windows.Forms.PictureBox();
            this.pick_back = new System.Windows.Forms.PictureBox();
            this.pick_consulta = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_consulta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_vacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_consulta);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // dtg_consulta
            // 
            this.dtg_consulta.AllowUserToAddRows = false;
            this.dtg_consulta.AllowUserToDeleteRows = false;
            this.dtg_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_consulta.Location = new System.Drawing.Point(15, 26);
            this.dtg_consulta.Name = "dtg_consulta";
            this.dtg_consulta.RowTemplate.Height = 24;
            this.dtg_consulta.Size = new System.Drawing.Size(1007, 208);
            this.dtg_consulta.TabIndex = 0;
            this.dtg_consulta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_consulta_CellValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_vacuna);
            this.groupBox2.Location = new System.Drawing.Point(13, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1036, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vacunacion";
            // 
            // dtg_vacuna
            // 
            this.dtg_vacuna.AllowUserToAddRows = false;
            this.dtg_vacuna.AllowUserToDeleteRows = false;
            this.dtg_vacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_vacuna.Location = new System.Drawing.Point(15, 21);
            this.dtg_vacuna.Name = "dtg_vacuna";
            this.dtg_vacuna.RowTemplate.Height = 24;
            this.dtg_vacuna.Size = new System.Drawing.Size(1007, 208);
            this.dtg_vacuna.TabIndex = 1;
            // 
            // pick_vacuna
            // 
            this.pick_vacuna.Image = global::SistemaVeterinario.Properties.Resources.check_home_equity_real_estate_ok_mark_icon_icons_com_69050;
            this.pick_vacuna.Location = new System.Drawing.Point(605, 543);
            this.pick_vacuna.Name = "pick_vacuna";
            this.pick_vacuna.Size = new System.Drawing.Size(54, 46);
            this.pick_vacuna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pick_vacuna.TabIndex = 117;
            this.pick_vacuna.TabStop = false;
            this.pick_vacuna.Click += new System.EventHandler(this.pick_asis_Click);
            // 
            // pick_back
            // 
            this.pick_back.Image = global::SistemaVeterinario.Properties.Resources.arrow_left_icon_151610;
            this.pick_back.Location = new System.Drawing.Point(484, 545);
            this.pick_back.Name = "pick_back";
            this.pick_back.Size = new System.Drawing.Size(54, 46);
            this.pick_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pick_back.TabIndex = 116;
            this.pick_back.TabStop = false;
            this.pick_back.Click += new System.EventHandler(this.pick_back_Click);
            // 
            // pick_consulta
            // 
            this.pick_consulta.Image = global::SistemaVeterinario.Properties.Resources.check_home_equity_real_estate_ok_mark_icon_icons_com_69050;
            this.pick_consulta.Location = new System.Drawing.Point(605, 253);
            this.pick_consulta.Name = "pick_consulta";
            this.pick_consulta.Size = new System.Drawing.Size(54, 46);
            this.pick_consulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pick_consulta.TabIndex = 118;
            this.pick_consulta.TabStop = false;
            this.pick_consulta.Click += new System.EventHandler(this.pick_consulta_Click);
            // 
            // VerAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1061, 603);
            this.Controls.Add(this.pick_consulta);
            this.Controls.Add(this.pick_vacuna);
            this.Controls.Add(this.pick_back);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VerAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerAgenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerAgenda_FormClosing);
            this.Load += new System.EventHandler(this.VerAgenda_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_consulta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_vacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_consulta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtg_vacuna;
        private System.Windows.Forms.PictureBox pick_back;
        private System.Windows.Forms.ToolTip toolBack;
        private System.Windows.Forms.PictureBox pick_vacuna;
        private System.Windows.Forms.ToolTip toolAsistencia;
        private System.Windows.Forms.PictureBox pick_consulta;
    }
}