

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionEntities;
using SistemaGestionBussiness;

namespace SistemaGestionUI.FormUsuario
{
    public partial class FormUser : Form
    {


        public int userId;
        public FormUser()
        {
            InitializeComponent();
        }

        public void LoadUsers() {
            List<Usuario> usuarios = UserBussiness.GetUsers();
            dgvUser.AutoGenerateColumns = true;
            dgvUser.DataSource = usuarios;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCrud_User formCrud_User = new FormCrud_User();
            FormInit.formUser.Hide();
            formCrud_User.Show();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  //Verifica si se hizo clic en una fila valida
            {
                int filaSeleccionada = (int)e.RowIndex;
                userId = int.Parse(dgvUser[0, filaSeleccionada].Value.ToString());
            }
            FormCrud_User formCrud_User = new FormCrud_User();
            FormInit.formUser.Hide();
            formCrud_User.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = null;
            dgvUser.Refresh();
            LoadUsers();
        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formInit.Show();
        }
    }
}
