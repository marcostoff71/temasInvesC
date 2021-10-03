using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _050_CrudImagenes.Modelos.AccesoDatos;
using _050_CrudImagenes.Logica;
using System.IO;

namespace _050_CrudImagenes.Formularios
{
    public partial class FrmPrincipal : Form
    {
        private AccesoDatosPersona acces;
        private LPersona lPersona;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.acces = new AccesoDatosPersona();
            this.lPersona = new LPersona();
        }
        
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            var d = new Formularios.UsrVistaPrincipal();
            d.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(d);
        }

        private void migrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string rutaNueva = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"imagenes");
            if(!Directory.Exists(rutaNueva))
            Directory.CreateDirectory(rutaNueva);
            

            List<string> rutasAnti=acces.Obtener().Select(per => per.FotoRut).ToList();
            List<string> lstRutasNuevas = this.lPersona.NuevaRuta(rutasAnti, rutaNueva);

            int i = 0;
            using(Modelos.AccesoDatos.PrubaContraEntities db = new PrubaContraEntities())
            {
                foreach (var item in db.PersonaRu)
                {
                    if (File.Exists(item.FotoRut))
                    {
                        File.Move(item.FotoRut, lstRutasNuevas[i]);
                    }
                    item.FotoRut = lstRutasNuevas[i];
                    i++;
                }
                db.SaveChanges();
                
            }
            MessageBox.Show("Exito");

            
        }

        
    }
}
