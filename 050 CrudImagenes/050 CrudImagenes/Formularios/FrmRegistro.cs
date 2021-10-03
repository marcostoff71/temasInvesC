using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using _050_CrudImagenes.Logica;
using _050_CrudImagenes.Modelos.AccesoDatos;

namespace _050_CrudImagenes.Formularios
{
    public partial class FrmRegistro : Form
    {
        private string pathroot;
        private readonly LPersona lPersona;
        private readonly AccesoDatosPersona acces;
        private bool sinFoto;
        private PersonaRu oPersaru;

        public FrmRegistro(int id = 0)
        {
            InitializeComponent();
            this.pathroot = AppDomain.CurrentDomain.BaseDirectory;
            this.lPersona = new LPersona();
            this.acces = new AccesoDatosPersona();
            this.sinFoto = false;
            this.oPersaru = null;
            if (id != 0)
            {
                this.oPersaru = acces.ObtenerPorId(id);
                CargaCampos(this.oPersaru);
            }
        }
        private void CargaCampos(PersonaRu pPersona)
        {
            txtNombre.Text = pPersona.Nombre;
            txtApePaterno.Text = pPersona.ApellidoPaterno;
            txtApematerno.Text = pPersona.ApellidoMaterno;
            dtpFechaNaci.Value = pPersona.FechaNaci.Value;
            picImgPersona.Image = ImagenesHelper.ObtieneImagenDeRuta(pPersona.FotoRut);
        }

        private bool Validaciones()
        {
            txtNombre.QuitaEspacios();
            txtApePaterno.QuitaEspacios();
            txtNombre.QuitaEspacios();
            int edad = this.lPersona.CalulaEdad(dtpFechaNaci.Value);

            if (!string.IsNullOrEmpty(txtNombre.Text) &&
               !string.IsNullOrEmpty(txtApePaterno.Text) &&
               !string.IsNullOrEmpty(txtApematerno.Text))
            {
                if (picImgPersona != null && edad >= 0)
                {
                    return true;
                }
            }


            return false;
        }
        private string CreaRuta(string nombre, string exte)
        {
            string path = Path.Combine(this.pathroot, "imagenes");

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            path = Path.Combine(path, nombre + exte);
            return path;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (Validaciones())
            {
                PersonaRu personaRu = new PersonaRu();
                personaRu.Nombre = txtNombre.Text;
                personaRu.ApellidoMaterno = txtApematerno.Text;
                personaRu.ApellidoPaterno = txtApePaterno.Text;
                personaRu.FechaNaci = dtpFechaNaci.Value;
                personaRu.Edad = this.lPersona.CalulaEdad(personaRu.FechaNaci.Value);


                if (this.oPersaru == null)
                {
                    if (this.sinFoto)
                    {
                        List<string> lstNombresImagenes = this.acces.Obtener().Select(i => i.NombreFoto).ToList();
                        string nombre = this.lPersona.SelecionaNombreUnico(lstNombresImagenes, personaRu);
                        string exte = ".jpg";
                        string rutaNueva = CreaRuta(nombre, exte);

                        using (FileStream fs = new FileStream(rutaNueva, FileMode.Create))
                        {
                            byte[] arr = ImagenesHelper.ObtieneBytesDeImagen(_050_CrudImagenes.Properties.Resources.imgDefe);
                            fs.Write(arr, 0, arr.Length);
                        }
                        personaRu.FotoRut = rutaNueva;
                        personaRu.NombreFoto = nombre;
                    }
                    else
                    {

                        List<string> lstNombresImagenes = this.acces.Obtener().Select(i => i.NombreFoto).ToList();
                        string exte = Path.GetExtension(opdImagen.FileName);
                        string nombre = this.lPersona.SelecionaNombreUnico(lstNombresImagenes, personaRu);
                        string rutaNueva = CreaRuta(nombre, exte);
                        File.Copy(opdImagen.FileName, rutaNueva);

                        personaRu.FotoRut = rutaNueva;
                        personaRu.NombreFoto = nombre;
                    }
                    this.acces.Agregar(personaRu);
                }
                else
                {
                    personaRu.IdPersona = this.oPersaru.IdPersona;

                    if (opdImagen.FileName == string.Empty && this.sinFoto == false)
                    {
                        personaRu.FotoRut = this.oPersaru.FotoRut;
                        personaRu.NombreFoto = this.oPersaru.Nombre;
                    }
                    else
                    {
                        if (this.sinFoto)
                        {
                            List<string> lstNombresImagenes = this.acces.Obtener().Select(i => i.NombreFoto).ToList();
                            string nombre = this.lPersona.SelecionaNombreUnico(lstNombresImagenes, personaRu);
                            string exte = ".jpg";
                            string rutaNueva = CreaRuta(nombre, exte);

                            using (FileStream fs = new FileStream(rutaNueva, FileMode.Create))
                            {
                                byte[] arr = ImagenesHelper.ObtieneBytesDeImagen(_050_CrudImagenes.Properties.Resources.imgDefe);
                                fs.Write(arr, 0, arr.Length);

                            }
                            personaRu.FotoRut = rutaNueva;
                            personaRu.NombreFoto = nombre;
                            MessageBox.Show("Entre aqui");
                            File.Delete(this.oPersaru.FotoRut);
                        }
                        else
                        {

                            List<string> lstNombresImagenes = this.acces.Obtener().Select(i => i.NombreFoto).ToList();
                            string nombre = this.lPersona.SelecionaNombreUnico(lstNombresImagenes, personaRu);
                            string exte = Path.GetExtension(opdImagen.FileName);
                            string rutaNueva = CreaRuta(nombre, exte);
                            File.Copy(opdImagen.FileName, rutaNueva);
                            personaRu.FotoRut = rutaNueva;
                            personaRu.NombreFoto = nombre;
                            File.Delete(this.oPersaru.FotoRut);
                            MessageBox.Show("Entre aqui2");
                        }
                    }

                    this.acces.Modificar(personaRu);
                }
                this.Close();
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

            if (opdImagen.ShowDialog() == DialogResult.OK)
            {
                string ruta = opdImagen.FileName;

                picImgPersona.Image = ImagenesHelper.ObtieneImagenDeRuta(ruta);
                this.sinFoto = false;

            }
        }

        private void btnSinFoto_Click(object sender, EventArgs e)
        {
            picImgPersona.Image = _050_CrudImagenes.Properties.Resources.imgDefe;
            this.sinFoto = true;
        }
    }
}
