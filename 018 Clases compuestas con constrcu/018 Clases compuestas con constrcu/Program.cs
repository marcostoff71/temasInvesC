using System;
using System.Collections.Generic;
using System.Collections;

namespace _018_Clases_compuestas_con_constrcu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
    class Calif
    {
        private double cali1;
        private double cali2;

        public Calif(double c1,double c2)
        {
            this.cali1 = c1;
            this.cali2 = c2;
        }
        
        
    }
    class Estudiante:Calif
    {
        private string nombre;

        public Estudiante(string nombre,double c1,double c2):base(c1,c2)
        {

        }
        
    }
}
