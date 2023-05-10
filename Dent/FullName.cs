using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dent
{
    internal class FullName
    {
        public static string User(Пользователи user)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                var Lastname = user.Фамилия;
                var Firstname = user.Имя;
                var Middlename = user.Отчество;
                return Lastname + " " +Firstname + " " + Middlename;
            }
        }
        public static string Doctor(Врачи user)
        {
            using (DentbaseEntities db = new DentbaseEntities())
            {
                var Lastname = user.Фамилия;
                var Firstname = user.Имя;
                var Middlename = user.Отчество;
                return Lastname + " " + Firstname + " " + Middlename;
            }
        }
    }
}
