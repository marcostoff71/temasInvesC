using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas_netframeword
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(proximoCumple(18,4,2002));

        }
        static string proximoCumple(int dia,int mes,int anio)
        {
            int diaNaci=dia
                , mesNaci=mes
                , anioNaci=anio;

            DateTime nacimiento = new DateTime(anioNaci, mesNaci, diaNaci);

            int anios = (int)((DateTime.Now - nacimiento).TotalDays / 354);

            DateTime proximoCumple;

           

            if (mesNaci<=DateTime.Now.Month)
            {

                    Console.WriteLine($"{DateTime.Now.Day} > {diaNaci}");
                if (diaNaci>DateTime.Now.Day)
                {
                    proximoCumple = new DateTime(DateTime.Now.Year, mesNaci, diaNaci);
                }
                else
                {

                proximoCumple = new DateTime(DateTime.Now.Year+1, mesNaci, diaNaci);
                Console.WriteLine(DateTime.Now.Year+1);
                }
                
            }
            else 
            {

                proximoCumple = new DateTime(DateTime.Now.Year, mesNaci, diaNaci,12,0,0);
            }
            TimeSpan restante = proximoCumple - new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,12,0,0);
            
            
            return $"Faltan {restante.TotalDays}";
        }
    }
}
