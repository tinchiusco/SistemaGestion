namespace SistemaGestionUI.FormUsuario;

partial class FormCrud_User
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
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        txtId = new TextBox();
        txtNombre = new TextBox();
        txtApellido = new TextBox();
        txtUsuario = new TextBox();
        txtPass = new TextBox();
        txtMail = new TextBox();
        lblUser = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(112, 338);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 0;
        button1.Text = "Volver";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(193, 338);
        button2.Name = "button2";
        button2.Size = new Size(75, 23);
        button2.TabIndex = 1;
        button2.Text = "Eliminar";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(274, 338);
        button3.Name = "button3";
        button3.Size = new Size(75, 23);
        button3.TabIndex = 2;
        button3.Text = "Guardar";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(33, 59);
        label1.Name = "label1";
        label1.Size = new Size(20, 15);
        label1.TabIndex = 3;
        label1.Text = "ID";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(33, 98);
        label2.Name = "label2";
        label2.Size = new Size(53, 15);
        label2.TabIndex = 4;
        label2.Text = "Nombre";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label3.Location = new Point(33, 143);
        label3.Name = "label3";
        label3.Size = new Size(52, 15);
        label3.TabIndex = 5;
        label3.Text = "Apellido";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label4.Location = new Point(33, 194);
        label4.Name = "label4";
        label4.Size = new Size(49, 15);
        label4.TabIndex = 6;
        label4.Text = "Usuario";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label5.Location = new Point(37, 280);
        label5.Name = "label5";
        label5.Size = new Size(30, 15);
        label5.TabIndex = 7;
        label5.Text = "Mail";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label6.Location = new Point(33, 235);
        label6.Name = "label6";
        label6.Size = new Size(69, 15);
        label6.TabIndex = 8;
        label6.Text = "Contrasena";
        // 
        // txtId
        // 
        txtId.Location = new Point(134, 51);
        txtId.Name = "txtId";
        txtId.ReadOnly = true;
        txtId.Size = new Size(215, 23);
        txtId.TabIndex = 9;
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(134, 90);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(215, 23);
        txtNombre.TabIndex = 10;
        // 
        // txtApellido
        // 
        txtApellido.Location = new Point(134, 135);
        txtApellido.Name = "txtApellido";
        txtApellido.Size = new Size(215, 23);
        txtApellido.TabIndex = 11;
        // 
        // txtUsuario
        // 
        txtUsuario.Location = new Point(134, 186);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(215, 23);
        txtUsuario.TabIndex = 12;
        // 
        // txtPass
        // 
        txtPass.Location = new Point(134, 227);
        txtPass.Name = "txtPass";
        txtPass.Size = new Size(215, 23);
        txtPass.TabIndex = 13;
        // 
        // txtMail
        // 
        txtMail.Location = new Point(134, 272);
        txtMail.Name = "txtMail";
        txtMail.Size = new Size(215, 23);
        txtMail.TabIndex = 14;
        // 
        // lblUser
        // 
        lblUser.AutoSize = true;
        lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        lblUser.Location = new Point(33, 9);
        lblUser.Name = "lblUser";
        lblUser.Size = new Size(89, 25);
        lblUser.TabIndex = 15;
        lblUser.Text = "Usuarios";
        // 
        // FormCrud_User
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(453, 419);
        Controls.Add(lblUser);
        Controls.Add(txtMail);
        Controls.Add(txtPass);
        Controls.Add(txtUsuario);
        Controls.Add(txtApellido);
        Controls.Add(txtNombre);
        Controls.Add(txtId);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "FormCrud_User";
        Text = "Gestion de Usuarios";
        Load += FormCrud_User_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private TextBox txtId;
    private TextBox txtNombre;
    private TextBox txtApellido;
    private TextBox txtUsuario;
    private TextBox txtPass;
    private TextBox txtMail;
    private Label lblUser;
}