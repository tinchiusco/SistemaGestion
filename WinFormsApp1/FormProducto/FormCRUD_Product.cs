
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionUI.FormProducto
{
    public partial class FormCRUD_Product : Form
    {
        public FormCRUD_Product()
        {
            InitializeComponent();
        }
        public void Clean()
        {
            txtDescription.Text = "";
            txtCost.Text = "";
            txtSellPrice.Text = "";
            txtStock.Text = "";
            txtUserId.Text = "";

        }

        private void FormCRUD_Product_Load(object sender, EventArgs e)
        {
            int idProduct = FormInit.formProduct.productId;

            if (idProduct > 0)
            {


                Producto _txtProduct = ProductData.GetProductById(idProduct);


                txtDescription.Text = _txtProduct.Description;
                txtCost.Text = _txtProduct.Cost.ToString();
                txtSellPrice.Text = _txtProduct.SellPrice.ToString();
                txtStock.Text = _txtProduct.Stock.ToString();
                txtUserId.Text = _txtProduct.UserId.ToString();
                txtProductId.Text = idProduct.ToString();

            }
            else
            {
                Clean();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInit.formProduct.productId = 0;
            FormInit.formProduct.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            double cost = Convert.ToDouble(txtCost.Text);
            double sellPrice = Convert.ToDouble(txtSellPrice.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            int userId = Convert.ToInt32(txtUserId.Text);

            int productId = FormInit.formProduct.productId;

            Producto newproduct = new Producto(description, cost, sellPrice, stock, userId);

            if (productId > 0)
            {
                ProductData.UpdateProduct(productId, newproduct);
                MessageBox.Show("Se actualizo el producto");
            }
            else
            {
                ProductData.CreateProduct(newproduct);
                MessageBox.Show("Se creo el producto");
            }
            Clean();
            this.Close();
            FormInit.formProduct.productId = 0;
            FormInit.formProduct.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtProductId.Text;
            ProductData.DeleteProduct(int.Parse(id));
            MessageBox.Show("Se borro el Producto");
            Clean();
            FormInit.formProduct.productId = 0;
            this.Close();
            FormInit.formProduct.Show();
        }
    }
}




