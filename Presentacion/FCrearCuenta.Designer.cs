namespace Presentacion
{
    partial class FCrearCuenta
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
            this.BTAceptar = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.TBIBAN = new System.Windows.Forms.TextBox();
            this.TBSaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BTTitular = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTAceptar
            // 
            this.BTAceptar.Location = new System.Drawing.Point(510, 343);
            this.BTAceptar.Name = "BTAceptar";
            this.BTAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTAceptar.TabIndex = 19;
            this.BTAceptar.Text = "Aceptar";
            this.BTAceptar.UseVisualStyleBackColor = true;
            this.BTAceptar.Click += new System.EventHandler(this.BTAceptar_Click);
            // 
            // BTCancelar
            // 
            this.BTCancelar.Location = new System.Drawing.Point(654, 343);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTCancelar.TabIndex = 18;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // TBFecha
            // 
            this.TBFecha.Location = new System.Drawing.Point(182, 347);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.Size = new System.Drawing.Size(121, 22);
            this.TBFecha.TabIndex = 16;
            // 
            // TBIBAN
            // 
            this.TBIBAN.Location = new System.Drawing.Point(182, 62);
            this.TBIBAN.Name = "TBIBAN";
            this.TBIBAN.ReadOnly = true;
            this.TBIBAN.Size = new System.Drawing.Size(100, 22);
            this.TBIBAN.TabIndex = 15;
            // 
            // TBSaldo
            // 
            this.TBSaldo.Location = new System.Drawing.Point(186, 253);
            this.TBSaldo.Name = "TBSaldo";
            this.TBSaldo.Size = new System.Drawing.Size(100, 22);
            this.TBSaldo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "FechaApertura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "IBAN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Estado:";
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(182, 302);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(121, 24);
            this.CBEstado.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(65, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 139);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cuenta:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(0, 113);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Oro";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(0, 85);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Bonificada";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(0, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ahorro";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Joven";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BTTitular
            // 
            this.BTTitular.Location = new System.Drawing.Point(444, 66);
            this.BTTitular.Name = "BTTitular";
            this.BTTitular.Size = new System.Drawing.Size(261, 23);
            this.BTTitular.TabIndex = 25;
            this.BTTitular.Text = "Añadir titular";
            this.BTTitular.UseVisualStyleBackColor = true;
            this.BTTitular.Click += new System.EventHandler(this.BTTitular_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Location = new System.Drawing.Point(444, 108);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(261, 180);
            this.listbox.TabIndex = 26;
            // 
            // FCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.BTTitular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTAceptar);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.TBFecha);
            this.Controls.Add(this.TBIBAN);
            this.Controls.Add(this.TBSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FCrearCuenta";
            this.Text = "Saldo";
            this.Load += new System.EventHandler(this.FCrearCuenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTAceptar;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.TextBox TBIBAN;
        private System.Windows.Forms.TextBox TBSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button BTTitular;
        private System.Windows.Forms.ListBox listbox;
    }
}