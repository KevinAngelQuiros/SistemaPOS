
namespace SistemaPOS
{
    partial class Usuario
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
            this.lCodigo = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(472, 277);
            this.btnSalir.Size = new System.Drawing.Size(88, 44);
            // 
            // lCodigo
            // 
            this.lCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lCodigo.Location = new System.Drawing.Point(164, 132);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(117, 20);
            this.lCodigo.TabIndex = 23;
            // 
            // lUser
            // 
            this.lUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lUser.Location = new System.Drawing.Point(164, 87);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(117, 20);
            this.lUser.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(320, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 44);
            this.button4.TabIndex = 20;
            this.button4.Text = "Cerrar Sesión";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 44);
            this.button3.TabIndex = 19;
            this.button3.Text = "Cambiar contraseña";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lNombre
            // 
            this.lNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lNombre.Location = new System.Drawing.Point(164, 50);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(117, 20);
            this.lNombre.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(85, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(85, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(82, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 333);
            this.Controls.Add(this.lCodigo);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(588, 372);
            this.MinimumSize = new System.Drawing.Size(588, 372);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Usuario_FormClosed);
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lNombre, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.lUser, 0);
            this.Controls.SetChildIndex(this.lCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}