namespace SistemaGestionUI.FormProducto
{
    partial class FormCRUD_Product
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
            lblProduct = new Label();
            lblDescription = new Label();
            lblCost = new Label();
            lblSellPrice = new Label();
            lblStock = new Label();
            lblSeller = new Label();
            txtDescription = new TextBox();
            txtCost = new TextBox();
            txtSellPrice = new TextBox();
            txtStock = new TextBox();
            txtUserId = new TextBox();
            lblId = new Label();
            txtProductId = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct.Location = new Point(41, 18);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(104, 25);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Productos";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(41, 148);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(72, 15);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Descripcion";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCost.Location = new Point(41, 206);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(38, 15);
            lblCost.TabIndex = 2;
            lblCost.Text = "Costo";
            // 
            // lblSellPrice
            // 
            lblSellPrice.AutoSize = true;
            lblSellPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSellPrice.Location = new Point(41, 260);
            lblSellPrice.Name = "lblSellPrice";
            lblSellPrice.Size = new Size(94, 15);
            lblSellPrice.TabIndex = 3;
            lblSellPrice.Text = "Precio de Venta";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(41, 318);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // lblSeller
            // 
            lblSeller.AutoSize = true;
            lblSeller.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeller.Location = new Point(41, 371);
            lblSeller.Name = "lblSeller";
            lblSeller.Size = new Size(77, 15);
            lblSeller.TabIndex = 5;
            lblSeller.Text = "ID Vendedor";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(178, 140);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(239, 23);
            txtDescription.TabIndex = 6;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(178, 198);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(239, 23);
            txtCost.TabIndex = 7;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(178, 252);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(239, 23);
            txtSellPrice.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(178, 310);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(239, 23);
            txtStock.TabIndex = 9;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(178, 363);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(239, 23);
            txtUserId.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(41, 95);
            lblId.Name = "lblId";
            lblId.Size = new Size(74, 15);
            lblId.TabIndex = 11;
            lblId.Text = "ID Producto";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(178, 87);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(239, 23);
            txtProductId.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(259, 436);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(178, 436);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(97, 436);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 13;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FormCRUD_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 514);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(txtProductId);
            Controls.Add(lblId);
            Controls.Add(txtUserId);
            Controls.Add(txtStock);
            Controls.Add(txtSellPrice);
            Controls.Add(txtCost);
            Controls.Add(txtDescription);
            Controls.Add(lblSeller);
            Controls.Add(lblStock);
            Controls.Add(lblSellPrice);
            Controls.Add(lblCost);
            Controls.Add(lblDescription);
            Controls.Add(lblProduct);
            Name = "FormCRUD_Product";
            Text = "Productos";
            Load += FormCRUD_Product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private Label lblDescription;
        private Label lblCost;
        private Label lblSellPrice;
        private Label lblStock;
        private Label lblSeller;
        private TextBox txtDescription;
        private TextBox txtCost;
        private TextBox txtSellPrice;
        private TextBox txtStock;
        private TextBox txtUserId;
        private Label lblId;
        private TextBox txtProductId;
        private Button btnSave;
        private Button btnDelete;
        private Button btnBack;
    }
}