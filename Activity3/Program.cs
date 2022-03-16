using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Activity3
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }

        public void Connecting() 
        {
            using (SqlConnection con = new SqlConnection("data source= MADD\\AHMADMM; database=ProdiTI; User ID= sa; Password=root"))
            {
                con.Open();
                Console.WriteLine("Berhasil Terhubung ke Database");
            }
        }
    }
}