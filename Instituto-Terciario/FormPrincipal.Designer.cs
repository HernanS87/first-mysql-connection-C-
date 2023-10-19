namespace Instituto_Terciario
{
    partial class frmPrincipal
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
            btnInscribirP = new Button();
            btnAsignarC = new Button();
            btnPagarC = new Button();
            btnEmitirComp = new Button();
            btnSalir = new Button();
            lblIngreso = new Label();
            SuspendLayout();
            // 
            // btnInscribirP
            // 
            btnInscribirP.BackColor = Color.Yellow;
            btnInscribirP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnInscribirP.Location = new Point(80, 125);
            btnInscribirP.Name = "btnInscribirP";
            btnInscribirP.Size = new Size(208, 66);
            btnInscribirP.TabIndex = 0;
            btnInscribirP.Text = "Inscribir Postulante";
            btnInscribirP.UseVisualStyleBackColor = false;
            btnInscribirP.Click += btnInscribirP_Click;
            // 
            // btnAsignarC
            // 
            btnAsignarC.BackColor = Color.FromArgb(255, 255, 128);
            btnAsignarC.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAsignarC.Location = new Point(355, 125);
            btnAsignarC.Name = "btnAsignarC";
            btnAsignarC.Size = new Size(208, 66);
            btnAsignarC.TabIndex = 1;
            btnAsignarC.Text = "Asignar Curso";
            btnAsignarC.UseVisualStyleBackColor = false;
            // 
            // btnPagarC
            // 
            btnPagarC.BackColor = Color.FromArgb(255, 255, 128);
            btnPagarC.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPagarC.Location = new Point(80, 233);
            btnPagarC.Name = "btnPagarC";
            btnPagarC.Size = new Size(208, 66);
            btnPagarC.TabIndex = 2;
            btnPagarC.Text = "Pagar Curso";
            btnPagarC.UseVisualStyleBackColor = false;
            // 
            // btnEmitirComp
            // 
            btnEmitirComp.BackColor = Color.Yellow;
            btnEmitirComp.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEmitirComp.Location = new Point(355, 233);
            btnEmitirComp.Name = "btnEmitirComp";
            btnEmitirComp.Size = new Size(208, 66);
            btnEmitirComp.TabIndex = 3;
            btnEmitirComp.Text = "Emitir Comprobante de Curso";
            btnEmitirComp.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 255, 128);
            btnSalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalir.Location = new Point(538, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 37);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(80, 34);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(56, 15);
            lblIngreso.TabIndex = 5;
            lblIngreso.Text = "USUARIO";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(642, 349);
            Controls.Add(lblIngreso);
            Controls.Add(btnSalir);
            Controls.Add(btnEmitirComp);
            Controls.Add(btnPagarC);
            Controls.Add(btnAsignarC);
            Controls.Add(btnInscribirP);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VENTANA PRINCIPAL";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscribirP;
        private Button btnAsignarC;
        private Button btnPagarC;
        private Button btnEmitirComp;
        private Button btnSalir;
        private Label lblIngreso;
    }
}