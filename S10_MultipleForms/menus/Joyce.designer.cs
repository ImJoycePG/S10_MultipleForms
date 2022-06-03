namespace S10_MultipleForms
{
    partial class Joyce
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
            this.label_idProduct = new System.Windows.Forms.Label();
            this.rpta_idProduct = new System.Windows.Forms.TextBox();
            this.rpta_nameProduct = new System.Windows.Forms.TextBox();
            this.label_nameProduct = new System.Windows.Forms.Label();
            this.rpta_compra = new System.Windows.Forms.TextBox();
            this.label_stock = new System.Windows.Forms.Label();
            this.rpta_venta = new System.Windows.Forms.TextBox();
            this.label_precio = new System.Windows.Forms.Label();
            this.imagenCancelRegister = new System.Windows.Forms.PictureBox();
            this.imageRegister = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCancelRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label_idProduct
            // 
            this.label_idProduct.AutoSize = true;
            this.label_idProduct.BackColor = System.Drawing.SystemColors.Control;
            this.label_idProduct.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idProduct.ForeColor = System.Drawing.Color.Red;
            this.label_idProduct.Location = new System.Drawing.Point(27, 9);
            this.label_idProduct.Name = "label_idProduct";
            this.label_idProduct.Size = new System.Drawing.Size(158, 27);
            this.label_idProduct.TabIndex = 0;
            this.label_idProduct.Text = "Escriba una ID:";
            // 
            // rpta_idProduct
            // 
            this.rpta_idProduct.Location = new System.Drawing.Point(32, 42);
            this.rpta_idProduct.Name = "rpta_idProduct";
            this.rpta_idProduct.Size = new System.Drawing.Size(153, 20);
            this.rpta_idProduct.TabIndex = 1;
            // 
            // rpta_nameProduct
            // 
            this.rpta_nameProduct.Location = new System.Drawing.Point(240, 42);
            this.rpta_nameProduct.Name = "rpta_nameProduct";
            this.rpta_nameProduct.Size = new System.Drawing.Size(208, 20);
            this.rpta_nameProduct.TabIndex = 3;
            // 
            // label_nameProduct
            // 
            this.label_nameProduct.AutoSize = true;
            this.label_nameProduct.BackColor = System.Drawing.SystemColors.Control;
            this.label_nameProduct.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nameProduct.ForeColor = System.Drawing.Color.Red;
            this.label_nameProduct.Location = new System.Drawing.Point(235, 9);
            this.label_nameProduct.Name = "label_nameProduct";
            this.label_nameProduct.Size = new System.Drawing.Size(213, 27);
            this.label_nameProduct.TabIndex = 2;
            this.label_nameProduct.Text = "Nombre del producto:";
            // 
            // rpta_compra
            // 
            this.rpta_compra.Location = new System.Drawing.Point(240, 111);
            this.rpta_compra.Name = "rpta_compra";
            this.rpta_compra.Size = new System.Drawing.Size(195, 20);
            this.rpta_compra.TabIndex = 5;
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.BackColor = System.Drawing.SystemColors.Control;
            this.label_stock.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stock.ForeColor = System.Drawing.Color.Red;
            this.label_stock.Location = new System.Drawing.Point(235, 78);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(173, 27);
            this.label_stock.TabIndex = 4;
            this.label_stock.Text = "Costo de compra:";
            // 
            // rpta_venta
            // 
            this.rpta_venta.Location = new System.Drawing.Point(38, 111);
            this.rpta_venta.Name = "rpta_venta";
            this.rpta_venta.Size = new System.Drawing.Size(147, 20);
            this.rpta_venta.TabIndex = 7;
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.BackColor = System.Drawing.SystemColors.Control;
            this.label_precio.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_precio.ForeColor = System.Drawing.Color.Red;
            this.label_precio.Location = new System.Drawing.Point(33, 78);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(158, 27);
            this.label_precio.TabIndex = 6;
            this.label_precio.Text = "Costo de venta:";
            // 
            // imagenCancelRegister
            // 
            this.imagenCancelRegister.Image = global::S10_MultipleForms.Properties.Resources.desaprobado_img;
            this.imagenCancelRegister.ImageLocation = "";
            this.imagenCancelRegister.Location = new System.Drawing.Point(240, 179);
            this.imagenCancelRegister.Name = "imagenCancelRegister";
            this.imagenCancelRegister.Size = new System.Drawing.Size(72, 71);
            this.imagenCancelRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagenCancelRegister.TabIndex = 10;
            this.imagenCancelRegister.TabStop = false;
            this.imagenCancelRegister.Click += new System.EventHandler(this.imagenCancelRegister_Click);
            // 
            // imageRegister
            // 
            this.imageRegister.Image = global::S10_MultipleForms.Properties.Resources.RegisterComplete;
            this.imageRegister.ImageLocation = "";
            this.imageRegister.Location = new System.Drawing.Point(113, 179);
            this.imageRegister.Name = "imageRegister";
            this.imageRegister.Size = new System.Drawing.Size(72, 71);
            this.imageRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageRegister.TabIndex = 9;
            this.imageRegister.TabStop = false;
            this.imageRegister.Click += new System.EventHandler(this.imageRegister_Click);
            // 
            // Joyce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 286);
            this.Controls.Add(this.imagenCancelRegister);
            this.Controls.Add(this.imageRegister);
            this.Controls.Add(this.rpta_venta);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.rpta_compra);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.rpta_nameProduct);
            this.Controls.Add(this.label_nameProduct);
            this.Controls.Add(this.rpta_idProduct);
            this.Controls.Add(this.label_idProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Joyce";
            this.Text = "Calcular Ganancias";
            ((System.ComponentModel.ISupportInitialize)(this.imagenCancelRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_idProduct;
        private System.Windows.Forms.TextBox rpta_idProduct;
        private System.Windows.Forms.TextBox rpta_nameProduct;
        private System.Windows.Forms.Label label_nameProduct;
        private System.Windows.Forms.TextBox rpta_compra;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.TextBox rpta_venta;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.PictureBox imageRegister;
        private System.Windows.Forms.PictureBox imagenCancelRegister;
    }
}