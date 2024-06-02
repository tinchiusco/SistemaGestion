using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMuebles.Models
{
    public class Usuario
    {
        
        private int _id;
        private string _name;
        private string _lastname;
        private string _userName;
        private string _password;
        private string _mail;

        public Usuario() { }
        public Usuario(string name, string lastName, string userName, string password, string mail)
        {

            this._name = name;
            this._lastname = lastName;
            this._userName = userName;
            this._password = password;
            this._mail = mail;
        }
        public Usuario(int id, string name, string lastname, string userName, string password, string mail) : this( name, lastname, userName, password, mail)
        {
            this._id = id;

        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string LastName { get => _lastname; set => _lastname = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Mail { get => _mail; set => _mail = value; }


        public override string ToString()
        {
            return $"Id = {this._id} - Nombre = {this._name} - Apellido = {this._lastname} - Nombre de Usuario = {this._userName}  - Password = {this._password} - Email = {this._mail}";
        }
    }
}

