namespace WindowsFormsApp1.Vista
{
    partial class HabitacionDetalle
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblDetalleHabitacion = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTipoVariable = new System.Windows.Forms.Label();
            this.lblPrecioVariable = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Controls.Add(this.lblPrecioVariable);
            this.pnlPrincipal.Controls.Add(this.lblPrecio);
            this.pnlPrincipal.Controls.Add(this.lblTipoVariable);
            this.pnlPrincipal.Controls.Add(this.lblTipo);
            this.pnlPrincipal.Controls.Add(this.lblDetalleHabitacion);
            this.pnlPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(293, 218);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // lblDetalleHabitacion
            // 
            this.lblDetalleHabitacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalleHabitacion.AutoSize = true;
            this.lblDetalleHabitacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDetalleHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDetalleHabitacion.Location = new System.Drawing.Point(88, 13);
            this.lblDetalleHabitacion.Name = "lblDetalleHabitacion";
            this.lblDetalleHabitacion.Padding = new System.Windows.Forms.Padding(5);
            this.lblDetalleHabitacion.Size = new System.Drawing.Size(121, 25);
            this.lblDetalleHabitacion.TabIndex = 0;
            this.lblDetalleHabitacion.Text = "Detalle de Habitación";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(88, 64);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblTipoVariable
            // 
            this.lblTipoVariable.AutoSize = true;
            this.lblTipoVariable.Location = new System.Drawing.Point(145, 64);
            this.lblTipoVariable.Name = "lblTipoVariable";
            this.lblTipoVariable.Size = new System.Drawing.Size(35, 13);
            this.lblTipoVariable.TabIndex = 2;
            this.lblTipoVariable.Text = "label1";
            // 
            // lblPrecioVariable
            // 
            this.lblPrecioVariable.AutoSize = true;
            this.lblPrecioVariable.Location = new System.Drawing.Point(145, 105);
            this.lblPrecioVariable.Name = "lblPrecioVariable";
            this.lblPrecioVariable.Size = new System.Drawing.Size(35, 13);
            this.lblPrecioVariable.TabIndex = 4;
            this.lblPrecioVariable.Text = "label1";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(88, 105);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // HabitacionDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 242);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "HabitacionDetalle";
            this.Text = "HabitacionDetalle";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDetalleHabitacion;
        private System.Windows.Forms.Label lblTipoVariable;
        private System.Windows.Forms.Label lblPrecioVariable;
        private System.Windows.Forms.Label lblPrecio;
    }
}