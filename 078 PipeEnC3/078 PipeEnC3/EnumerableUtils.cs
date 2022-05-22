using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078_PipeEnC3
{
    public static class EnumerableUtils
    {


        public static TResult AgregateEvil<TSource,TAculate,TResult>(this IEnumerable<TSource> sources,TAculate estadoIni,Func<TAculate,TSource,TAculate> funAcumu,Func<TAculate,TResult> funFinal)
        {

            TAculate aculate = estadoIni;


            foreach(var item in sources)
            {

                aculate = funAcumu(aculate, item);
            }

            TResult result = funFinal(aculate);


            return result;
        }
        public static TAcumulate AgregateEvil<TSource,TAcumulate>(this IEnumerable<TSource> sources,Func<TAcumulate,TSource,TAcumulate> fun,TAcumulate estadoIni)
        {
            TAcumulate acumu = estadoIni;



            foreach (var item in sources)
            {
                acumu=fun(acumu, item);
            }



            return acumu;


        }
        public static TSource AgregateEvil<TSource>(this IEnumerable<TSource> sources,Func<TSource,TSource,TSource> fun )
        {

            TSource ant =default(TSource);

            foreach (var item in sources)
            {
                ant=fun(ant, item);
            }



            return ant;
        }
        public static IEnumerable<TSource> Pipe<TSource>(
            this List<TSource> sources,
            params Func<List<TSource>, List<TSource>>[] funciones)
        {
            var estadoIni = sources;

            funciones.Aggregate(estadoIni, (ant, act) => act(ant));

        

            return estadoIni;
        }
    }
}
