using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace _001_CrearPdf
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            /*ConnectionStringSettingsCollection cones = ConfigurationManager.ConnectionStrings;

            string cone=cones["cone"].ConnectionString;

            var d = new DynamicParameters();
            d.Add("hola", "sa", direction: System.Data.ParameterDirection.InputOutput, dbType: System.Data.DbType.Int32);

            SqlConnection sqlCone = new SqlConnection(cone);
            sqlCone.Execute("sa", d);*/



            CrearPdf();

            Console.WriteLine();

               
            
        }


        
        
    }
}
