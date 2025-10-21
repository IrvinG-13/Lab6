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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.gbConsultar.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(152, 167);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 62;
            this.dgvInventario.RowTemplate.Height = 28;
            this.dgvInventario.Size = new System.Drawing.Size(456, 156);
            this.dgvInventario.TabIndex = 0;
            // 
            // gbConsultar
            // 
            this.gbConsultar.Controls.Add(this.btnConsultar);
            this.gbConsultar.Controls.Add(this.label1);
            this.gbConsultar.Controls.Add(this.cbGenero2);
            this.gbConsultar.Location = new System.Drawing.Point(77, 28);
            this.gbConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbConsultar.Name = "gbConsultar";
            this.gbConsultar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbConsultar.Size = new System.Drawing.Size(314, 126);
            this.gbConsultar.TabIndex = 1;
            this.gbConsultar.TabStop = false;
            this.gbConsultar.Text = "Consultar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(105, 82);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(106, 26);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
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
            this.cbGenero2.Location = new System.Drawing.Point(156, 41);
            this.cbGenero2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGenero2.Name = "cbGenero2";
            this.cbGenero2.Size = new System.Drawing.Size(127, 24);
            this.cbGenero2.TabIndex = 0;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(411, 28);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBuscar.Size = new System.Drawing.Size(255, 126);
            this.gbBuscar.TabIndex = 2;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Libros Disponibles";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(92, 62);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 25);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.gbConsultar);
            this.Controls.Add(this.dgvInventario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
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
    }
}