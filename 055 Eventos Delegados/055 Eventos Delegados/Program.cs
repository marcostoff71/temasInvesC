using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Eventos_Delegados
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona();
            p1.Evento += (sender, e) =>
            {
                e.algo = "Hola2";
                Console.WriteLine(e.algo);
            };

            p1.Evento += (sender, e) =>
            {
                e.algo = "Hol2";
                Console.WriteLine(e.algo);
            };

            p1.LLamarEvento();
            
        }
    }
    class EventoHazAlgo
    {
        public string algo;
    }
    class Persona
    {

        public delegate void HaceAlgo(object sender,EventoHazAlgo e);
        public event HaceAlgo Evento;


        public void LLamarEvento()
        {
            Evento.Invoke(this, new EventoHazAlgo());
        }
    }
}
