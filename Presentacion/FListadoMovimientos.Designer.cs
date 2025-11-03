namespace Presentacion
{
    partial class FListadoMovimientos
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
            this.tablatransferencias = new System.Windows.Forms.DataGridView();
            this.tablareintegro = new System.Windows.Forms.DataGridView();
            this.tablaingresos = new System.Windows.Forms.DataGridView();
            this.tablarecibos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Transferencias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablatransferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablareintegro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablarecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablatransferencias
            // 
            this.tablatransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablatransferencias.Location = new System.Drawing.Point(854, 46);
            this.tablatransferencias.Name = "tablatransferencias";
            this.tablatransferencias.RowHeadersWidth = 51;
            this.tablatransferencias.RowTemplate.Height = 24;
            this.tablatransferencias.Size = new System.Drawing.Size(827, 319);
            this.tablatransferencias.TabIndex = 2;
            // 
            // tablareintegro
            // 
            this.tablareintegro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablareintegro.Location = new System.Drawing.Point(12, 414);
            this.tablareintegro.Name = "tablareintegro";
            this.tablareintegro.RowHeadersWidth = 51;
            this.tablareintegro.RowTemplate.Height = 24;
            this.tablareintegro.Size = new System.Drawing.Size(827, 319);
            this.tablareintegro.TabIndex = 3;
            // 
            // tablaingresos
            // 
            this.tablaingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaingresos.Location = new System.Drawing.Point(854, 414);
            this.tablaingresos.Name = "tablaingresos";
            this.tablaingresos.RowHeadersWidth = 51;
            this.tablaingresos.RowTemplate.Height = 24;
            this.tablaingresos.Size = new System.Drawing.Size(827, 319);
            this.tablaingresos.TabIndex = 4;
            this.tablaingresos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaingresos_CellContentClick);
            // 
            // tablarecibos
            // 
            this.tablarecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablarecibos.Location = new System.Drawing.Point(12, 46);
            this.tablarecibos.Name = "tablarecibos";
            this.tablarecibos.RowHeadersWidth = 51;
            this.tablarecibos.RowTemplate.Height = 24;
            this.tablarecibos.Size = new System.Drawing.Size(827, 319);
            this.tablarecibos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recibos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(851, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingresos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reintegros:";
            // 
            // Transferencias
            // 
            this.Transferencias.AutoSize = true;
            this.Transferencias.Location = new System.Drawing.Point(851, 27);
            this.Transferencias.Name = "Transferencias";
            this.Transferencias.Size = new System.Drawing.Size(100, 16);
            this.Transferencias.TabIndex = 9;
            this.Transferencias.Text = "Transferencias:";
            // 
            // FListadoMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 745);
            this.Controls.Add(this.Transferencias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablarecibos);
            this.Controls.Add(this.tablaingresos);
            this.Controls.Add(this.tablareintegro);
            this.Controls.Add(this.tablatransferencias);
            this.Name = "FListadoMovimientos";
            this.Text = "FListadoMovimientos";
            this.Load += new System.EventHandler(this.FListadoMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablatransferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablareintegro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablarecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tablatransferencias;
        private System.Windows.Forms.DataGridView tablareintegro;
        private System.Windows.Forms.DataGridView tablaingresos;
        private System.Windows.Forms.DataGridView tablarecibos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Transferencias;
    }
}