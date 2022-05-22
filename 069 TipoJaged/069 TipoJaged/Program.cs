using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069_TipoJaged
{
    class BDEstudiante
    {
        private readonly List<Estudiante> lst;
        public BDEstudiante()
        {
            this.lst = new List<Estudiante>();
            
        }
        public List<Estudiante> Obtener()
        {
            return this.lst;
        }
        public Estudiante ObtenerPorId(int id)
        {
            return lst.FirstOrDefault(e => e.Id == id);
        }
        public bool Modificar(Estudiante es)
        {
            bool mofi = false;

            int i=lst.indexOfPredicate(e => e.Id == es.Id);

            if (i != -1)
            {
                lst[i] = es;
                mofi = true;
            }

            return mofi;
        }
        public bool Eliminar(int id)
        {
            bool eli = false;

            int i = lst.indexOfPredicate(e => e.Id == id);


            if (i != -1)
            {
                lst.RemoveAt(i);
            }


            return eli;
        }
    }
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(new int[,] { {1,2,3},{ 4,5,6}}.Length);
            Console.WriteLine(promedoArray(new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 3 } } ));

            List<Estudiante> lstEstudiantes = new List<Estudiante>(){
               new Estudiante(){ Id=1,Nombre="marco",Apellido="gonzalez"},
               new Estudiante(){ Id=1,Nombre="luis",Apellido="gonzalez"},
               new Estudiante(){ Id=1,Nombre="pepe",Apellido="gonzalez"}
           };

            var es=lstEstudiantes.First(e=>e.Nombre.Contains("luis"));

            Console.WriteLine(lstEstudiantes.indexOfPredicate(e=> e.Nombre.Contains("3444444")));

            Console.WriteLine();
            Console.WriteLine();

            lstEstudiantes.ForEach(e =>
            {
                Console.WriteLine(e.Nombre);
            });
        }


        static double promedoArray(double[][] arr)
        {
            double su=0, pro;
            int can = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    can++;
                    su += arr[i][j];
                }
            }
   

            pro = su / can;

            return pro;
        }
    }

    static class ExteEnumerable{
        public static int indexOfPredicate<T>(this IEnumerable<T> lst,Predicate<T> condi)
        {
            int index = -1;
            int reco = 0;

            foreach (T item in lst)
            {
                if (condi(item))
                {
                    index = reco;
                    break;
                }
                reco++;
            }

            return index;
        }
    }
}
