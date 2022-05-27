using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Rental_System
{
    internal class AdminUser
    {
        static string AdminName = "admin";
        public static string Admin_Name
        {
            get => AdminName;
            set => AdminName = value;
        }
    }
}
