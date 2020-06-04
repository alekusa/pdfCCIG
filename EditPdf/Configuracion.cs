using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EditPdf.Properties;

namespace EditPdf
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }
        String nomCarpeta = "";
        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog SelectCarpeta = new FolderBrowserDialog();
            SelectCarpeta.ShowDialog();
            nomCarpeta = SelectCarpeta.SelectedPath;
            txtPatch.Text = nomCarpeta;

        }

        private void Configuracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            txtPatch.Text = (string)Settings.Default["Carpeta"];
            cmbOP.Text = (string)Settings.Default["OP"];
        }

        private void cmbOP_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["OP"] = cmbOP.Text;
            Settings.Default.Save();
        }

        private void txtPatch_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["Carpeta"] = txtPatch.Text;
            Settings.Default.Save();
        }
    }
}
