namespace Laboratorio_11_DSIV
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickThis.Location = new System.Drawing.Point(318, 67);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(131, 37);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "ENTRAR";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblHelloWorld.Location = new System.Drawing.Point(351, 198);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(60, 23);
            this.lblHelloWorld.TabIndex = 1;
            this.lblHelloWorld.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Laboratorio_11_DSIV.Properties.Resources.DisenoEstud2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

