namespace Vagabunda
{
    partial class Penalizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penalizacion));
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtFechaGenerada = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(261, 64);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(863, 485);
            this.panel4.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(223, 18);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(360, 33);
            this.textBox3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(42, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "BUSQUEDA:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.NombreLibro,
            this.NumTel,
            this.Email,
            this.Column1});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(19, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(821, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdUsuario
            // 
            this.IdUsuario.FillWeight = 42.79524F;
            this.IdUsuario.HeaderText = "ID";
            this.IdUsuario.MinimumWidth = 8;
            this.IdUsuario.Name = "IdUsuario";
            // 
            // NombreLibro
            // 
            this.NombreLibro.FillWeight = 176.0267F;
            this.NombreLibro.HeaderText = "FECHA GENERADA";
            this.NombreLibro.MinimumWidth = 8;
            this.NombreLibro.Name = "NombreLibro";
            // 
            // NumTel
            // 
            this.NumTel.FillWeight = 73.70676F;
            this.NumTel.HeaderText = "MONTO";
            this.NumTel.MinimumWidth = 8;
            this.NumTel.Name = "NumTel";
            // 
            // Email
            // 
            this.Email.FillWeight = 86.33694F;
            this.Email.HeaderText = "ESTATUS";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 121.1344F;
            this.Column1.HeaderText = "ID_PRESTAMO";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-4, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 51);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(44, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "DETALLES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.pictureEdit2);
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 66);
            this.panel1.TabIndex = 14;
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
            this.pictureEdit1.Location = new System.Drawing.Point(1002, -15);
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
            this.label1.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(431, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PENALIZACION";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(207)))));
            this.panel3.Controls.Add(this.txtIdPrestamo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbEstatus);
            this.panel3.Controls.Add(this.dtFechaGenerada);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Controls.Add(this.txtMonto);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(-1, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 457);
            this.panel3.TabIndex = 16;
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtIdPrestamo.Location = new System.Drawing.Point(17, 137);
            this.txtIdPrestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(213, 33);
            this.txtIdPrestamo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "FECHA GENERADA:";
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.Location = new System.Drawing.Point(20, 267);
            this.cmbEstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Properties.Appearance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.cmbEstatus.Properties.Appearance.Options.UseFont = true;
            this.cmbEstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstatus.Size = new System.Drawing.Size(212, 32);
            this.cmbEstatus.TabIndex = 13;
            // 
            // dtFechaGenerada
            // 
            this.dtFechaGenerada.CustomFormat = "dd/MM/yyyy";
            this.dtFechaGenerada.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.dtFechaGenerada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaGenerada.Location = new System.Drawing.Point(17, 78);
            this.dtFechaGenerada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaGenerada.Name = "dtFechaGenerada";
            this.dtFechaGenerada.Size = new System.Drawing.Size(236, 33);
            this.dtFechaGenerada.TabIndex = 16;
            this.dtFechaGenerada.Value = new System.DateTime(2026, 3, 27, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(14, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "ESTATUS:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.simpleButton1.Appearance.BorderColor = System.Drawing.SystemColors.Control;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.simpleButton1.Location = new System.Drawing.Point(20, 320);
            this.simpleButton1.LookAndFeel.SkinName = "Office 2013";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(212, 38);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "GURADAR";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtMonto.Location = new System.Drawing.Point(20, 209);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(213, 33);
            this.txtMonto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID_PRESTAMO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(15, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "MONTO:";
            // 
            // Penalizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 547);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Penalizacion";
            this.Text = "Penalizacion";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstatus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEstatus;
        private System.Windows.Forms.DateTimePicker dtFechaGenerada;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.Label label3;
    }
}