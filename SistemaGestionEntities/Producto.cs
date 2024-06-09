using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Producto
    {
        private int _id;
        private string _description;
        private double _cost;
        private double _sellPrice;
        private int _stock;
        private int _userId;

        //Constructor sin parametros
        public Producto() { }
        

        //Constructor con parametros
        public Producto(string description, double cost, double sellPrice, int stock, int idUser)
        {

            this._description = description;
            this._cost = cost;
            this._sellPrice = sellPrice;
            this._stock = stock;
            this._userId = idUser;
        }

        public Producto(int id, string description, double cost, double sellPrice, int stock, int idUser) : this(description, cost, sellPrice, stock, idUser)
        {
            this._id = id;
        }


        public int Id { get => _id; set =>_id = value;  }
        public string Description { get => _description; set =>_description = value; } 
        public double Cost { get => _cost; set =>_cost = value; }
        public double SellPrice { get => _sellPrice; set =>_sellPrice = value; } 
        public int Stock { get => _stock;  set => _stock = value;  }
        public int UserId { get => _userId; set =>_userId = value; }

        public override string ToString()
        {
            return $"Id = {this._id} - Descripciones = {this._description} - Costo = {this._cost} - PrecioVenta = {this._sellPrice}  - Stock = {this._stock} - IdUsuario = {this._userId}";
        }
    }
}



