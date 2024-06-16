namespace SistemaGestionUI.FormVenta
{
    partial class FormCRUD_Sell
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
            btnSave = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            txtSellId = new TextBox();
            lblId = new Label();
            txtUserId = new TextBox();
            txtCommentary = new TextBox();
            lblUserId = new Label();
            lblComentary = new Label();
            lblVenta = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(258, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 31;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(177, 280);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(96, 280);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 29;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtSellId
            // 
            txtSellId.Location = new Point(177, 87);
            txtSellId.Name = "txtSellId";
            txtSellId.ReadOnly = true;
            txtSellId.Size = new Size(239, 23);
            txtSellId.TabIndex = 28;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(40, 95);
            lblId.Name = "lblId";
            lblId.Size = new Size(55, 15);
            lblId.TabIndex = 27;
            lblId.Text = "ID Venta";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(177, 198);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(239, 23);
            txtUserId.TabIndex = 23;
            // 
            // txtCommentary
            // 
            txtCommentary.Location = new Point(177, 140);
            txtCommentary.Name = "txtCommentary";
            txtCommentary.Size = new Size(239, 23);
            txtCommentary.TabIndex = 22;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserId.Location = new Point(40, 206);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(75, 15);
            lblUserId.TabIndex = 18;
            lblUserId.Text = "Id Vendedor";
            // 
            // lblComentary
            // 
            lblComentary.AutoSize = true;
            lblComentary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComentary.ForeColor = SystemColors.ControlText;
            lblComentary.Location = new Point(40, 148);
            lblComentary.Name = "lblComentary";
            lblComentary.Size = new Size(77, 15);
            lblComentary.TabIndex = 17;
            lblComentary.Text = "Comentarios";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVenta.Location = new Point(40, 18);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(71, 25);
            lblVenta.TabIndex = 16;
            lblVenta.Text = "Ventas";
            // 
            // FormCRUD_Sell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 330);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(txtSellId);
            Controls.Add(lblId);
            Controls.Add(txtUserId);
            Controls.Add(txtCommentary);
            Controls.Add(lblUserId);
            Controls.Add(lblComentary);
            Controls.Add(lblVenta);
            Name = "FormCRUD_Sell";
            Text = "Ventas";
            Load += FormCRUD_Sell_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnDelete;
        private Button btnBack;
        private TextBox txtSellId;
        private Label lblId;
        private TextBox txtUserId;
        private TextBox txtCommentary;
        private Label lblUserId;
        private Label lblComentary;
        private Label lblVenta;
    }
}