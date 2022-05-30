using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Rental_System
{
    internal class sqlCon
    {
        static string _sqlcon = @"Data Source=MISHOO; Initial Catalog=Game-Over; Integrated Security=True";
        public static string sqlcon
        {
            get => _sqlcon;
        }
    }
}
