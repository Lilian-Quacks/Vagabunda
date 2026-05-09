namespace Vagabunda
{
    partial class Contraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contraseña));
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TXTCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.SB_Enviar = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(18, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 56);
            this.label3.TabIndex = 13;
            this.label3.Text = "INGRESE SU CORREO PARA\r\nRECUPERAR SU CONTRASEÑA:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(-4, 542);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 62);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 61);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECUPERAR CONTRASEÑA";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(135, 64);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pictureEdit3.Properties.InitialImageOptions.Image")));
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Properties.ZoomAcceleration = 1333D;
            this.pictureEdit3.Size = new System.Drawing.Size(243, 230);
            this.pictureEdit3.TabIndex = 26;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century", 7F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(132, 513);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 17);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver al inciar sesion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TXTCorreo
            // 
            this.TXTCorreo.AutoRoundedCorners = true;
            this.TXTCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTCorreo.DefaultText = "";
            this.TXTCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTCorreo.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.TXTCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TXTCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTCorreo.Location = new System.Drawing.Point(16, 382);
            this.TXTCorreo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TXTCorreo.Name = "TXTCorreo";
            this.TXTCorreo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TXTCorreo.PlaceholderText = "CORREO";
            this.TXTCorreo.SelectedText = "";
            this.TXTCorreo.Size = new System.Drawing.Size(414, 54);
            this.TXTCorreo.TabIndex = 35;
            // 
            // SB_Enviar
            // 
            this.SB_Enviar.Animated = true;
            this.SB_Enviar.AutoRoundedCorners = true;
            this.SB_Enviar.BackColor = System.Drawing.Color.Transparent;
            this.SB_Enviar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SB_Enviar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SB_Enviar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SB_Enviar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SB_Enviar.FillColor = System.Drawing.Color.SteelBlue;
            this.SB_Enviar.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.SB_Enviar.ForeColor = System.Drawing.Color.White;
            this.SB_Enviar.Location = new System.Drawing.Point(96, 455);
            this.SB_Enviar.Name = "SB_Enviar";
            this.SB_Enviar.Size = new System.Drawing.Size(242, 48);
            this.SB_Enviar.TabIndex = 40;
            this.SB_Enviar.Text = "ENVIAR";
            this.SB_Enviar.Click += new System.EventHandler(this.SB_Enviar_Click);
            // 
            // Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(452, 602);
            this.Controls.Add(this.SB_Enviar);
            this.Controls.Add(this.TXTCorreo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Contraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contraseña";
            this.Load += new System.EventHandler(this.Contraseña_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TXTCorreo;
        private Guna.UI2.WinForms.Guna2Button SB_Enviar;
    }
}