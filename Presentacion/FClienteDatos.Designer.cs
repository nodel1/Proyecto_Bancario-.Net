namespace Presentacion
{
    partial class FClienteDatos
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
            this.BTCancelar = new System.Windows.Forms.Button();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBDNI = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTCancelar
            // 
            this.BTCancelar.Location = new System.Drawing.Point(317, 303);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTCancelar.TabIndex = 18;
            this.BTCancelar.Text = "Cerrar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(317, 157);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.ReadOnly = true;
            this.TBnombre.Size = new System.Drawing.Size(177, 22);
            this.TBnombre.TabIndex = 17;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(317, 235);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.ReadOnly = true;
            this.TBEmail.Size = new System.Drawing.Size(177, 22);
            this.TBEmail.TabIndex = 16;
            // 
            // TBDNI
            // 
            this.TBDNI.Location = new System.Drawing.Point(317, 119);
            this.TBDNI.Name = "TBDNI";
            this.TBDNI.ReadOnly = true;
            this.TBDNI.Size = new System.Drawing.Size(177, 22);
            this.TBDNI.TabIndex = 15;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(317, 195);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.ReadOnly = true;
            this.TBApellido.Size = new System.Drawing.Size(177, 22);
            this.TBApellido.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "DNI:";
            // 
            // FClienteDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBDNI);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FClienteDatos";
            this.Text = "Datos del cliente";
            this.Load += new System.EventHandler(this.FClienteDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBDNI;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}