namespace Presentacion
{
    partial class FAltaCliente
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
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBDNI = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.BTAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "email";
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(162, 138);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(100, 22);
            this.TBApellido.TabIndex = 4;
            // 
            // TBDNI
            // 
            this.TBDNI.Location = new System.Drawing.Point(162, 62);
            this.TBDNI.Name = "TBDNI";
            this.TBDNI.Size = new System.Drawing.Size(100, 22);
            this.TBDNI.TabIndex = 5;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(162, 178);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 22);
            this.TBEmail.TabIndex = 6;
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(162, 100);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(100, 22);
            this.TBnombre.TabIndex = 7;
            // 
            // BTCancelar
            // 
            this.BTCancelar.Location = new System.Drawing.Point(333, 252);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTCancelar.TabIndex = 8;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // BTAceptar
            // 
            this.BTAceptar.Location = new System.Drawing.Point(119, 252);
            this.BTAceptar.Name = "BTAceptar";
            this.BTAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTAceptar.TabIndex = 9;
            this.BTAceptar.Text = "Aceptar";
            this.BTAceptar.UseVisualStyleBackColor = true;
            this.BTAceptar.Click += new System.EventHandler(this.BTAceptar_Click);
            // 
            // FAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTAceptar);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBDNI);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAltaCliente";
            this.Text = "FAltaCliente";
            this.Load += new System.EventHandler(this.FAltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBDNI;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.Button BTAceptar;
    }
}