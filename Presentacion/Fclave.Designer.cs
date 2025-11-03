namespace Presentacion
{
    partial class Fclave
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.introducido = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(264, 208);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(71, 208);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // introducido
            // 
            this.introducido.Location = new System.Drawing.Point(216, 107);
            this.introducido.Margin = new System.Windows.Forms.Padding(4);
            this.introducido.Name = "introducido";
            this.introducido.Size = new System.Drawing.Size(147, 22);
            this.introducido.TabIndex = 2;
            this.introducido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtClave
            // 
            this.txtClave.AutoSize = true;
            this.txtClave.Location = new System.Drawing.Point(67, 107);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(42, 16);
            this.txtClave.TabIndex = 3;
            this.txtClave.Text = "Clave";
            this.txtClave.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fclave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 351);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.introducido);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fclave";
            this.Text = "Fclave";
            this.Load += new System.EventHandler(this.Fclave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox introducido;
        private System.Windows.Forms.Label txtClave;
    }
}