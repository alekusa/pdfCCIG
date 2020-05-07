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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String archivo = "";
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
            if(Environment.CommandLine.Contains("\" \""))
            {
                archivo = Environment.CommandLine.Split(new char[] { '"' })[3];
            }
            visorPDF.LoadFile(archivo);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String nc = tb_nc.Text;
            try
            {
                if (archivo == "")
                    throw new Exception("Debe existir un PDF");
                string archivoFinal = archivo + nc + "- ntexto - promotor";
                int x = 200;
                int y = 300;
                int a = 0;
                int s = 25;
                utilPdf util = new utilPdf();
                String cErr = util.addTexto(archivoFinal, archivo, tb_nc.Text.Trim(), x, y, a, s);
                if (cErr != "")
                    throw new Exception(cErr);
                visorPDF.LoadFile(archivoFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion conf = new Configuracion();
            conf.ShowDialog();

            tb_nc.Text = conf.cmbOP.Text;

            //String a = Configuracion.daTos();
            
        }
    }
}
