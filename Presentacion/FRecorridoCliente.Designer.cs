namespace Presentacion
{
    partial class FRecorridoCliente
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
            this.BTUltimo = new System.Windows.Forms.Button();
            this.BTAnterior = new System.Windows.Forms.Button();
            this.BTPrimero = new System.Windows.Forms.Button();
            this.BTSiguiente = new System.Windows.Forms.Button();
            this.labelposicion = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBDNI = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTUltimo
            // 
            this.BTUltimo.Location = new System.Drawing.Point(514, 50);
            this.BTUltimo.Name = "BTUltimo";
            this.BTUltimo.Size = new System.Drawing.Size(75, 23);
            this.BTUltimo.TabIndex = 0;
            this.BTUltimo.Text = "Último";
            this.BTUltimo.UseVisualStyleBackColor = true;
            this.BTUltimo.Click += new System.EventHandler(this.BTUltimo_Click);
            // 
            // BTAnterior
            // 
            this.BTAnterior.Location = new System.Drawing.Point(205, 50);
            this.BTAnterior.Name = "BTAnterior";
            this.BTAnterior.Size = new System.Drawing.Size(75, 23);
            this.BTAnterior.TabIndex = 1;
            this.BTAnterior.Text = "Anterior";
            this.BTAnterior.UseVisualStyleBackColor = true;
            this.BTAnterior.Click += new System.EventHandler(this.BTAnterior_Click);
            // 
            // BTPrimero
            // 
            this.BTPrimero.Location = new System.Drawing.Point(98, 50);
            this.BTPrimero.Name = "BTPrimero";
            this.BTPrimero.Size = new System.Drawing.Size(75, 23);
            this.BTPrimero.TabIndex = 2;
            this.BTPrimero.Text = "Primero";
            this.BTPrimero.UseVisualStyleBackColor = true;
            this.BTPrimero.Click += new System.EventHandler(this.BTPrimero_Click);
            // 
            // BTSiguiente
            // 
            this.BTSiguiente.Location = new System.Drawing.Point(420, 50);
            this.BTSiguiente.Name = "BTSiguiente";
            this.BTSiguiente.Size = new System.Drawing.Size(75, 23);
            this.BTSiguiente.TabIndex = 3;
            this.BTSiguiente.Text = "Siguiente";
            this.BTSiguiente.UseVisualStyleBackColor = true;
            this.BTSiguiente.Click += new System.EventHandler(this.BTSiguiente_Click);
            // 
            // labelposicion
            // 
            this.labelposicion.AutoSize = true;
            this.labelposicion.Location = new System.Drawing.Point(326, 57);
            this.labelposicion.Name = "labelposicion";
            this.labelposicion.Size = new System.Drawing.Size(0, 16);
            this.labelposicion.TabIndex = 4;
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(293, 161);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.ReadOnly = true;
            this.TBnombre.Size = new System.Drawing.Size(177, 22);
            this.TBnombre.TabIndex = 25;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(293, 239);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.ReadOnly = true;
            this.TBEmail.Size = new System.Drawing.Size(177, 22);
            this.TBEmail.TabIndex = 24;
            // 
            // TBDNI
            // 
            this.TBDNI.Location = new System.Drawing.Point(293, 123);
            this.TBDNI.Name = "TBDNI";
            this.TBDNI.ReadOnly = true;
            this.TBDNI.Size = new System.Drawing.Size(177, 22);
            this.TBDNI.TabIndex = 23;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(293, 199);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.ReadOnly = true;
            this.TBApellido.Size = new System.Drawing.Size(177, 22);
            this.TBApellido.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Saldo";
            // 
            // TBSaldo
            // 
            this.TBSaldo.Location = new System.Drawing.Point(293, 279);
            this.TBSaldo.Name = "TBSaldo";
            this.TBSaldo.ReadOnly = true;
            this.TBSaldo.Size = new System.Drawing.Size(177, 22);
            this.TBSaldo.TabIndex = 27;
            // 
            // FRecorridoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBDNI);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelposicion);
            this.Controls.Add(this.BTSiguiente);
            this.Controls.Add(this.BTPrimero);
            this.Controls.Add(this.BTAnterior);
            this.Controls.Add(this.BTUltimo);
            this.Name = "FRecorridoCliente";
            this.Text = "FRecorridoCliente";
            this.Load += new System.EventHandler(this.FRecorridoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTUltimo;
        private System.Windows.Forms.Button BTAnterior;
        private System.Windows.Forms.Button BTPrimero;
        private System.Windows.Forms.Button BTSiguiente;
        private System.Windows.Forms.Label labelposicion;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBDNI;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBSaldo;
    }
}