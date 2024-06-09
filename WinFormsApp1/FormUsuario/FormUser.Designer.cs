namespace SistemaGestionUI.FormUsuario
{

    partial class FormUser
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
            btnAdd = new Button();
            btnUpdate = new Button();
            dgvUser = new DataGridView();
            btnIni = new Button();
            lblUser = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(330, 103);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(647, 103);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(38, 162);
            dgvUser.Name = "dgvUser";
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(684, 255);
            dgvUser.TabIndex = 2;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // btnIni
            // 
            btnIni.Location = new Point(38, 103);
            btnIni.Name = "btnIni";
            btnIni.Size = new Size(75, 23);
            btnIni.TabIndex = 3;
            btnIni.Text = "Inicio";
            btnIni.UseVisualStyleBackColor = true;
            btnIni.Click += btnIni_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(38, 34);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(89, 25);
            lblUser.TabIndex = 4;
            lblUser.Text = "Usuarios";
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUser);
            Controls.Add(btnIni);
            Controls.Add(dgvUser);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "FormUser";
            Text = "Usuarios";
            Load += FormUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private DataGridView dgvUser;
        private Button btnIni;
        private Label lblUser;
    }
}