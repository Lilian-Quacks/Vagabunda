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
            this.pictureEdit1.Location = new System.Drawing.Point(79, 63);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ReadOnly = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(175, 164);
            this.pictureEdit1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 49);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(48, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR SESIÓN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(-2, 434);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 50);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(23, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(23, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // TXTUsuario
            // 
            this.TXTUsuario.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.TXTUsuario.Location = new System.Drawing.Point(28, 269);
            this.TXTUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTUsuario.Name = "TXTUsuario";
            this.TXTUsuario.Size = new System.Drawing.Size(304, 32);
            this.TXTUsuario.TabIndex = 4;
            // 
            // TXTContra
            // 
            this.TXTContra.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.TXTContra.Location = new System.Drawing.Point(28, 327);
            this.TXTContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTContra.Name = "TXTContra";
            this.TXTContra.PasswordChar = '*';
            this.TXTContra.Size = new System.Drawing.Size(304, 32);
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
            this.Sesion.Location = new System.Drawing.Point(79, 398);
            this.Sesion.LookAndFeel.SkinName = "Office 2013";
            this.Sesion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Sesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sesion.Name = "Sesion";
            this.Sesion.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Sesion.Size = new System.Drawing.Size(175, 32);
            this.Sesion.TabIndex = 6;
            this.Sesion.Text = "INICIAR SESIÓN";
            this.Sesion.Click += new System.EventHandler(this.Sesion_Click);
            // 
            // LLOlvideContra
            // 
            this.LLOlvideContra.AutoSize = true;
            this.LLOlvideContra.Font = new System.Drawing.Font("Century", 7F, System.Drawing.FontStyle.Bold);
            this.LLOlvideContra.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LLOlvideContra.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.LLOlvideContra.Location = new System.Drawing.Point(174, 368);
            this.LLOlvideContra.Name = "LLOlvideContra";
            this.LLOlvideContra.Size = new System.Drawing.Size(145, 16);
            this.LLOlvideContra.TabIndex = 30;
            this.LLOlvideContra.TabStop = true;
            this.LLOlvideContra.Text = "Olvide mi contraseña";
            this.LLOlvideContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLOlvideContra_LinkClicked);
            // 
            // CBRecordar
            // 
            this.CBRecordar.AutoSize = true;
            this.CBRecordar.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold);
            this.CBRecordar.Location = new System.Drawing.Point(28, 367);
            this.CBRecordar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBRecordar.Name = "CBRecordar";
            this.CBRecordar.Size = new System.Drawing.Size(117, 21);
            this.CBRecordar.TabIndex = 9;
            this.CBRecordar.TabStop = false;
            this.CBRecordar.Text = "Recordarme";
            this.CBRecordar.UseVisualStyleBackColor = true;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(355, 482);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

