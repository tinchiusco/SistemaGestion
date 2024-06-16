namespace SistemaGestionUI.FormProductoVendido
{
    partial class FormCRUD_SellProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSellProduct = new Label();
            lblIdSellProduct = new Label();
            lblStock = new Label();
            lblIdProduct = new Label();
            lblIdSell = new Label();
            txtIdSellProduct = new TextBox();
            txtStock = new TextBox();
            txtProductId = new TextBox();
            txtSellId = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnBackSellProduct = new Button();
            SuspendLayout();
            // 
            // lblSellProduct
            // 
            lblSellProduct.AutoSize = true;
            lblSellProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSellProduct.Location = new Point(64, 44);
            lblSellProduct.Name = "lblSellProduct";
            lblSellProduct.Size = new Size(192, 25);
            lblSellProduct.TabIndex = 0;
            lblSellProduct.Text = "Productos Vendidos";
            // 
            // lblIdSellProduct
            // 
            lblIdSellProduct.AutoSize = true;
            lblIdSellProduct.Location = new Point(64, 142);
            lblIdSellProduct.Name = "lblIdSellProduct";
            lblIdSellProduct.Size = new Size(116, 15);
            lblIdSellProduct.TabIndex = 1;
            lblIdSellProduct.Text = "ID Producto Vendido";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(64, 207);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // lblIdProduct
            // 
            lblIdProduct.AutoSize = true;
            lblIdProduct.Location = new Point(64, 269);
            lblIdProduct.Name = "lblIdProduct";
            lblIdProduct.Size = new Size(70, 15);
            lblIdProduct.TabIndex = 3;
            lblIdProduct.Text = "ID Producto";
            // 
            // lblIdSell
            // 
            lblIdSell.AutoSize = true;
            lblIdSell.Location = new Point(64, 325);
            lblIdSell.Name = "lblIdSell";
            lblIdSell.Size = new Size(50, 15);
            lblIdSell.TabIndex = 4;
            lblIdSell.Text = "ID Venta";
            // 
            // txtIdSellProduct
            // 
            txtIdSellProduct.Location = new Point(270, 134);
            txtIdSellProduct.Name = "txtIdSellProduct";
            txtIdSellProduct.ReadOnly = true;
            txtIdSellProduct.Size = new Size(213, 23);
            txtIdSellProduct.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(270, 199);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(213, 23);
            txtStock.TabIndex = 6;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(270, 261);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(213, 23);
            txtProductId.TabIndex = 7;
            // 
            // txtSellId
            // 
            txtSellId.Location = new Point(270, 317);
            txtSellId.Name = "txtSellId";
            txtSellId.Size = new Size(213, 23);
            txtSellId.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(302, 388);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 18;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(221, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBackSellProduct
            // 
            btnBackSellProduct.Location = new Point(140, 388);
            btnBackSellProduct.Name = "btnBackSellProduct";
            btnBackSellProduct.Size = new Size(75, 23);
            btnBackSellProduct.TabIndex = 16;
            btnBackSellProduct.Text = "Volver";
            btnBackSellProduct.UseVisualStyleBackColor = true;
            btnBackSellProduct.Click += btnBackSellProduct_Click;
            // 
            // FormCRUD_SellProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 450);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnBackSellProduct);
            Controls.Add(txtSellId);
            Controls.Add(txtProductId);
            Controls.Add(txtStock);
            Controls.Add(txtIdSellProduct);
            Controls.Add(lblIdSell);
            Controls.Add(lblIdProduct);
            Controls.Add(lblStock);
            Controls.Add(lblIdSellProduct);
            Controls.Add(lblSellProduct);
            Name = "FormCRUD_SellProduct";
            Text = "Productos vendidos";
            Load += FormCRUD_SellProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSellProduct;
        private Label lblIdSellProduct;
        private Label lblStock;
        private Label lblIdProduct;
        private Label lblIdSell;
        private TextBox txtIdSellProduct;
        private TextBox txtStock;
        private TextBox txtProductId;
        private TextBox txtSellId;
        private Button btnSave;
        private Button btnDelete;
        private Button btnBackSellProduct;
    }
}