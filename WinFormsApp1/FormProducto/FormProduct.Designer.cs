namespace SistemaGestionUI.FormProducto
{
    partial class FormProduct
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
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvProduct = new DataGridView();
            btnIni = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct.Location = new Point(51, 39);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(104, 25);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Productos";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(348, 84);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(682, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(51, 133);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.Size = new Size(706, 311);
            dgvProduct.TabIndex = 3;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // btnIni
            // 
            btnIni.Location = new Point(51, 84);
            btnIni.Name = "btnIni";
            btnIni.Size = new Size(75, 23);
            btnIni.TabIndex = 4;
            btnIni.Text = "Inicio";
            btnIni.UseVisualStyleBackColor = true;
            btnIni.Click += btnIni_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 488);
            Controls.Add(btnIni);
            Controls.Add(dgvProduct);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(lblProduct);
            Name = "FormProduct";
            Text = "Productos";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvProduct;
        private Button btnIni;
    }
}