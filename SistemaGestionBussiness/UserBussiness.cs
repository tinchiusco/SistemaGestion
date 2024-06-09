using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class UserBussiness
    {
        public static List<Usuario> GetUser() {
            return UserData.UserList();
        }
    }
}
