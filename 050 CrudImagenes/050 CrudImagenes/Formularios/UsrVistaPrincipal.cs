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

namespace _050_CrudImagenes.Formularios
{
    public partial class UsrVistaPrincipal : UserControl
    {
        private AccesoDatosPersona acces;
        public UsrVistaPrincipal()
        {
            InitializeComponent();
            this.acces = new AccesoDatosPersona();
            
        }
        #region Actualiza
        private void Refresca()
        {
            
            var d = (from per in this.acces.Obtener()
                    select new
                    {
                        per.IdPersona,
                        per.Nombre,
                        per.ApellidoMaterno,
                        per.ApellidoPaterno,
                        per.FechaNaci,
                        per.Edad,
                        Foto = ImagenesHelper.ObtieneBytesDeRuta(per.FotoRut)
                    }).ToList();
            MessageBox.Show(d.Count().ToString());
            dgvDatosImagenes.DataSource = d;
        }
        #endregion
        private int? ObtieneId()
        {
            if (dgvDatosImagenes == null || dgvDatosImagenes.Rows == null || dgvDatosImagenes.Columns == null
                ||dgvDatosImagenes.CurrentRow==null)
            {
                return null;
            }
            else
            {
                return int.Parse(dgvDatosImagenes.Rows[dgvDatosImagenes.CurrentRow.Index].Cells[0].Value.ToString());
            }
        }
        private void CargaCamposExtra()
        {
            DataGridViewLinkColumn columEliminar = new DataGridViewLinkColumn();
            columEliminar.HeaderText = "Eliminar";
            columEliminar.Text = "Eliminar";
            columEliminar.UseColumnTextForLinkValue = true;

            DataGridViewLinkColumn columModficicar = new DataGridViewLinkColumn();
            columModficicar.HeaderText = "Modificar";
            columModficicar.Text = "Modificar";
            columModficicar.UseColumnTextForLinkValue = true;


            dgvDatosImagenes.Columns.AddRange(new DataGridViewColumn[] {columEliminar,columModficicar});


            
           
        }

        private void UsrVistaPrincipal_Load(object sender, EventArgs e)
        {
            Refresca();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.ShowDialog();
            Refresca();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int? id = ObtieneId();
            if (id != null)
            {
                FrmRegistro registro = new FrmRegistro((int)id);
                registro.ShowDialog();
                Refresca();
            }
        }
    }
}
