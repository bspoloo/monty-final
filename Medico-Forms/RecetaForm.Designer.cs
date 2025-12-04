namespace Medico_Forms
{
    partial class RecetaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNmPaciente = new System.Windows.Forms.TextBox();
            this.textBoxAPPaciente = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxDiagnostico = new System.Windows.Forms.TextBox();
            this.textBoxMedicamentos = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diagnostico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medicamentos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
            // 
            // textBoxNmPaciente
            // 
            this.textBoxNmPaciente.Location = new System.Drawing.Point(260, 34);
            this.textBoxNmPaciente.Name = "textBoxNmPaciente";
            this.textBoxNmPaciente.Size = new System.Drawing.Size(274, 20);
            this.textBoxNmPaciente.TabIndex = 6;
            this.textBoxNmPaciente.Text = "Juan Perez";
            // 
            // textBoxAPPaciente
            // 
            this.textBoxAPPaciente.Location = new System.Drawing.Point(260, 61);
            this.textBoxAPPaciente.Name = "textBoxAPPaciente";
            this.textBoxAPPaciente.Size = new System.Drawing.Size(274, 20);
            this.textBoxAPPaciente.TabIndex = 7;
            this.textBoxAPPaciente.Text = "Molina";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(260, 94);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(274, 20);
            this.textBoxFecha.TabIndex = 8;
            this.textBoxFecha.Text = "2025-03-12";
            // 
            // textBoxDiagnostico
            // 
            this.textBoxDiagnostico.Location = new System.Drawing.Point(260, 128);
            this.textBoxDiagnostico.Name = "textBoxDiagnostico";
            this.textBoxDiagnostico.Size = new System.Drawing.Size(274, 20);
            this.textBoxDiagnostico.TabIndex = 9;
            this.textBoxDiagnostico.Text = "Cancer de culo";
            // 
            // textBoxMedicamentos
            // 
            this.textBoxMedicamentos.Location = new System.Drawing.Point(260, 158);
            this.textBoxMedicamentos.Name = "textBoxMedicamentos";
            this.textBoxMedicamentos.Size = new System.Drawing.Size(274, 20);
            this.textBoxMedicamentos.TabIndex = 10;
            this.textBoxMedicamentos.Text = "paracetamol, antigripal";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(260, 192);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(126, 20);
            this.textBoxEstado.TabIndex = 11;
            this.textBoxEstado.Text = "emitido";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(341, 252);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 12;
            this.buttonInsert.Text = "Insertar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // RecetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxMedicamentos);
            this.Controls.Add(this.textBoxDiagnostico);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxAPPaciente);
            this.Controls.Add(this.textBoxNmPaciente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecetaForm";
            this.Text = "RecetaForm";
            this.Load += new System.EventHandler(this.RecetaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNmPaciente;
        private System.Windows.Forms.TextBox textBoxAPPaciente;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.TextBox textBoxDiagnostico;
        private System.Windows.Forms.TextBox textBoxMedicamentos;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label7;
    }
}