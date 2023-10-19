namespace Instituto_Terciario
{
    partial class frmInscripcion
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
            label1 = new Label();
            lblNombre = new Label();
            lblDocumento = new Label();
            lblTipo = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            cboTipo = new ComboBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(142, 22);
            label1.Name = "label1";
            label1.Size = new Size(291, 25);
            label1.TabIndex = 0;
            label1.Text = "INSCRIPCION DEL POSTULANTE";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(49, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.Location = new Point(49, 233);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(80, 17);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(49, 183);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(36, 17);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(49, 132);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 17);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(165, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(165, 131);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(157, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(165, 232);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(157, 23);
            txtDocumento.TabIndex = 7;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Extranjero" });
            cboTipo.Location = new Point(165, 182);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(157, 23);
            cboTipo.TabIndex = 8;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(255, 255, 128);
            btnIngresar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnIngresar.Location = new Point(434, 112);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(92, 42);
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 255, 128);
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(434, 173);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(92, 37);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 192, 128);
            btnSalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalir.Location = new Point(501, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(66, 35);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(579, 308);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(cboTipo);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblTipo);
            Controls.Add(lblDocumento);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INSCRIPCION DE POSTULANTE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private Label lblDocumento;
        private Label lblTipo;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private ComboBox cboTipo;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}