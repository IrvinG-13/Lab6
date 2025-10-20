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
            this.gvInventario = new System.Windows.Forms.DataGridView();
            this.gbConsultar = new System.Windows.Forms.GroupBox();
            this.cbGenero2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventario)).BeginInit();
            this.gbConsultar.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvInventario
            // 
            this.gvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInventario.Location = new System.Drawing.Point(171, 209);
            this.gvInventario.Name = "gvInventario";
            this.gvInventario.RowHeadersWidth = 62;
            this.gvInventario.RowTemplate.Height = 28;
            this.gvInventario.Size = new System.Drawing.Size(513, 195);
            this.gvInventario.TabIndex = 0;
            // 
            // gbConsultar
            // 
            this.gbConsultar.Controls.Add(this.btnConsultar);
            this.gbConsultar.Controls.Add(this.label1);
            this.gbConsultar.Controls.Add(this.cbGenero2);
            this.gbConsultar.Location = new System.Drawing.Point(87, 35);
            this.gbConsultar.Name = "gbConsultar";
            this.gbConsultar.Size = new System.Drawing.Size(353, 157);
            this.gbConsultar.TabIndex = 1;
            this.gbConsultar.TabStop = false;
            this.gbConsultar.Text = "Consultar";
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
            this.cbGenero2.Location = new System.Drawing.Point(175, 51);
            this.cbGenero2.Name = "cbGenero2";
            this.cbGenero2.Size = new System.Drawing.Size(142, 28);
            this.cbGenero2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Género Literario";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(118, 102);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(119, 32);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(462, 35);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(287, 157);
            this.gbBuscar.TabIndex = 2;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Libros Disponibles";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(104, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 31);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.gbConsultar);
            this.Controls.Add(this.gvInventario);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gvInventario)).EndInit();
            this.gbConsultar.ResumeLayout(false);
            this.gbConsultar.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvInventario;
        private System.Windows.Forms.GroupBox gbConsultar;
        private System.Windows.Forms.ComboBox cbGenero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}