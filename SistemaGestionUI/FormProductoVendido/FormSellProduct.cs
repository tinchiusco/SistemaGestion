

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

namespace SistemaGestionUI.FormProductoVendido;

public partial class FormSellProduct : Form
{


    public int sellProductId;
    public FormSellProduct()
    {
        InitializeComponent();
    }

    private void LoadSellProducts() {
        List<ProductoVendido> sellProducts = SellProductData.SellProductList();
        dgvSellProduct.AutoGenerateColumns=true;
        dgvSellProduct.DataSource=sellProducts;
    }

    private void dgvSellProduct_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            int rowSelected = (int)e.RowIndex;
            sellProductId = int.Parse(dgvSellProduct[0, rowSelected].Value.ToString());
        }
        FormCRUD_SellProduct formCrud_SellProduct = new FormCRUD_SellProduct();
        FormInit.formSellProduct.Hide();
        formCrud_SellProduct.Show();
    }


    private void FormSellProduct_Load(object sender, EventArgs e)
    {
        LoadSellProducts();
    }



    private void btnIni_Click(object sender, EventArgs e)
    {
        this.Hide();
        Program.formInit.Show();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        dgvSellProduct.DataSource = null;
        dgvSellProduct.Refresh();
        LoadSellProducts();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        FormCRUD_SellProduct formCrud = new FormCRUD_SellProduct();
        FormInit.formSellProduct.Hide();
        formCrud.Show();
    }
}


