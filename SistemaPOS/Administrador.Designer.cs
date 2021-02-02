
namespace SistemaPOS
{
    partial class Administrador
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lAdmin = new System.Windows.Forms.Label();
            this.lAdminCodigo = new System.Windows.Forms.Label();
            this.lAdminUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(474, 277);
            this.btnSalir.Size = new System.Drawing.Size(86, 44);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(58, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(85, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(88, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Adm. de usuarios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cambiar contraseña";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(359, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Cerrar Sesión";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lAdmin
            // 
            this.lAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lAdmin.Location = new System.Drawing.Point(164, 52);
            this.lAdmin.Name = "lAdmin";
            this.lAdmin.Size = new System.Drawing.Size(117, 20);
            this.lAdmin.TabIndex = 17;
            // 
            // lAdminCodigo
            // 
            this.lAdminCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lAdminCodigo.Location = new System.Drawing.Point(164, 134);
            this.lAdminCodigo.Name = "lAdminCodigo";
            this.lAdminCodigo.Size = new System.Drawing.Size(117, 20);
            this.lAdminCodigo.TabIndex = 18;
            // 
            // lAdminUser
            // 
            this.lAdminUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lAdminUser.Location = new System.Drawing.Point(164, 88);
            this.lAdminUser.Name = "lAdminUser";
            this.lAdminUser.Size = new System.Drawing.Size(117, 20);
            this.lAdminUser.TabIndex = 19;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 333);
            this.Controls.Add(this.lAdminUser);
            this.Controls.Add(this.lAdminCodigo);
            this.Controls.Add(this.lAdmin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(588, 372);
            this.MinimumSize = new System.Drawing.Size(588, 372);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrador_FormClosed);
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.lAdmin, 0);
            this.Controls.SetChildIndex(this.lAdminCodigo, 0);
            this.Controls.SetChildIndex(this.lAdminUser, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lAdmin;
        private System.Windows.Forms.Label lAdminCodigo;
        private System.Windows.Forms.Label lAdminUser;
    }
}