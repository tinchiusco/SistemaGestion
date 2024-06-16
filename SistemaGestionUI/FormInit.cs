
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionUI.FormProducto;
using SistemaGestionUI.FormProductoVendido;
using SistemaGestionUI.FormUsuario;
using SistemaGestionUI.FormVenta;

namespace SistemaGestionUI;

public partial class FormInit : Form
{
    public static FormUser formUser = new FormUser();
    public static FormProduct formProduct = new FormProduct();
    public static FormSellProduct formSellProduct = new FormSellProduct();
    public static FormSell formSell = new FormSell();
    
    public FormInit()
    {
        InitializeComponent();
    }


    private void btnUser_Click(object sender, EventArgs e)
    {
        try
        {
            this.Hide();
            formUser.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error en la carga de usuarios: {ex}");
        }
    }

    private void btnSellProduct_Click(object sender, EventArgs e)
    {
        try
        {
            this.Hide();
            formSellProduct.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error en la carga de Productos Vendidos: {ex}");
        }
    }

    private void btnProduct_Click(object sender, EventArgs e)
    {
        try
        {
            this.Hide();
            formProduct.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error en la carga de Productos: {ex}");
        }
    }

    private void btnSell_Click(object sender, EventArgs e)
    {
        try
        {
            this.Hide();
            formSell.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error en la carga de ventas: {ex}");
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
    }


}
