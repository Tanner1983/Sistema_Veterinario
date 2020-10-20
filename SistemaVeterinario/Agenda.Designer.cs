namespace SistemaVeterinario
{
    partial class Agenda
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_verAgenda = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agendar Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agendar Vacuna";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_verAgenda
            // 
            this.btn_verAgenda.Location = new System.Drawing.Point(265, 22);
            this.btn_verAgenda.Name = "btn_verAgenda";
            this.btn_verAgenda.Size = new System.Drawing.Size(114, 42);
            this.btn_verAgenda.TabIndex = 2;
            this.btn_verAgenda.Text = "Visualizar Agenda";
            this.btn_verAgenda.UseVisualStyleBackColor = true;
            this.btn_verAgenda.Click += new System.EventHandler(this.btn_verAgenda_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(385, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Visualizar Agenda Hoy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(197, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Volver al Menú";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(523, 181);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_verAgenda);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_verAgenda;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}