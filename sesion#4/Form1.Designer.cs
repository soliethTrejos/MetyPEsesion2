namespace sesion_4
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
            this.Salario = new System.Windows.Forms.Label();
            this.TbSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbTecho = new System.Windows.Forms.TextBox();
            this.Nud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Nud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Salario
            // 
            this.Salario.AutoSize = true;
            this.Salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salario.Location = new System.Drawing.Point(26, 35);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(67, 24);
            this.Salario.TabIndex = 3;
            this.Salario.Text = "Salario";
            this.Salario.Click += new System.EventHandler(this.TbSalario_Click);
            // 
            // TbSalario
            // 
            this.TbSalario.Location = new System.Drawing.Point(129, 40);
            this.TbSalario.Name = "TbSalario";
            this.TbSalario.Size = new System.Drawing.Size(233, 20);
            this.TbSalario.TabIndex = 4;
            this.TbSalario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aumento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Techo";
            // 
            // TbTecho
            // 
            this.TbTecho.Location = new System.Drawing.Point(174, 144);
            this.TbTecho.Name = "TbTecho";
            this.TbTecho.Size = new System.Drawing.Size(183, 20);
            this.TbTecho.TabIndex = 8;
            // 
            // Nud
            // 
            this.Nud.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nud.Location = new System.Drawing.Point(148, 85);
            this.Nud.Name = "Nud";
            this.Nud.Size = new System.Drawing.Size(209, 20);
            this.Nud.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nud);
            this.Controls.Add(this.TbTecho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbSalario);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Salario;
        private System.Windows.Forms.TextBox TbSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbTecho;
        private System.Windows.Forms.NumericUpDown Nud;
    }
}

