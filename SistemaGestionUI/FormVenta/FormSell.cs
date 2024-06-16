
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionUI.FormVenta
{
    public partial class FormSell : Form
    {

        public int sellId;
        public FormSell()
        {
            InitializeComponent();
        }

        public void LoadSells() {
            List<Venta> sells = SellBussiness.GetSells();
            dgvSell.AutoGenerateColumns = true;
            dgvSell.DataSource = sells;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCRUD_Sell formCrud = new FormCRUD_Sell();
            FormInit.formSell.Hide();
            formCrud.Show();
        }
        private void dgvSell_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)  //Verifica si se hizo clic en una fila valida
            {
                int rowSelected = (int)e.RowIndex;
                sellId = int.Parse(dgvSell[0, rowSelected].Value.ToString());
            }
            FormCRUD_Sell formCrud = new FormCRUD_Sell();
            FormInit.formSell.Hide();
            formCrud.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvSell.DataSource = null;
            dgvSell.Refresh();
            LoadSells();
        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formInit.Show();
        }



        private void FormSell_Load_1(object sender, EventArgs e)
        {
            LoadSells();
        }
    }
}