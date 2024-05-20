namespace pryChaconTP1
{
    partial class frmReservas
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
            this.btnQuenaken = new System.Windows.Forms.Button();
            this.btnOnas = new System.Windows.Forms.Button();
            this.btnTobas = new System.Windows.Forms.Button();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuenaken
            // 
            this.btnQuenaken.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenaken.Location = new System.Drawing.Point(75, 140);
            this.btnQuenaken.Name = "btnQuenaken";
            this.btnQuenaken.Size = new System.Drawing.Size(122, 62);
            this.btnQuenaken.TabIndex = 0;
            this.btnQuenaken.Text = "Local \r\nQuenaken";
            this.btnQuenaken.UseVisualStyleBackColor = true;
            this.btnQuenaken.Click += new System.EventHandler(this.btnQuenaken_Click);
            // 
            // btnOnas
            // 
            this.btnOnas.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnas.Location = new System.Drawing.Point(203, 140);
            this.btnOnas.Name = "btnOnas";
            this.btnOnas.Size = new System.Drawing.Size(122, 62);
            this.btnOnas.TabIndex = 1;
            this.btnOnas.Text = "Local \r\nOnas";
            this.btnOnas.UseVisualStyleBackColor = true;
            // 
            // btnTobas
            // 
            this.btnTobas.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTobas.Location = new System.Drawing.Point(331, 140);
            this.btnTobas.Name = "btnTobas";
            this.btnTobas.Size = new System.Drawing.Size(122, 62);
            this.btnTobas.TabIndex = 2;
            this.btnTobas.Text = "Local \r\nTobas";
            this.btnTobas.UseVisualStyleBackColor = true;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(26, 98);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(474, 19);
            this.lblInstruccion.TabIndex = 3;
            this.lblInstruccion.Text = "Por favor, seleccione el Local en donde desee realizar la reserva.";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(198, 59);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(127, 26);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.btnTobas);
            this.Controls.Add(this.btnOnas);
            this.Controls.Add(this.btnQuenaken);
            this.MinimizeBox = false;
            this.Name = "frmReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de reservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuenaken;
        private System.Windows.Forms.Button btnOnas;
        private System.Windows.Forms.Button btnTobas;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblBienvenido;
    }
}

