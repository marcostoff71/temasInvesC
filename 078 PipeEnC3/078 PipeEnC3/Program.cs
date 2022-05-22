// See https://aka.ms/new-console-template for more information
using _078_PipeEnC3;
using System.Linq;

namespace _078_PipeEnC3
{

    public class Program
    {


        public static void Main(string[] args)
        {

            /*Console.WriteLine("Hello, World!");



            List<Persona> personas = new List<Persona>()
            {
                    new Persona(){Nombre="marco"},
                    new Persona(){Nombre="Luis"},
                    new Persona(){Nombre="Pablo"},
                    new Persona(){Nombre="Mario"},
                    new Persona(){Nombre="Pepe"}
            };*/

            List<int> lstEnteros = new List<int>() { 1, 2, 3 };

            int suma=lstEnteros.AgregateEvil((ant, act) =>
            {
                return ant + act;
            });

            int suma2 = lstEnteros.AgregateEvil((ant, act) =>
            {
                return ant + act;
            }, 10);



            int agre1 = lstEnteros.Aggregate(0, (a, b) => a + b, (a) => a * 2);
            int agre2 = lstEnteros.AgregateEvil(0,(ant,act)=>ant + act,(a)=>a*2);

            Console.WriteLine($"{agre1} {agre2}");



            Console.WriteLine(suma);
            Console.WriteLine(suma2);

        }


        
        private static List<Persona> CambiaMayuscula(List<Persona> lstPersona)
        {

            return lstPersona.Select((Persona x) =>
            {
                Persona per = x;
                per.Nombre = per.Nombre?.ToUpper();
                return per;
            }).ToList();
        }

    }




}

