namespace Vagabunda
{
    partial class IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTUsuario = new System.Windows.Forms.TextBox();
            this.TXTContra = new System.Windows.Forms.TextBox();
            this.Sesion = new DevExpress.XtraEditors.SimpleButton();
            this.LLOlvideContra = new System.Windows.Forms.LinkLabel();
            this.CBRecordar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(89, 73);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(197, 205);
            this.pictureEdit1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 61);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(54, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR SESION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(186)))));
            this.panel2.Location = new System.Drawing.Point(-2, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 62);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(26, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(26, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // TXTUsuario
            // 
            this.TXTUsuario.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.TXTUsuario.Location = new System.Drawing.Point(32, 336);
            this.TXTUsuario.Name = "TXTUsuario";
            this.TXTUsuario.Size = new System.Drawing.Size(341, 36);
            this.TXTUsuario.TabIndex = 4;
            // 
            // TXTContra
            // 
            this.TXTContra.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.TXTContra.Location = new System.Drawing.Point(32, 409);
            this.TXTContra.Name = "TXTContra";
            this.TXTContra.PasswordChar = '*';
            this.TXTContra.Size = new System.Drawing.Size(341, 36);
            this.TXTContra.TabIndex = 5;
            this.TXTContra.UseSystemPasswordChar = true;
            // 
            // Sesion
            // 
            this.Sesion.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(162)))));
            this.Sesion.Appearance.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.Sesion.Appearance.Options.UseBackColor = true;
            this.Sesion.Appearance.Options.UseBorderColor = true;
            this.Sesion.Appearance.Options.UseFont = true;
            this.Sesion.Appearance.Options.UseForeColor = true;
            this.Sesion.Appearance.Options.UseTextOptions = true;
            this.Sesion.Location = new System.Drawing.Point(100, 497);
            this.Sesion.LookAndFeel.SkinName = "Office 2013";
            this.Sesion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Sesion.Name = "Sesion";
            this.Sesion.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Sesion.Size = new System.Drawing.Size(202, 40);
            this.Sesion.TabIndex = 6;
            this.Sesion.Text = "INICIAR SESION";
            this.Sesion.Click += new System.EventHandler(this.Sesion_Click);
            // 
            // LLOlvideContra
            // 
            this.LLOlvideContra.AutoSize = true;
            this.LLOlvideContra.Font = new System.Drawing.Font("Century", 7F, System.Drawing.FontStyle.Bold);
            this.LLOlvideContra.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LLOlvideContra.LinkColor = System.Drawing.Color.Black;
            this.LLOlvideContra.Location = new System.Drawing.Point(188, 459);
            this.LLOlvideContra.Name = "LLOlvideContra";
            this.LLOlvideContra.Size = new System.Drawing.Size(165, 17);
            this.LLOlvideContra.TabIndex = 30;
            this.LLOlvideContra.Text = "Olvide mi contraseña";
            this.LLOlvideContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLOlvideContra_LinkClicked);
            // 
            // CBRecordar
            // 
            this.CBRecordar.AutoSize = true;
            this.CBRecordar.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold);
            this.CBRecordar.Location = new System.Drawing.Point(32, 459);
            this.CBRecordar.Name = "CBRecordar";
            this.CBRecordar.Size = new System.Drawing.Size(134, 24);
            this.CBRecordar.TabIndex = 9;
            this.CBRecordar.TabStop = false;
            this.CBRecordar.Text = "Recordarme";
            this.CBRecordar.UseVisualStyleBackColor = true;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(393, 603);
            this.Controls.Add(this.CBRecordar);
            this.Controls.Add(this.LLOlvideContra);
            this.Controls.Add(this.Sesion);
            this.Controls.Add(this.TXTContra);
            this.Controls.Add(this.TXTUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inciar Sesion";
            this.Load += new System.EventHandler(this.IniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTUsuario;
        private System.Windows.Forms.TextBox TXTContra;
        private DevExpress.XtraEditors.SimpleButton Sesion;
        private System.Windows.Forms.LinkLabel LLOlvideContra;
        private System.Windows.Forms.CheckBox CBRecordar;
    }
}

