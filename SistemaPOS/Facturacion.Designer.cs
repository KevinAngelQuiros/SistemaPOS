
namespace SistemaPOS
{
    partial class Facturacion
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
            this.components = new System.ComponentModel.Container();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtClientes = new System.Windows.Forms.Button();
            this.BtProductos = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtColocar = new System.Windows.Forms.Button();
            this.BtFacturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtNuevo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.TxtCantidad = new LibreriaDLL.ErrorTxtBox();
            this.TxtPrecio = new LibreriaDLL.ErrorTxtBox();
            this.TxtDescripcion = new LibreriaDLL.ErrorTxtBox();
            this.TxtCodigoProducto = new LibreriaDLL.ErrorTxtBox();
            this.TxtCliente = new LibreriaDLL.ErrorTxtBox();
            this.TxtCodigoCliente = new LibreriaDLL.ErrorTxtBox();
            this.lbVendedor = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(912, 529);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(255, 62);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtBuscar.TabIndex = 1;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtClientes
            // 
            this.BtClientes.Location = new System.Drawing.Point(487, 161);
            this.BtClientes.Name = "BtClientes";
            this.BtClientes.Size = new System.Drawing.Size(75, 23);
            this.BtClientes.TabIndex = 2;
            this.BtClientes.Text = "Clientes";
            this.BtClientes.UseVisualStyleBackColor = true;
            this.BtClientes.Click += new System.EventHandler(this.BtClientes_Click);
            // 
            // BtProductos
            // 
            this.BtProductos.Location = new System.Drawing.Point(568, 161);
            this.BtProductos.Name = "BtProductos";
            this.BtProductos.Size = new System.Drawing.Size(75, 23);
            this.BtProductos.TabIndex = 3;
            this.BtProductos.Text = "Productos";
            this.BtProductos.UseVisualStyleBackColor = true;
            this.BtProductos.Click += new System.EventHandler(this.BtProductos_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(649, 161);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtEliminar.TabIndex = 4;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtColocar
            // 
            this.BtColocar.Location = new System.Drawing.Point(730, 161);
            this.BtColocar.Name = "BtColocar";
            this.BtColocar.Size = new System.Drawing.Size(75, 23);
            this.BtColocar.TabIndex = 5;
            this.BtColocar.Text = "Colocar";
            this.BtColocar.UseVisualStyleBackColor = true;
            this.BtColocar.Click += new System.EventHandler(this.BtColocar_Click);
            // 
            // BtFacturar
            // 
            this.BtFacturar.Location = new System.Drawing.Point(811, 161);
            this.BtFacturar.Name = "BtFacturar";
            this.BtFacturar.Size = new System.Drawing.Size(75, 23);
            this.BtFacturar.TabIndex = 6;
            this.BtFacturar.Text = "Facturar";
            this.BtFacturar.UseVisualStyleBackColor = true;
            this.BtFacturar.Click += new System.EventHandler(this.BtFacturar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(749, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Importe";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripción";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(568, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Código";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Importe});
            this.dataGridView1.Location = new System.Drawing.Point(31, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(903, 194);
            this.dataGridView1.TabIndex = 22;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 180;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 180;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 180;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.Width = 180;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(487, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 143);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // BtNuevo
            // 
            this.BtNuevo.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtNuevo.Location = new System.Drawing.Point(892, 161);
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtNuevo.TabIndex = 24;
            this.BtNuevo.Text = "Nuevo";
            this.BtNuevo.UseVisualStyleBackColor = true;
            this.BtNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(526, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 42);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total:";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(653, 502);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(209, 53);
            this.lbTotal.TabIndex = 26;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(653, 210);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 28;
            this.TxtCantidad.Validar = true;
            this.TxtCantidad.ValidarNumeros = false;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(447, 210);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 29;
            this.TxtPrecio.Validar = true;
            this.TxtPrecio.ValidarNumeros = false;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(276, 210);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(100, 35);
            this.TxtDescripcion.TabIndex = 30;
            this.TxtDescripcion.Validar = true;
            this.TxtDescripcion.ValidarNumeros = false;
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Location = new System.Drawing.Point(77, 213);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoProducto.TabIndex = 31;
            this.TxtCodigoProducto.Validar = true;
            this.TxtCodigoProducto.ValidarNumeros = false;
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(91, 108);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(144, 20);
            this.TxtCliente.TabIndex = 32;
            this.TxtCliente.Validar = true;
            this.TxtCliente.ValidarNumeros = false;
            // 
            // TxtCodigoCliente
            // 
            this.TxtCodigoCliente.Location = new System.Drawing.Point(91, 64);
            this.TxtCodigoCliente.Name = "TxtCodigoCliente";
            this.TxtCodigoCliente.Size = new System.Drawing.Size(144, 20);
            this.TxtCodigoCliente.TabIndex = 33;
            this.TxtCodigoCliente.Validar = true;
            this.TxtCodigoCliente.ValidarNumeros = false;
            // 
            // lbVendedor
            // 
            this.lbVendedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbVendedor.Location = new System.Drawing.Point(90, 23);
            this.lbVendedor.Name = "lbVendedor";
            this.lbVendedor.Size = new System.Drawing.Size(145, 23);
            this.lbVendedor.TabIndex = 34;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Código:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Descipción:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Precio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(595, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Cantidad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(254, 24);
            this.label14.TabIndex = 39;
            this.label14.Text = "Ingrese datos del Artículo:";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 564);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbVendedor);
            this.Controls.Add(this.TxtCodigoCliente);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.TxtCodigoProducto);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtNuevo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtFacturar);
            this.Controls.Add(this.BtColocar);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtProductos);
            this.Controls.Add(this.BtClientes);
            this.Controls.Add(this.BtBuscar);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.BtBuscar, 0);
            this.Controls.SetChildIndex(this.BtClientes, 0);
            this.Controls.SetChildIndex(this.BtProductos, 0);
            this.Controls.SetChildIndex(this.BtEliminar, 0);
            this.Controls.SetChildIndex(this.BtColocar, 0);
            this.Controls.SetChildIndex(this.BtFacturar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.BtNuevo, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lbTotal, 0);
            this.Controls.SetChildIndex(this.TxtCantidad, 0);
            this.Controls.SetChildIndex(this.TxtPrecio, 0);
            this.Controls.SetChildIndex(this.TxtDescripcion, 0);
            this.Controls.SetChildIndex(this.TxtCodigoProducto, 0);
            this.Controls.SetChildIndex(this.TxtCliente, 0);
            this.Controls.SetChildIndex(this.TxtCodigoCliente, 0);
            this.Controls.SetChildIndex(this.lbVendedor, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtClientes;
        private System.Windows.Forms.Button BtProductos;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtColocar;
        private System.Windows.Forms.Button BtFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtNuevo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotal;
        private LibreriaDLL.ErrorTxtBox TxtCantidad;
        private LibreriaDLL.ErrorTxtBox TxtPrecio;
        private LibreriaDLL.ErrorTxtBox TxtDescripcion;
        private LibreriaDLL.ErrorTxtBox TxtCodigoProducto;
        private LibreriaDLL.ErrorTxtBox TxtCliente;
        private LibreriaDLL.ErrorTxtBox TxtCodigoCliente;
        private System.Windows.Forms.Label lbVendedor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}