using System.Drawing;

namespace Vagabunda
{
    partial class GestionDeUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeUsuarios));
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAdeudo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAdeudo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Controls.Add(this.txtBusqueda);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.dgvUsuarios);
            this.panel4.Location = new System.Drawing.Point(261, 64);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 485);
            this.panel4.TabIndex = 9;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtBusqueda.Location = new System.Drawing.Point(223, 18);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(415, 32);
            this.txtBusqueda.TabIndex = 12;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(42, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "BUSQUEDA:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeight = 56;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.NombreUsuario,
            this.NumTel,
            this.Email,
            this.Adeudo,
            this.Column1});
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(19, 62);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(958, 410);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "ID";
            this.IdUsuario.MinimumWidth = 8;
            this.IdUsuario.Name = "IdUsuario";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "NOMBRE";
            this.NombreUsuario.MinimumWidth = 8;
            this.NombreUsuario.Name = "NombreUsuario";
            // 
            // NumTel
            // 
            this.NumTel.HeaderText = "TELEFONO";
            this.NumTel.MinimumWidth = 8;
            this.NumTel.Name = "NumTel";
            // 
            // Email
            // 
            this.Email.HeaderText = "CORREO";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // Adeudo
            // 
            this.Adeudo.HeaderText = "ADEUDO";
            this.Adeudo.MinimumWidth = 8;
            this.Adeudo.Name = "Adeudo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PRESTAMOS ACTIVO";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-4, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 51);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(44, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "DETALLES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureEdit2);
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 66);
            this.panel1.TabIndex = 6;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(12, -15);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pictureEdit2.Properties.InitialImageOptions.Image")));
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Properties.ZoomAcceleration = 1333D;
            this.pictureEdit2.Size = new System.Drawing.Size(126, 98);
            this.pictureEdit2.TabIndex = 14;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(1120, -15);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImageOptions.Image")));
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAcceleration = 1333D;
            this.pictureEdit1.Size = new System.Drawing.Size(126, 98);
            this.pictureEdit1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(516, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIOS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.txtCorreo);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cmbAdeudo);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(-1, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 457);
            this.panel3.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Century", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Appearance.Options.UseForeColor = true;
            this.btnGuardar.Location = new System.Drawing.Point(14, 320);
            this.btnGuardar.LookAndFeel.SkinName = "Stardust";
            this.btnGuardar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(216, 59);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.Location = new System.Drawing.Point(16, 194);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(213, 32);
            this.txtCorreo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(11, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "CORREO:";
            // 
            // cmbAdeudo
            // 
            this.cmbAdeudo.Location = new System.Drawing.Point(17, 258);
            this.cmbAdeudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAdeudo.Name = "cmbAdeudo";
            this.cmbAdeudo.Properties.Appearance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.cmbAdeudo.Properties.Appearance.Options.UseFont = true;
            this.cmbAdeudo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAdeudo.Size = new System.Drawing.Size(212, 30);
            this.cmbAdeudo.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.Location = new System.Drawing.Point(17, 136);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(213, 32);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(17, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 32);
            this.txtNombre.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "ADEUDO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "TELEFONO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOMBRE:";
            // 
            // GestionDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1254, 547);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionDeUsuarios";
            this.Text = "GestionDeUsuarios";
            this.Load += new System.EventHandler(this.GestionDeUsuarios_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAdeudo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAdeudo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adeudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
    }
}