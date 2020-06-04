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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String archivo = "";
        String OP = "";
        String archivoFinal = "";
        String patch = "";
        int numeroControl = (int)Settings.Default["NroControl"];
        Configuracion conf = new Configuracion();

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openArchivo = new OpenFileDialog();
            openArchivo.Filter = "SOLO PDF | *.pdf"; //filtro solo PDF.
            openArchivo.ShowDialog();
            archivo = openArchivo.FileName;

            if (archivo != "")
            {
                visorPDF.LoadFile(archivo);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_nc.Text = (numeroControl + 1).ToString("D5");
            if (Environment.CommandLine.Contains("\" \""))
            {
                archivo = Environment.CommandLine.Split(new char[] { '"' })[3];
            }
            visorPDF.LoadFile(archivo);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OP = (string)Settings.Default["OP"];
            patch = (string)Settings.Default["Carpeta"] + @"\";
            try
            {
                if (archivo == "")
                    throw new Exception("Debe existir un PDF");
                    archivoFinal = patch + tb_nc.Text + " - " + tb_nt.Text.Trim()+" "+ tb_promotor.Text.Trim() + ".pdf";
                    String NumeroDeControl = tb_nc.Text.Trim();

                    Util_PDF util = new Util_PDF();
                    String Error = util.Add(archivoFinal, archivo, NumeroDeControl, OP);
                    if (Error != "")
                        throw new Exception(Error);

                    //Volver a cargar el PDF en el Visor
                    visorPDF.LoadFile(archivoFinal);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            //Close();
            
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            conf.ShowDialog();
            
        }

        private void tb_nc_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["NroControl"] = int.Parse(tb_nc.Text);
            Settings.Default.Save();
        }
    }
}
