namespace S10_MultipleForms
{
    partial class Dicarlo
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
            this.chkMesa = new System.Windows.Forms.CheckBox();
            this.chkMueble = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtmesa = new System.Windows.Forms.TextBox();
            this.txtmueble = new System.Windows.Forms.TextBox();
            this.txtlaptop = new System.Windows.Forms.TextBox();
            this.txtcocina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkRepisa = new System.Windows.Forms.CheckBox();
            this.txtRepisa = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkMesa
            // 
            this.chkMesa.AutoSize = true;
            this.chkMesa.Location = new System.Drawing.Point(88, 130);
            this.chkMesa.Margin = new System.Windows.Forms.Padding(2);
            this.chkMesa.Name = "chkMesa";
            this.chkMesa.Size = new System.Drawing.Size(52, 17);
            this.chkMesa.TabIndex = 23;
            this.chkMesa.Text = "Mesa";
            this.chkMesa.UseVisualStyleBackColor = true;
            this.chkMesa.CheckedChanged += new System.EventHandler(this.chkMesa_CheckedChanged);
            // 
            // chkMueble
            // 
            this.chkMueble.AutoSize = true;
            this.chkMueble.Location = new System.Drawing.Point(88, 98);
            this.chkMueble.Margin = new System.Windows.Forms.Padding(2);
            this.chkMueble.Name = "chkMueble";
            this.chkMueble.Size = new System.Drawing.Size(60, 17);
            this.chkMueble.TabIndex = 22;
            this.chkMueble.Text = "mueble";
            this.chkMueble.UseVisualStyleBackColor = true;
            this.chkMueble.CheckedChanged += new System.EventHandler(this.chkMueble_CheckedChanged);
            // 
            // chkLaptop
            // 
            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Location = new System.Drawing.Point(88, 67);
            this.chkLaptop.Margin = new System.Windows.Forms.Padding(2);
            this.chkLaptop.Name = "chkLaptop";
            this.chkLaptop.Size = new System.Drawing.Size(59, 17);
            this.chkLaptop.TabIndex = 21;
            this.chkLaptop.Text = "Laptop";
            this.chkLaptop.UseVisualStyleBackColor = true;
            this.chkLaptop.CheckedChanged += new System.EventHandler(this.chkLaptop_CheckedChanged);
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(88, 40);
            this.chkCocina.Margin = new System.Windows.Forms.Padding(2);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 20;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            this.chkCocina.CheckedChanged += new System.EventHandler(this.chkCocina_CheckedChanged);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(268, 307);
            this.txttotal.Margin = new System.Windows.Forms.Padding(2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(76, 20);
            this.txttotal.TabIndex = 19;
            // 
            // txtmesa
            // 
            this.txtmesa.Location = new System.Drawing.Point(276, 130);
            this.txtmesa.Margin = new System.Windows.Forms.Padding(2);
            this.txtmesa.Name = "txtmesa";
            this.txtmesa.Size = new System.Drawing.Size(76, 20);
            this.txtmesa.TabIndex = 18;
            this.txtmesa.Text = "0";
            // 
            // txtmueble
            // 
            this.txtmueble.Location = new System.Drawing.Point(276, 97);
            this.txtmueble.Margin = new System.Windows.Forms.Padding(2);
            this.txtmueble.Name = "txtmueble";
            this.txtmueble.Size = new System.Drawing.Size(76, 20);
            this.txtmueble.TabIndex = 17;
            this.txtmueble.Text = "0";
            // 
            // txtlaptop
            // 
            this.txtlaptop.Location = new System.Drawing.Point(276, 66);
            this.txtlaptop.Margin = new System.Windows.Forms.Padding(2);
            this.txtlaptop.Name = "txtlaptop";
            this.txtlaptop.Size = new System.Drawing.Size(76, 20);
            this.txtlaptop.TabIndex = 16;
            this.txtlaptop.Text = "0";
            // 
            // txtcocina
            // 
            this.txtcocina.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtcocina.Location = new System.Drawing.Point(276, 38);
            this.txtcocina.Margin = new System.Windows.Forms.Padding(2);
            this.txtcocina.Name = "txtcocina";
            this.txtcocina.Size = new System.Drawing.Size(76, 20);
            this.txtcocina.TabIndex = 15;
            this.txtcocina.Text = "0";
            this.txtcocina.TextChanged += new System.EventHandler(this.txtcocina_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total";
            // 
            // chkRepisa
            // 
            this.chkRepisa.AutoSize = true;
            this.chkRepisa.Location = new System.Drawing.Point(88, 164);
            this.chkRepisa.Margin = new System.Windows.Forms.Padding(2);
            this.chkRepisa.Name = "chkRepisa";
            this.chkRepisa.Size = new System.Drawing.Size(59, 17);
            this.chkRepisa.TabIndex = 25;
            this.chkRepisa.Text = "Repisa";
            this.chkRepisa.UseVisualStyleBackColor = true;
            this.chkRepisa.CheckedChanged += new System.EventHandler(this.chkRepisa_CheckedChanged);
            // 
            // txtRepisa
            // 
            this.txtRepisa.Location = new System.Drawing.Point(276, 164);
            this.txtRepisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtRepisa.Name = "txtRepisa";
            this.txtRepisa.Size = new System.Drawing.Size(76, 20);
            this.txtRepisa.TabIndex = 24;
            this.txtRepisa.Text = "0";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(422, 305);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(56, 19);
            this.btnComprar.TabIndex = 26;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(348, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "                  \r\n 1 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Dicarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.chkRepisa);
            this.Controls.Add(this.txtRepisa);
            this.Controls.Add(this.chkMesa);
            this.Controls.Add(this.chkMueble);
            this.Controls.Add(this.chkLaptop);
            this.Controls.Add(this.chkCocina);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtmesa);
            this.Controls.Add(this.txtmueble);
            this.Controls.Add(this.txtlaptop);
            this.Controls.Add(this.txtcocina);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dicarlo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMesa;
        private System.Windows.Forms.CheckBox chkMueble;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtmesa;
        private System.Windows.Forms.TextBox txtmueble;
        private System.Windows.Forms.TextBox txtlaptop;
        private System.Windows.Forms.TextBox txtcocina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkRepisa;
        private System.Windows.Forms.TextBox txtRepisa;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label1;
    }
}