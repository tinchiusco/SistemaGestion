namespace SistemaGestionUI.FormProductoVendido;

partial class FormSellProduct
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
        btnUpdate = new Button();
        btnAdd = new Button();
        dgvSellProduct = new DataGridView();
        btnIni = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvSellProduct).BeginInit();
        SuspendLayout();
        // 
        // lblSellProduct
        // 
        lblSellProduct.AutoSize = true;
        lblSellProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        lblSellProduct.Location = new Point(34, 27);
        lblSellProduct.Name = "lblSellProduct";
        lblSellProduct.Size = new Size(190, 25);
        lblSellProduct.TabIndex = 0;
        lblSellProduct.Text = "Productos vendidos";
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(308, 89);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(75, 23);
        btnUpdate.TabIndex = 1;
        btnUpdate.Text = "Actualizar";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(602, 89);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(75, 23);
        btnAdd.TabIndex = 2;
        btnAdd.Text = "Agregar";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // dgvSellProduct
        // 
        dgvSellProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSellProduct.Location = new Point(34, 147);
        dgvSellProduct.Name = "dgvSellProduct";
        dgvSellProduct.RowTemplate.Height = 25;
        dgvSellProduct.Size = new Size(643, 272);
        dgvSellProduct.TabIndex = 3;
        dgvSellProduct.CellClick += dgvSellProduct_CellClick;
        // 
        // btnIni
        // 
        btnIni.Location = new Point(34, 89);
        btnIni.Name = "btnIni";
        btnIni.Size = new Size(75, 23);
        btnIni.TabIndex = 4;
        btnIni.Text = "Inicio";
        btnIni.UseVisualStyleBackColor = true;
        btnIni.Click += btnIni_Click;
        // 
        // FormSellProduct
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(750, 450);
        Controls.Add(btnIni);
        Controls.Add(dgvSellProduct);
        Controls.Add(btnAdd);
        Controls.Add(btnUpdate);
        Controls.Add(lblSellProduct);
        Name = "FormSellProduct";
        Text = "Productos vendidos";
        Load += FormSellProduct_Load;
        ((System.ComponentModel.ISupportInitialize)dgvSellProduct).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblSellProduct;
    private Button btnUpdate;
    private Button btnAdd;
    private DataGridView dgvSellProduct;
    private Button btnIni;
}