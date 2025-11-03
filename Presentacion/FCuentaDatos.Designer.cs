namespace Presentacion
{
    partial class FCuentaDatos
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
            this.listbox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Location = new System.Drawing.Point(297, 259);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(233, 132);
            this.listbox.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Titulares:";
            // 
            // TBEstado
            // 
            this.TBEstado.Location = new System.Drawing.Point(307, 219);
            this.TBEstado.Name = "TBEstado";
            this.TBEstado.ReadOnly = true;
            this.TBEstado.Size = new System.Drawing.Size(177, 22);
            this.TBEstado.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Estado";
            // 
            // TBTipo
            // 
            this.TBTipo.Location = new System.Drawing.Point(307, 101);
            this.TBTipo.Name = "TBTipo";
            this.TBTipo.ReadOnly = true;
            this.TBTipo.Size = new System.Drawing.Size(177, 22);
            this.TBTipo.TabIndex = 53;
            // 
            // TBFecha
            // 
            this.TBFecha.Location = new System.Drawing.Point(307, 179);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(177, 22);
            this.TBFecha.TabIndex = 52;
            // 
            // TBIBAN
            // 
            this.TBIBAN.Location = new System.Drawing.Point(307, 63);
            this.TBIBAN.Name = "TBIBAN";
            this.TBIBAN.ReadOnly = true;
            this.TBIBAN.Size = new System.Drawing.Size(177, 22);
            this.TBIBAN.TabIndex = 51;
            // 
            // TBSaldo
            // 
            this.TBSaldo.Location = new System.Drawing.Point(307, 139);
            this.TBSaldo.Name = "TBSaldo";
            this.TBSaldo.ReadOnly = true;
            this.TBSaldo.Size = new System.Drawing.Size(177, 22);
            this.TBSaldo.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Fecha de apertura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "IBAN:";
            // 
            // FCuentaDatos
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
            this.Name = "FCuentaDatos";
            this.Text = "FCuentaDatos";
            this.Load += new System.EventHandler(this.FCuentaDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Label label7;
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
    }
}