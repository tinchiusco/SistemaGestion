

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

namespace SistemaGestionUI.FormVenta
{
    public partial class FormCRUD_Sell : Form
    {
        public FormCRUD_Sell()
        {
            InitializeComponent();
        }

        public void Clean()
        {
            txtSellId.Text = "";
            txtCommentary.Text = "";
            txtUserId.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtSellId.Text;
            SellData.DeleteSell(int.Parse(id));
            MessageBox.Show("Se borro la Venta");
            Clean();
            FormInit.formSell.sellId = 0;
            this.Close();
            FormInit.formSell.Show();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string commentary = txtCommentary.Text.ToString();
            int userID = Convert.ToInt32(txtUserId.Text);


            int sellId = FormInit.formSell.sellId;

            Venta newSell = new Venta(commentary, userID);

            if (sellId > 0)
            {
                SellData.UpdateSell(sellId, newSell);
                MessageBox.Show("Se modifico la venta");
            }
            else
            {
                SellData.CreateSell(newSell);
                MessageBox.Show("Se creo una nueva venta");
            }
            Clean();
            this.Close();
            FormInit.formSell.sellId = 0;
            FormInit.formSell.Show();
        }

        private void FormCRUD_Sell_Load(object sender, EventArgs e)
        {
            int idSell = FormInit.formSell.sellId;
            if (idSell > 0)
            {
                Venta _txtSell = SellData.GetSellById(idSell);

                txtSellId.Text = idSell.ToString();
                txtCommentary.Text = _txtSell.Commentary;
                txtUserId.Text = _txtSell.IdUser.ToString();

            }
            else
            {
                Clean();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInit.formSell.sellId = 0;
            FormInit.formSell.Show();
        }
    }
}