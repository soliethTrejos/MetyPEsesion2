namespace Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.cmbNombres = new System.Windows.Forms.ComboBox();
            this.tbncopiar = new System.Windows.Forms.Button();
            this.cmbNombres2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(136, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // tbnombre
            // 
            this.tbnombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbnombre.Location = new System.Drawing.Point(217, 26);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(309, 26);
            this.tbnombre.TabIndex = 1;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnagregar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Image = global::Ejercicio1.Properties.Resources.agregar_usuario;
            this.btnagregar.Location = new System.Drawing.Point(541, 24);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(47, 39);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // cmbNombres
            // 
            this.cmbNombres.FormattingEnabled = true;
            this.cmbNombres.Location = new System.Drawing.Point(229, 73);
            this.cmbNombres.Name = "cmbNombres";
            this.cmbNombres.Size = new System.Drawing.Size(296, 21);
            this.cmbNombres.TabIndex = 3;
            // 
            // tbncopiar
            // 
            this.tbncopiar.Location = new System.Drawing.Point(229, 127);
            this.tbncopiar.Name = "tbncopiar";
            this.tbncopiar.Size = new System.Drawing.Size(280, 36);
            this.tbncopiar.TabIndex = 4;
            this.tbncopiar.Text = "Copiar todos los elementos";
            this.tbncopiar.UseVisualStyleBackColor = true;
            // 
            // cmbNombres2
            // 
            this.cmbNombres2.FormattingEnabled = true;
            this.cmbNombres2.Location = new System.Drawing.Point(228, 186);
            this.cmbNombres2.Name = "cmbNombres2";
            this.cmbNombres2.Size = new System.Drawing.Size(280, 21);
            this.cmbNombres2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbNombres2);
            this.Controls.Add(this.tbncopiar);
            this.Controls.Add(this.cmbNombres);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ComboBox cmbNombres;
        private System.Windows.Forms.Button tbncopiar;
        private System.Windows.Forms.ComboBox cmbNombres2;
    }
}

