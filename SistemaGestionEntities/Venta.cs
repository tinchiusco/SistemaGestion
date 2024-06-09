using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Venta
    {
        private int _id;
        private string _commentary;
        private int _idUser;

        public Venta()
        {
            this._id = 0;
            this._commentary = String.Empty;
            this._idUser = 0;
        }
        public Venta(string comentary, int idUser)
        {
           
            this._commentary = comentary;
            this._idUser = idUser;
        }

        public Venta (int id, string commentary, int idUser) : this(commentary,idUser) 
        {
            this._id = id;
            
        }

        public int Id { get => _id;  set => this._id = value;  }
        public string Commentary { get => _commentary; set => this._commentary = value; }
        public int IdUser { get => _idUser; set => this._idUser = value; }
    }
}
