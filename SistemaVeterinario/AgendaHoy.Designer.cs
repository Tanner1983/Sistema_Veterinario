namespace SistemaVeterinario
{
    partial class AgendaHoy
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
            this.dtg_agendahoy = new System.Windows.Forms.DataGridView();
            this.pick_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_agendahoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_back)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_agendahoy
            // 
            this.dtg_agendahoy.AllowUserToAddRows = false;
            this.dtg_agendahoy.AllowUserToDeleteRows = false;
            this.dtg_agendahoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_agendahoy.Location = new System.Drawing.Point(30, 26);
            this.dtg_agendahoy.Name = "dtg_agendahoy";
            this.dtg_agendahoy.ReadOnly = true;
            this.dtg_agendahoy.RowTemplate.Height = 24;
            this.dtg_agendahoy.Size = new System.Drawing.Size(648, 191);
            this.dtg_agendahoy.TabIndex = 1;
            // 
            // pick_back
            // 
            this.pick_back.Image = global::SistemaVeterinario.Properties.Resources.arrow_left_icon_151610;
            this.pick_back.Location = new System.Drawing.Point(624, 243);
            this.pick_back.Name = "pick_back";
            this.pick_back.Size = new System.Drawing.Size(54, 46);
            this.pick_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pick_back.TabIndex = 117;
            this.pick_back.TabStop = false;
            this.pick_back.Click += new System.EventHandler(this.pick_back_Click);
            // 
            // AgendaHoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 301);
            this.Controls.Add(this.pick_back);
            this.Controls.Add(this.dtg_agendahoy);
            this.Name = "AgendaHoy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendaHoy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgendaHoy_FormClosing);
            this.Load += new System.EventHandler(this.AgendaHoy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_agendahoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_agendahoy;
        private System.Windows.Forms.PictureBox pick_back;
    }
}