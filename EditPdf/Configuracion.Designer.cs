namespace EditPdf
{
    partial class Configuracion
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
            this.btnCarpeta = new System.Windows.Forms.Button();
            this.cmbOP = new System.Windows.Forms.ComboBox();
            this.txtPatch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCarpeta
            // 
            this.btnCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarpeta.Location = new System.Drawing.Point(12, 12);
            this.btnCarpeta.Name = "btnCarpeta";
            this.btnCarpeta.Size = new System.Drawing.Size(134, 34);
            this.btnCarpeta.TabIndex = 0;
            this.btnCarpeta.Text = "Carpeta";
            this.btnCarpeta.UseVisualStyleBackColor = true;
            this.btnCarpeta.Click += new System.EventHandler(this.btnCarpeta_Click);
            // 
            // cmbOP
            // 
            this.cmbOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOP.FormattingEnabled = true;
            this.cmbOP.Items.AddRange(new object[] {
            "SG KUSEMAN Alexis ",
            "SG STANG Hector",
            "SI FIGUEREDO Diego",
            "SG CRUZ Dionicio",
            "CI TORANZO Alberto",
            "CI ROMANO Leonardo",
            "SA ISLEÑO Claudia",
            "SA RAMIREZ Betiana"});
            this.cmbOP.Location = new System.Drawing.Point(13, 85);
            this.cmbOP.Name = "cmbOP";
            this.cmbOP.Size = new System.Drawing.Size(220, 28);
            this.cmbOP.TabIndex = 2;
            this.cmbOP.TextChanged += new System.EventHandler(this.cmbOP_TextChanged);
            // 
            // txtPatch
            // 
            this.txtPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatch.Location = new System.Drawing.Point(13, 53);
            this.txtPatch.Name = "txtPatch";
            this.txtPatch.Size = new System.Drawing.Size(867, 22);
            this.txtPatch.TabIndex = 3;
            this.txtPatch.TextChanged += new System.EventHandler(this.txtPatch_TextChanged);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 123);
            this.Controls.Add(this.txtPatch);
            this.Controls.Add(this.cmbOP);
            this.Controls.Add(this.btnCarpeta);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Configuracion_FormClosed);
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarpeta;
        public System.Windows.Forms.ComboBox cmbOP;
        public System.Windows.Forms.TextBox txtPatch;
    }
}