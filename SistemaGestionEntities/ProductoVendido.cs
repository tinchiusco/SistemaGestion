using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class ProductoVendido
    {
        private int _id;
        private int _stock;
        private int _idProduct;
        private int _idSell;

        public ProductoVendido()
        {  
        }

        public ProductoVendido(int stock, int idProduct, int idSell)
        {
            this._stock = stock;
            this._idProduct = idProduct;
            this._idSell = idSell;
        }

        public ProductoVendido(int id, int stock, int idProduct, int idSell) : this(stock, idProduct, idSell)
        {
            this._id = id;
            
        }

        public int Id { get => _id;  set => this._id = value;} 
        public int Stock { get => _stock; set => this._stock = value;}
        public int IdProduct { get => _idProduct; set => this._idProduct = value;} 
        public int IdSell { get => _idSell; set => this._idSell = value;} 
    }

}
