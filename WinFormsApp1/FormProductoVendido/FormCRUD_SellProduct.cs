
using SistemaGestionUI.FormProductoVendido;
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

namespace SistemaGestionUI.FormProductoVendido
{
    public partial class FormCRUD_SellProduct : Form
    {
        public FormCRUD_SellProduct()
        {
            InitializeComponent();
        }
        public void Clean()
        {
            txtStock.Text = "";
            txtStock.Text = "";
            txtProductId.Text = "";
            txtSellId.Text = "";

        }




        private void FormCRUD_SellProduct_Load(object sender, EventArgs e)
        {
            int idSellProduct = FormInit.formSellProduct.sellProductId;
            if (idSellProduct > 0)
            {
                ProductoVendido _txtSell = SellProductData.GetSellProductById(idSellProduct);


                txtStock.Text = _txtSell.Stock.ToString();
                txtProductId.Text = _txtSell.IdProduct.ToString();
                txtSellId.Text = _txtSell.IdSell.ToString();
                txtIdSellProduct.Text = idSellProduct.ToString();
            }
            else
            {
                Clean();
            }
        }

        private void btnBackSellProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInit.formSellProduct.sellProductId = 0;
            FormInit.formSellProduct.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int stock = Convert.ToInt32(txtStock.Text);
            int productId = Convert.ToInt32(txtProductId.Text);
            int sellId = Convert.ToInt32(txtSellId.Text);

            int sellProductId = FormInit.formSellProduct.sellProductId;

            ProductoVendido newSellProduct = new ProductoVendido(stock, productId, sellId);

            if (sellProductId > 0)
            {
                SellProductData.UpdateSellProduct(productId, newSellProduct);
                MessageBox.Show("Se modifico el producto vendido");
            }
            else
            {
                SellProductData.CreateSellProduct(newSellProduct);
                MessageBox.Show("Se creo un nuevo producto vendido");
            }
            Clean();
            this.Close();
            FormInit.formSellProduct.sellProductId = 0;
            FormInit.formSellProduct.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string id = txtProductId.Text;
            SellProductData.DeleteSellProduct(int.Parse(id));
            MessageBox.Show("Se borro el Producto Vendido");
            Clean();
            FormInit.formSellProduct.sellProductId = 0;
            this.Close();
            FormInit.formSellProduct.Show();
        }
    }
}