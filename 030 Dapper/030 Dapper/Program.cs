using System;
using System.Data.SqlClient;
using Dapper;

namespace _030_Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaCo = @"Data Source=DESKTOP-LNAD\SQLEXPRESS;Initial Catalog=BlazorCrud;Integrated Security=True";
            SqlConnection conec = new SqlConnection(cadenaCo);
            string queri = "INSERT INTO Fimls (Title,Director,ReleaseData) values(@Title,@Directo,@ReleaseData)";
            conec.Execute("")
        }
    }
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
