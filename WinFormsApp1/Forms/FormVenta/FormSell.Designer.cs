namespace GestionMuebles.Forms.FormVenta
{
    partial class FormSell
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
            dgvSell = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            lblVenta = new Label();
            btnIni = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSell).BeginInit();
            SuspendLayout();
            // 
            // dgvSell
            // 
            dgvSell.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSell.Location = new Point(79, 177);
            dgvSell.Name = "dgvSell";
            dgvSell.RowTemplate.Height = 25;
            dgvSell.Size = new Size(671, 274);
            dgvSell.TabIndex = 7;
            dgvSell.CellClick += dgvSell_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(675, 105);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(377, 105);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVenta.Location = new Point(79, 26);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(71, 25);
            lblVenta.TabIndex = 4;
            lblVenta.Text = "Ventas";
            // 
            // btnIni
            // 
            btnIni.Location = new Point(79, 105);
            btnIni.Name = "btnIni";
            btnIni.Size = new Size(75, 23);
            btnIni.TabIndex = 8;
            btnIni.Text = "Inicio";
            btnIni.UseVisualStyleBackColor = true;
            btnIni.Click += btnIni_Click;
            // 
            // FormSell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 480);
            Controls.Add(btnIni);
            Controls.Add(dgvSell);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(lblVenta);
            Name = "FormSell";
            Text = "Gestion de Ventas";
            Load += FormSell_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvSell).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSell;
        private Button btnAdd;
        private Button btnUpdate;
        private Label lblVenta;
        private Button btnIni;
    }
}