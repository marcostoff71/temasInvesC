using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _075_combo
{
    public partial class Form1 : Form
    {
        private List<int> lstNumeros = new List<int>() { 2,3,4,5,7};
        public Form1()
        {

            InitializeComponent();

        }

        private void Actualizar()
        {
            comboBox1.DataSource = lstNumeros;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
