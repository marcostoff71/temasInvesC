using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _050_CrudImagenes.Modelos.AccesoDatos;
namespace _050_CrudImagenes.Logica
{
    public class AccesoDatosPersona
    {
        public List<PersonaRu> Obtener()
        {
            List<PersonaRu> lstPersonas = new List<PersonaRu>();
            using (PrubaContraEntities db = new PrubaContraEntities())
            {
                lstPersonas = db.PersonaRu.ToList();
            }

            return lstPersonas;
        }
        public PersonaRu ObtenerPorId(int id)
        {
            PersonaRu lstPersonas = new PersonaRu();
            using (PrubaContraEntities db = new PrubaContraEntities())
            {
                lstPersonas = db.PersonaRu.FirstOrDefault(e => e.IdPersona == id);
            }

            return lstPersonas;
        }
        public bool Agregar(PersonaRu pPersona)
        {
            int re = 0;
            using (PrubaContraEntities db = new PrubaContraEntities())
            {
                db.PersonaRu.Add(pPersona);
                re = db.SaveChanges();
            }

            return re > 0;
        }
        public bool Modificar(PersonaRu pPersona)
        {
            int re = 0;
            using (PrubaContraEntities db = new PrubaContraEntities())
            {
                db.Entry(pPersona).State = System.Data.Entity.EntityState.Modified;
                re = db.SaveChanges();
            }

            return re > 0;
        }
        public bool Eliminar(int id)
        {
            int re = 0;
            using (PrubaContraEntities db = new PrubaContraEntities())
            {
                PersonaRu p = db.PersonaRu.FirstOrDefault(e => e.IdPersona == id);
                db.PersonaRu.Remove(p);
                re = db.SaveChanges();
            }

            return re > 0;
        }
    }
}
