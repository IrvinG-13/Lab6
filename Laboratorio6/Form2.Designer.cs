namespace Laboratorio6
{
    partial class Form2
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
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.gbConsultar = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGenero2 = new System.Windows.Forms.ComboBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.gbConsultar.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(58, 136);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 62;
            this.dgvInventario.RowTemplate.Height = 28;
            this.dgvInventario.Size = new System.Drawing.Size(536, 127);
            this.dgvInventario.TabIndex = 0;
            // 
            // gbConsultar
            // 
            this.gbConsultar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbConsultar.Controls.Add(this.btnConsultar);
            this.gbConsultar.Controls.Add(this.label1);
            this.gbConsultar.Controls.Add(this.cbGenero2);
            this.gbConsultar.Location = new System.Drawing.Point(58, 23);
            this.gbConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsultar.Name = "gbConsultar";
            this.gbConsultar.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsultar.Size = new System.Drawing.Size(236, 102);
            this.gbConsultar.TabIndex = 1;
            this.gbConsultar.TabStop = false;
            this.gbConsultar.Text = "Consultar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(79, 67);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(80, 21);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Género Literario";
            // 
            // cbGenero2
            // 
            this.cbGenero2.FormattingEnabled = true;
            this.cbGenero2.Items.AddRange(new object[] {
            "novelas",
            "terror",
            "fantasia",
            "historia",
            "poemas"});
            this.cbGenero2.Location = new System.Drawing.Point(117, 33);
            this.cbGenero2.Margin = new System.Windows.Forms.Padding(2);
            this.cbGenero2.Name = "cbGenero2";
            this.cbGenero2.Size = new System.Drawing.Size(96, 21);
            this.cbGenero2.TabIndex = 0;
            // 
            // gbBuscar
            // 
            this.gbBuscar.BackColor = System.Drawing.Color.Gray;
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(308, 23);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(2);
            this.gbBuscar.Size = new System.Drawing.Size(286, 102);
            this.gbBuscar.TabIndex = 2;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Libros Disponibles";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(69, 50);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 20);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(308, 280);
            this.btnEliminarLibro.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(64, 20);
            this.btnEliminarLibro.TabIndex = 1;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Laboratorio6.Properties.Resources.hacking;
            this.ClientSize = new System.Drawing.Size(682, 334);
            this.Controls.Add(this.btnEliminarLibro);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.gbConsultar);
            this.Controls.Add(this.dgvInventario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.gbConsultar.ResumeLayout(false);
            this.gbConsultar.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.GroupBox gbConsultar;
        private System.Windows.Forms.ComboBox cbGenero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminarLibro;
    }
}