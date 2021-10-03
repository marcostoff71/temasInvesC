using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace _038_Sacar_Conexions_de_config
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ConnectionStringSettingsCollection cone =ConfigurationManager.ConnectionStrings;
            MessageBox.Show(ConfigurationManager.ConnectionStrings["ConePersona"].ConnectionString);
        }
    }
}
