
namespace SistemaPOS
{
    partial class MantenimientoProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textId_Producto = new LibreriaDLL.ErrorTxtBox();
            this.textDescripcion = new LibreriaDLL.ErrorTxtBox();
            this.textPrecio = new LibreriaDLL.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 278);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 278);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(299, 278);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 278);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(482, 332);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "PRODUCTOS";
            // 
            // textId_Producto
            // 
            this.textId_Producto.Location = new System.Drawing.Point(289, 85);
            this.textId_Producto.Name = "textId_Producto";
            this.textId_Producto.Size = new System.Drawing.Size(163, 20);
            this.textId_Producto.TabIndex = 12;
            this.textId_Producto.Validar = true;
            this.textId_Producto.ValidarNumeros = true;
            this.textId_Producto.TextChanged += new System.EventHandler(this.textId_Producto_TextChanged);
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(289, 127);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(163, 51);
            this.textDescripcion.TabIndex = 13;
            this.textDescripcion.Validar = false;
            this.textDescripcion.ValidarNumeros = false;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(289, 193);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(163, 20);
            this.textPrecio.TabIndex = 14;
            this.textPrecio.Validar = true;
            this.textPrecio.ValidarNumeros = false;
            // 
            // MantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 377);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textId_Producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoProductos";
            this.Text = "MantenimientoProductos";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textId_Producto, 0);
            this.Controls.SetChildIndex(this.textDescripcion, 0);
            this.Controls.SetChildIndex(this.textPrecio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private LibreriaDLL.ErrorTxtBox textId_Producto;
        private LibreriaDLL.ErrorTxtBox textDescripcion;
        private LibreriaDLL.ErrorTxtBox textPrecio;
    }
}