namespace SistemaVeterinario
{
    partial class Fichas
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
            this.dtg_Fichas = new System.Windows.Forms.DataGridView();
            this.TxtFiltrar = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_selectVacuna = new System.Windows.Forms.Button();
            this.btn_detalle = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.pick_back = new System.Windows.Forms.PictureBox();
            this.toolBack = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Fichas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_back)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Fichas
            // 
            this.dtg_Fichas.AllowUserToAddRows = false;
            this.dtg_Fichas.AllowUserToDeleteRows = false;
            this.dtg_Fichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Fichas.Location = new System.Drawing.Point(13, 70);
            this.dtg_Fichas.Name = "dtg_Fichas";
            this.dtg_Fichas.ReadOnly = true;
            this.dtg_Fichas.RowTemplate.Height = 24;
            this.dtg_Fichas.Size = new System.Drawing.Size(1089, 391);
            this.dtg_Fichas.TabIndex = 1;
            // 
            // TxtFiltrar
            // 
            this.TxtFiltrar.Location = new System.Drawing.Point(13, 31);
            this.TxtFiltrar.Name = "TxtFiltrar";
            this.TxtFiltrar.Size = new System.Drawing.Size(161, 22);
            this.TxtFiltrar.TabIndex = 3;
            this.TxtFiltrar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFiltrar_KeyUp);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(192, 26);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(100, 33);
            this.btn_select.TabIndex = 4;
            this.btn_select.Text = "Seleccionar";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_selectVacuna
            // 
            this.btn_selectVacuna.Location = new System.Drawing.Point(192, 26);
            this.btn_selectVacuna.Name = "btn_selectVacuna";
            this.btn_selectVacuna.Size = new System.Drawing.Size(100, 33);
            this.btn_selectVacuna.TabIndex = 5;
            this.btn_selectVacuna.Text = "Seleccionar";
            this.btn_selectVacuna.UseVisualStyleBackColor = true;
            this.btn_selectVacuna.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_detalle
            // 
            this.btn_detalle.Location = new System.Drawing.Point(298, 26);
            this.btn_detalle.Name = "btn_detalle";
            this.btn_detalle.Size = new System.Drawing.Size(100, 33);
            this.btn_detalle.TabIndex = 6;
            this.btn_detalle.Text = "Ver detalle";
            this.btn_detalle.UseVisualStyleBackColor = true;
            this.btn_detalle.Click += new System.EventHandler(this.btn_detalle_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Location = new System.Drawing.Point(404, 26);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(100, 33);
            this.btn_clientes.TabIndex = 9;
            this.btn_clientes.Text = "Ver Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // pick_back
            // 
            this.pick_back.Image = global::SistemaVeterinario.Properties.Resources.arrow_left_icon_151610;
            this.pick_back.Location = new System.Drawing.Point(1048, 474);
            this.pick_back.Name = "pick_back";
            this.pick_back.Size = new System.Drawing.Size(54, 46);
            this.pick_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pick_back.TabIndex = 116;
            this.pick_back.TabStop = false;
            this.pick_back.Click += new System.EventHandler(this.pick_back_Click);
            // 
            // Fichas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 532);
            this.Controls.Add(this.pick_back);
            this.Controls.Add(this.btn_clientes);
            this.Controls.Add(this.btn_detalle);
            this.Controls.Add(this.btn_selectVacuna);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.TxtFiltrar);
            this.Controls.Add(this.dtg_Fichas);
            this.Name = "Fichas";
            this.Text = "Fichas";
            this.Load += new System.EventHandler(this.Fichas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Fichas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_Fichas;
        private System.Windows.Forms.TextBox TxtFiltrar;
        public System.Windows.Forms.Button btn_select;
        public System.Windows.Forms.Button btn_selectVacuna;
        public System.Windows.Forms.Button btn_detalle;
        public System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.PictureBox pick_back;
        private System.Windows.Forms.ToolTip toolBack;
    }
}