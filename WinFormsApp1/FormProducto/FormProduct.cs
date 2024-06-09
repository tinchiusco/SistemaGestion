

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionUI.FormProducto
{
    public partial class FormProduct : Form
    {


        public int productId;

        public FormProduct()
        {
            InitializeComponent();
        }

        public void LoadProducts() {
            List<Producto> products = ProductData.ProductList();
            dgvProduct.AutoGenerateColumns = true;
            dgvProduct.DataSource = products;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCRUD_Product formCrud_Product = new FormCRUD_Product();
            FormInit.formProduct.Hide();
            formCrud_Product.Show();
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowSelected = (int)e.RowIndex;
                productId = int.Parse(dgvProduct[0, rowSelected].Value.ToString());
            }
            FormCRUD_Product formCRUD_product = new FormCRUD_Product();
            FormInit.formProduct.Hide();
            formCRUD_product.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = null;
            dgvProduct.Refresh();
            LoadProducts();
        }

        private void btnIni_Click(object sender, EventArgs e)
        {

            this.Hide();
            Program.formInit.Show();
        }
    }
}
