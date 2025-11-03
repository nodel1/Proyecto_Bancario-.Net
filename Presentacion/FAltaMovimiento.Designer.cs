namespace Presentacion
{
    partial class FAltaMovimiento
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
            this.ComboIBAN = new System.Windows.Forms.ComboBox();
            this.ComboDNI = new System.Windows.Forms.ComboBox();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBimporte = new System.Windows.Forms.TextBox();
            this.TBIBANdestino = new System.Windows.Forms.TextBox();
            this.TBconcepto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTAceptar = new System.Windows.Forms.Button();
            this.BTcancelar = new System.Windows.Forms.Button();
            this.LBaviso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "IBAN Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de movimiento";
            // 
            // ComboIBAN
            // 
            this.ComboIBAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboIBAN.FormattingEnabled = true;
            this.ComboIBAN.Location = new System.Drawing.Point(268, 164);
            this.ComboIBAN.Margin = new System.Windows.Forms.Padding(4);
            this.ComboIBAN.Name = "ComboIBAN";
            this.ComboIBAN.Size = new System.Drawing.Size(160, 24);
            this.ComboIBAN.TabIndex = 3;
            // 
            // ComboDNI
            // 
            this.ComboDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDNI.FormattingEnabled = true;
            this.ComboDNI.Location = new System.Drawing.Point(268, 101);
            this.ComboDNI.Margin = new System.Windows.Forms.Padding(4);
            this.ComboDNI.Name = "ComboDNI";
            this.ComboDNI.Size = new System.Drawing.Size(160, 24);
            this.ComboDNI.TabIndex = 4;
            this.ComboDNI.SelectedIndexChanged += new System.EventHandler(this.ComboDNI_SelectedIndexChanged);
            // 
            // ComboTipo
            // 
            this.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Ingreso",
            "Transferencia",
            "PagoRecibo",
            "Reintegro"});
            this.ComboTipo.Location = new System.Drawing.Point(268, 228);
            this.ComboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(160, 24);
            this.ComboTipo.TabIndex = 5;
            this.ComboTipo.SelectedIndexChanged += new System.EventHandler(this.ComboTipo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBimporte);
            this.groupBox1.Controls.Add(this.TBIBANdestino);
            this.groupBox1.Controls.Add(this.TBconcepto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(591, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // TBimporte
            // 
            this.TBimporte.Location = new System.Drawing.Point(124, 135);
            this.TBimporte.Name = "TBimporte";
            this.TBimporte.Size = new System.Drawing.Size(205, 22);
            this.TBimporte.TabIndex = 5;
            // 
            // TBIBANdestino
            // 
            this.TBIBANdestino.Location = new System.Drawing.Point(124, 93);
            this.TBIBANdestino.Name = "TBIBANdestino";
            this.TBIBANdestino.Size = new System.Drawing.Size(205, 22);
            this.TBIBANdestino.TabIndex = 4;
            // 
            // TBconcepto
            // 
            this.TBconcepto.Location = new System.Drawing.Point(124, 40);
            this.TBconcepto.Name = "TBconcepto";
            this.TBconcepto.Size = new System.Drawing.Size(205, 22);
            this.TBconcepto.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Importe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "IBAN destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Concepto:";
            // 
            // BTAceptar
            // 
            this.BTAceptar.Location = new System.Drawing.Point(591, 364);
            this.BTAceptar.Name = "BTAceptar";
            this.BTAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTAceptar.TabIndex = 7;
            this.BTAceptar.Text = "Aceptar";
            this.BTAceptar.UseVisualStyleBackColor = true;
            this.BTAceptar.Visible = false;
            this.BTAceptar.Click += new System.EventHandler(this.BTAceptar_Click);
            // 
            // BTcancelar
            // 
            this.BTcancelar.Location = new System.Drawing.Point(845, 364);
            this.BTcancelar.Name = "BTcancelar";
            this.BTcancelar.Size = new System.Drawing.Size(75, 23);
            this.BTcancelar.TabIndex = 8;
            this.BTcancelar.Text = "Cancelar";
            this.BTcancelar.UseVisualStyleBackColor = true;
            this.BTcancelar.Visible = false;
            this.BTcancelar.Click += new System.EventHandler(this.BTcancelar_Click);
            // 
            // LBaviso
            // 
            this.LBaviso.AutoSize = true;
            this.LBaviso.Location = new System.Drawing.Point(565, 66);
            this.LBaviso.Name = "LBaviso";
            this.LBaviso.Size = new System.Drawing.Size(435, 16);
            this.LBaviso.TabIndex = 9;
            this.LBaviso.Text = "Para ingreso y reintegro, no hace falta rellenar Concepto ni IBAN destino";
            this.LBaviso.Visible = false;
            // 
            // FAltaMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LBaviso);
            this.Controls.Add(this.BTcancelar);
            this.Controls.Add(this.BTAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboTipo);
            this.Controls.Add(this.ComboDNI);
            this.Controls.Add(this.ComboIBAN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FAltaMovimiento";
            this.Text = "Nuevo Movimiento";
            this.Load += new System.EventHandler(this.FAltaMovimiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboIBAN;
        private System.Windows.Forms.ComboBox ComboDNI;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBimporte;
        private System.Windows.Forms.TextBox TBIBANdestino;
        private System.Windows.Forms.TextBox TBconcepto;
        private System.Windows.Forms.Button BTAceptar;
        private System.Windows.Forms.Button BTcancelar;
        private System.Windows.Forms.Label LBaviso;
    }
}