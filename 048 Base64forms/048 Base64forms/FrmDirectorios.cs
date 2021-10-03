using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _048_Base64forms
{
    public partial class FrmDirectorios : Form
    {
        public FrmDirectorios()
        {
            InitializeComponent();
        }
        private void CargaArchivos(string path)
        {
            string[] archivos=Directory.GetFiles(path);
            listBox1.DataSource = archivos;

        }
        private void MuestraExtensiones()
        {
            List<string> exte = ObtieneExtensiones(txtRuta.Text);
            comboBox1.DataSource = exte;
        }
        private void btnAbreCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.RootFolder = Environment.SpecialFolder.Desktop;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(folder.SelectedPath))
                {
                    txtRuta.Text = folder.SelectedPath;
                    CargaArchivos(folder.SelectedPath);
                    MuestraExtensiones();
                }
            }
        }
        private List<string> ObtieneExtensiones(string ruta)
        {

            string[] archivos = Directory.GetFiles(ruta);
            List<string> extensiones = new List<string>();

            foreach (var item in archivos)
            {
                string exte=Path.GetExtension(item);
                if (!extensiones.Exists(e=>e==exte))
                {
                    extensiones.Add(exte);
                }
            }

            return extensiones;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string sele = (string)comboBox1.SelectedItem;
                string[] archivos = Directory.GetFiles(txtRuta.Text, "*"+sele);
                listBox1.DataSource = archivos;
                MessageBox.Show(archivos.Length.ToString());
            }
        }
    }
}
