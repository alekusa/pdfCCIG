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
    }
}
