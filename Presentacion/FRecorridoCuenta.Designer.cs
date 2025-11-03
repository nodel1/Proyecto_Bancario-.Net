namespace Presentacion
{
    partial class FRecorridoCuenta
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
            this.TBEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBTipo = new System.Windows.Forms.TextBox();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.TBIBAN = new System.Windows.Forms.TextBox();
            this.TBSaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelposicion = new System.Windows.Forms.Label();
            this.BTSiguiente = new System.Windows.Forms.Button();
            this.BTPrimero = new System.Windows.Forms.Button();
            this.BTAnterior = new System.Windows.Forms.Button();
            this.BTUltimo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TBEstado
            // 
            this.TBEstado.Location = new System.Drawing.Point(343, 258);
            this.TBEstado.Name = "TBEstado";
            this.TBEstado.ReadOnly = true;
            this.TBEstado.Size = new System.Drawing.Size(177, 22);
            this.TBEstado.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Estado";
            // 
            // TBTipo
            // 
            this.TBTipo.Location = new System.Drawing.Point(343, 140);
            this.TBTipo.Name = "TBTipo";
            this.TBTipo.ReadOnly = true;
            this.TBTipo.Size = new System.Drawing.Size(177, 22);
            this.TBTipo.TabIndex = 40;
            // 
            // TBFecha
            // 
            this.TBFecha.Location = new System.Drawing.Point(343, 218);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(177, 22);
            this.TBFecha.TabIndex = 39;
            // 
            // TBIBAN
            // 
            this.TBIBAN.Location = new System.Drawing.Point(343, 102);
            this.TBIBAN.Name = "TBIBAN";
            this.TBIBAN.ReadOnly = true;
            this.TBIBAN.Size = new System.Drawing.Size(177, 22);
            this.TBIBAN.TabIndex = 38;
            // 
            // TBSaldo
            // 
            this.TBSaldo.Location = new System.Drawing.Point(343, 178);
            this.TBSaldo.Name = "TBSaldo";
            this.TBSaldo.ReadOnly = true;
            this.TBSaldo.Size = new System.Drawing.Size(177, 22);
            this.TBSaldo.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha de apertura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "IBAN:";
            // 
            // labelposicion
            // 
            this.labelposicion.AutoSize = true;
            this.labelposicion.Location = new System.Drawing.Point(376, 36);
            this.labelposicion.Name = "labelposicion";
            this.labelposicion.Size = new System.Drawing.Size(0, 16);
            this.labelposicion.TabIndex = 32;
            // 
            // BTSiguiente
            // 
            this.BTSiguiente.Location = new System.Drawing.Point(470, 29);
            this.BTSiguiente.Name = "BTSiguiente";
            this.BTSiguiente.Size = new System.Drawing.Size(75, 23);
            this.BTSiguiente.TabIndex = 31;
            this.BTSiguiente.Text = "Siguiente";
            this.BTSiguiente.UseVisualStyleBackColor = true;
            this.BTSiguiente.Click += new System.EventHandler(this.BTSiguiente_Click);
            // 
            // BTPrimero
            // 
            this.BTPrimero.Location = new System.Drawing.Point(148, 29);
            this.BTPrimero.Name = "BTPrimero";
            this.BTPrimero.Size = new System.Drawing.Size(75, 23);
            this.BTPrimero.TabIndex = 30;
            this.BTPrimero.Text = "Primero";
            this.BTPrimero.UseVisualStyleBackColor = true;
            this.BTPrimero.Click += new System.EventHandler(this.BTPrimero_Click);
            // 
            // BTAnterior
            // 
            this.BTAnterior.Location = new System.Drawing.Point(255, 29);
            this.BTAnterior.Name = "BTAnterior";
            this.BTAnterior.Size = new System.Drawing.Size(75, 23);
            this.BTAnterior.TabIndex = 29;
            this.BTAnterior.Text = "Anterior";
            this.BTAnterior.UseVisualStyleBackColor = true;
            this.BTAnterior.Click += new System.EventHandler(this.BTAnterior_Click);
            // 
            // BTUltimo
            // 
            this.BTUltimo.Location = new System.Drawing.Point(564, 29);
            this.BTUltimo.Name = "BTUltimo";
            this.BTUltimo.Size = new System.Drawing.Size(75, 23);
            this.BTUltimo.TabIndex = 28;
            this.BTUltimo.Text = "Último";
            this.BTUltimo.UseVisualStyleBackColor = true;
            this.BTUltimo.Click += new System.EventHandler(this.BTUltimo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Titulares:";
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Location = new System.Drawing.Point(333, 298);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(233, 132);
            this.listbox.TabIndex = 45;
            // 
            // FRecorridoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBTipo);
            this.Controls.Add(this.TBFecha);
            this.Controls.Add(this.TBIBAN);
            this.Controls.Add(this.TBSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelposicion);
            this.Controls.Add(this.BTSiguiente);
            this.Controls.Add(this.BTPrimero);
            this.Controls.Add(this.BTAnterior);
            this.Controls.Add(this.BTUltimo);
            this.Name = "FRecorridoCuenta";
            this.Text = "FRecorridoCuenta";
            this.Load += new System.EventHandler(this.FRecorridoCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBTipo;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.TextBox TBIBAN;
        private System.Windows.Forms.TextBox TBSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelposicion;
        private System.Windows.Forms.Button BTSiguiente;
        private System.Windows.Forms.Button BTPrimero;
        private System.Windows.Forms.Button BTAnterior;
        private System.Windows.Forms.Button BTUltimo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listbox;
    }
}