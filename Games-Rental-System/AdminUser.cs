using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Rental_System
{
    internal class AdminUser
    {
        static string AdminName;
        public static string Admin_Name
        {
            get {
                return AdminName; 
            }
            set {
                AdminName = value; 
            }
        }
    }
}
