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


namespace SistemaGestionUI.FormUsuario
{

    public partial class FormCrud_User : Form
    {
        public FormCrud_User()
        {
            InitializeComponent();
        }

        public void clean()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtMail.Text = "";
            txtId.Text = "";
        }

        private void FormCrud_User_Load(object sender, EventArgs e)
        {
            int idUsuario = FormInit.formUser.userId;
            if (idUsuario > 0)
            {


                Usuario _txtUsuario = UserData.GetUserById(idUsuario);

                txtNombre.Text = _txtUsuario.Name;
                txtApellido.Text = _txtUsuario.LastName;
                txtUsuario.Text = _txtUsuario.UserName;
                txtPass.Text = _txtUsuario.Password;
                txtMail.Text = _txtUsuario.Mail;
                txtId.Text = idUsuario.ToString();
            }
            else
            {
                clean();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInit.formUser.userId = 0;
            FormInit.formUser.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            UserData.DeleteUser(int.Parse(id));
            MessageBox.Show("Se borro el usuario");
            clean();
            FormInit.formUser.userId = 0;
            this.Close();
            FormInit.formUser.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombreusuario = txtUsuario.Text;
            string contrasena = txtPass.Text;
            string mail = txtMail.Text;
            int idUsuario = FormInit.formUser.userId;

            Usuario newUser = new Usuario(nombre, apellido, nombreusuario, contrasena, mail);

            if (idUsuario > 0)
            {
                UserData.UpdateUser(idUsuario, newUser);
                MessageBox.Show("Se actualizo el usuario");
            }
            else
            {
                UserData.CreateUser(newUser);
                MessageBox.Show("Se creo el usuario");
            }
            clean();
            this.Close();
            FormInit.formUser.userId = 0;
            FormInit.formUser.Show();
        }


    }
}
