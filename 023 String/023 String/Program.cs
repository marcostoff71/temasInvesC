using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lstPersonas = new List<Persona>();
            lstPersonas.AddRange(new Persona[]
            {
                new Persona(){Id=1,Nombre="pep"},
                new Persona(){Id=23,Nombre="luis"}
            });

            List<Estudiante> lstEstudiantes = new List<Estudiante>();
            lstEstudiantes.Add(new Estudiante() { Id = 1, Control = "32" });
            lstEstudiantes.Add(new Estudiante() { Id = 23, Control = "232as" });

            var union = (from d in lstPersonas
                        join s in lstEstudiantes
                        on d.Id equals s.Id
                        select new { d.Id,d.Nombre });
            
            
                        
        }
        
    }
    class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    class Estudiante
    {
        public int Id { get; set; }
        public string Control { get; set; }
    }
}
