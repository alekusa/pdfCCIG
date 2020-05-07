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
            this.strPatch = new System.Windows.Forms.Label();
            this.cmbOP = new System.Windows.Forms.ComboBox();
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
            // strPatch
            // 
            this.strPatch.AutoSize = true;
            this.strPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strPatch.Location = new System.Drawing.Point(161, 15);
            this.strPatch.Name = "strPatch";
            this.strPatch.Size = new System.Drawing.Size(72, 24);
            this.strPatch.TabIndex = 1;
            this.strPatch.Text = "carpeta";
            // 
            // cmbOP
            // 
            this.cmbOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOP.FormattingEnabled = true;
            this.cmbOP.Items.AddRange(new object[] {
            "SG Alexis KUSEMAN",
            "SG Hector STANG",
            "SI Nicolas FIGUEREDO"});
            this.cmbOP.Location = new System.Drawing.Point(13, 62);
            this.cmbOP.Name = "cmbOP";
            this.cmbOP.Size = new System.Drawing.Size(133, 28);
            this.cmbOP.TabIndex = 2;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 207);
            this.Controls.Add(this.cmbOP);
            this.Controls.Add(this.strPatch);
            this.Controls.Add(this.btnCarpeta);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Configuracion_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarpeta;
        public System.Windows.Forms.Label strPatch;
        public System.Windows.Forms.ComboBox cmbOP;
    }
}