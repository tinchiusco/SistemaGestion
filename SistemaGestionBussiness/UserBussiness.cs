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
        //Cuidar que los metodos se escriben igual pero vienen de distintas clases
        public static void CreateUser(Usuario user) => UserData.CreateUser(user);
        public static void DeleteUser(int id) => UserData.DeleteUser(id);
        public static void UpdateUser(Usuario user) => UserData.UpdateUser(user.Id, user);    
        public static Usuario GetUserById(int id) => UserData.GetUserById(id);
        public static List<Usuario> GetUsers() => UserData.UserList();
    }
}
