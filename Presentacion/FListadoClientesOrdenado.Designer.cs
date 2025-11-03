namespace Presentacion
{
    partial class FListadoClientesOrdenado
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
            this.btnombre = new System.Windows.Forms.Button();
            this.btsaldo = new System.Windows.Forms.Button();
            this.btdni = new System.Windows.Forms.Button();
            this.lbdni = new System.Windows.Forms.ListBox();
            this.lbnombre = new System.Windows.Forms.ListBox();
            this.lbsaldo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnombre
            // 
            this.btnombre.Location = new System.Drawing.Point(344, 45);
            this.btnombre.Name = "btnombre";
            this.btnombre.Size = new System.Drawing.Size(75, 23);
            this.btnombre.TabIndex = 0;
            this.btnombre.Text = "Nombre";
            this.btnombre.UseVisualStyleBackColor = true;
            this.btnombre.Click += new System.EventHandler(this.btnombre_Click);
            // 
            // btsaldo
            // 
            this.btsaldo.Location = new System.Drawing.Point(566, 45);
            this.btsaldo.Name = "btsaldo";
            this.btsaldo.Size = new System.Drawing.Size(75, 23);
            this.btsaldo.TabIndex = 1;
            this.btsaldo.Text = "Saldo";
            this.btsaldo.UseVisualStyleBackColor = true;
            this.btsaldo.Click += new System.EventHandler(this.btsaldo_Click);
            // 
            // btdni
            // 
            this.btdni.Location = new System.Drawing.Point(109, 45);
            this.btdni.Name = "btdni";
            this.btdni.Size = new System.Drawing.Size(75, 26);
            this.btdni.TabIndex = 2;
            this.btdni.Text = "DNI";
            this.btdni.UseVisualStyleBackColor = true;
            this.btdni.Click += new System.EventHandler(this.btdni_Click);
            // 
            // lbdni
            // 
            this.lbdni.FormattingEnabled = true;
            this.lbdni.ItemHeight = 16;
            this.lbdni.Location = new System.Drawing.Point(81, 103);
            this.lbdni.Name = "lbdni";
            this.lbdni.Size = new System.Drawing.Size(158, 244);
            this.lbdni.TabIndex = 5;
            // 
            // lbnombre
            // 
            this.lbnombre.FormattingEnabled = true;
            this.lbnombre.ItemHeight = 16;
            this.lbnombre.Location = new System.Drawing.Point(321, 103);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(158, 244);
            this.lbnombre.TabIndex = 6;
            // 
            // lbsaldo
            // 
            this.lbsaldo.FormattingEnabled = true;
            this.lbsaldo.ItemHeight = 16;
            this.lbsaldo.Location = new System.Drawing.Point(539, 103);
            this.lbsaldo.Name = "lbsaldo";
            this.lbsaldo.Size = new System.Drawing.Size(158, 244);
            this.lbsaldo.TabIndex = 7;
            // 
            // FListadoClientesOrdenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbsaldo);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lbdni);
            this.Controls.Add(this.btdni);
            this.Controls.Add(this.btsaldo);
            this.Controls.Add(this.btnombre);
            this.Name = "FListadoClientesOrdenado";
            this.Text = "FListadoClientesOrdenado";
            this.Load += new System.EventHandler(this.FListadoClientesOrdenado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnombre;
        private System.Windows.Forms.Button btsaldo;
        private System.Windows.Forms.Button btdni;
        private System.Windows.Forms.ListBox lbdni;
        private System.Windows.Forms.ListBox lbnombre;
        private System.Windows.Forms.ListBox lbsaldo;
    }
}