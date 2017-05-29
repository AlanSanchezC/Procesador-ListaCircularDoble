namespace Procesador_ListaCircular
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.txtProcedimiento = new System.Windows.Forms.TextBox();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(12, 12);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(330, 54);
            this.btnEmpezar.TabIndex = 0;
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedimiento.Location = new System.Drawing.Point(368, 12);
            this.txtProcedimiento.Multiline = true;
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcedimiento.Size = new System.Drawing.Size(447, 415);
            this.txtProcedimiento.TabIndex = 1;
            // 
            // txtReporte
            // 
            this.txtReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReporte.Location = new System.Drawing.Point(12, 72);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(330, 173);
            this.txtReporte.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 439);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.txtProcedimiento);
            this.Controls.Add(this.btnEmpezar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.TextBox txtProcedimiento;
        private System.Windows.Forms.TextBox txtReporte;
    }
}

