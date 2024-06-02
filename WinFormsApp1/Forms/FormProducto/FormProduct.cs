using GestionMuebles.Database;
using GestionMuebles.Forms.FormProductoVendido;
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

namespace GestionMuebles.Forms.FormProducto
{
    public partial class FormProduct : Form
    {


        public int productId;

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            productId = 0;
            dgvProduct.AutoGenerateColumns = true;
            dgvProduct.DataSource = ProductData.ProductList();
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
            dgvProduct.DataSource = ProductData.ProductList();
            dgvProduct.AutoGenerateColumns = true;
        }

        private void btnIni_Click(object sender, EventArgs e)
        {

            this.Hide();
            Program.formInit.Show();
        }
    }
}
