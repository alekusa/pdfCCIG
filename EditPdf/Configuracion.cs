using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            strPatch.Text = nomCarpeta;
        }

        private void Configuracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.tb_nc.Text = nomCarpeta;
            
        }
    }
}
