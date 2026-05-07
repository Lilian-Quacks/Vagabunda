using System.Drawing;

namespace Vagabunda
{
    partial class Bajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bajas));
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvBajas = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbeMotivo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeMotivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Controls.Add(this.txtBusqueda);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.dgvBajas);
            this.panel4.Location = new System.Drawing.Point(261, 64);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(863, 485);
            this.panel4.TabIndex = 13;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtBusqueda.Location = new System.Drawing.Point(223, 18);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(416, 32);
            this.txtBusqueda.TabIndex = 12;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(43, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "BUSQUEDA:";
            // 
            // dgvBajas
            // 
            this.dgvBajas.AllowUserToAddRows = false;
            this.dgvBajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBajas.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvBajas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBajas.ColumnHeadersHeight = 53;
            this.dgvBajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.NombreLibro,
            this.NumTel,
            this.Email});
            this.dgvBajas.EnableHeadersVisualStyles = false;
            this.dgvBajas.Location = new System.Drawing.Point(19, 62);
            this.dgvBajas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBajas.Name = "dgvBajas";
            this.dgvBajas.RowHeadersVisible = false;
            this.dgvBajas.RowHeadersWidth = 62;
            this.dgvBajas.RowTemplate.Height = 28;
            this.dgvBajas.Size = new System.Drawing.Size(821, 406);
            this.dgvBajas.TabIndex = 0;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "ID";
            this.IdUsuario.MinimumWidth = 8;
            this.IdUsuario.Name = "IdUsuario";
            // 
            // NombreLibro
            // 
            this.NombreLibro.HeaderText = "LIBRO";
            this.NombreLibro.MinimumWidth = 8;
            this.NombreLibro.Name = "NombreLibro";
            // 
            // NumTel
            // 
            this.NumTel.HeaderText = "MOTIVO";
            this.NumTel.MinimumWidth = 8;
            this.NumTel.Name = "NumTel";
            // 
            // Email
            // 
            this.Email.HeaderText = "FECHA";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-4, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 50);
            this.panel2.TabIndex = 11;
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
            this.panel1.Size = new System.Drawing.Size(1128, 66);
            this.panel1.TabIndex = 10;
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
            this.pictureEdit2.Size = new System.Drawing.Size(125, 98);
            this.pictureEdit2.TabIndex = 14;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(1003, -15);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImageOptions.Image")));
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAcceleration = 1333D;
            this.pictureEdit1.Size = new System.Drawing.Size(125, 98);
            this.pictureEdit1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(520, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAJAS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.cbeMotivo);
            this.panel3.Controls.Add(this.dtpFecha);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.txtLibro);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(-1, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 457);
            this.panel3.TabIndex = 12;
            // 
            // cbeMotivo
            // 
            this.cbeMotivo.Location = new System.Drawing.Point(19, 140);
            this.cbeMotivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbeMotivo.Name = "cbeMotivo";
            this.cbeMotivo.Properties.Appearance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.cbeMotivo.Properties.Appearance.Options.UseFont = true;
            this.cbeMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeMotivo.Size = new System.Drawing.Size(212, 30);
            this.cbeMotivo.TabIndex = 13;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(19, 204);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(213, 32);
            this.dtpFecha.TabIndex = 16;
            this.dtpFecha.Value = new System.DateTime(2026, 3, 27, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "MOTIVO:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnEliminar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.btnEliminar.Appearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Appearance.Options.UseBackColor = true;
            this.btnEliminar.Appearance.Options.UseBorderColor = true;
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.Appearance.Options.UseForeColor = true;
            this.btnEliminar.Appearance.Options.UseTextOptions = true;
            this.btnEliminar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.btnEliminar.Location = new System.Drawing.Point(17, 270);
            this.btnEliminar.LookAndFeel.SkinName = "Stardust";
            this.btnEliminar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(212, 38);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtLibro
            // 
            this.txtLibro.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtLibro.Location = new System.Drawing.Point(19, 81);
            this.txtLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(213, 32);
            this.txtLibro.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(13, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "FECHA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(13, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "LIBRO:";
            // 
            // Bajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 546);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bajas";
            this.Text = "Bajas";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeMotivo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvBajas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private DevExpress.XtraEditors.ComboBoxEdit cbeMotivo;
    }
}