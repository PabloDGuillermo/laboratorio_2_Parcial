namespace FrmAtencion
{
    partial class FrmAtencion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAtender = new Button();
            btnSalir = new Button();
            lblMedicos = new Label();
            lblPacientes = new Label();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            SuspendLayout();
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(632, 27);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(156, 62);
            btnAtender.TabIndex = 0;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(632, 387);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(156, 51);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(12, 9);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(95, 15);
            lblMedicos.TabIndex = 2;
            lblMedicos.Text = "Personal Medico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(326, 9);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(57, 15);
            lblPacientes.TabIndex = 3;
            lblPacientes.Text = "Pacientes";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 27);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(308, 199);
            lstMedicos.TabIndex = 4;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(326, 27);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(300, 199);
            lstPacientes.TabIndex = 5;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 232);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(614, 206);
            rtbInfoMedico.TabIndex = 6;
            rtbInfoMedico.Text = "";
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Name = "FrmAtencion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pablo Guillermo";
            Load += FrmAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtender;
        private Button btnSalir;
        private Label lblMedicos;
        private Label lblPacientes;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
    }
}
