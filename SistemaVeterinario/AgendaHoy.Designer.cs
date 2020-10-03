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
            this.button1 = new System.Windows.Forms.Button();
            this.dtg_agendahoy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_agendahoy)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // AgendaHoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 301);
            this.Controls.Add(this.dtg_agendahoy);
            this.Controls.Add(this.button1);
            this.Name = "AgendaHoy";
            this.Text = "AgendaHoy";
            this.Load += new System.EventHandler(this.AgendaHoy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_agendahoy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtg_agendahoy;
    }
}