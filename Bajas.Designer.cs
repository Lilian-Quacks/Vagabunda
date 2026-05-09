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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bajas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FE = new System.Windows.Forms.Label();
            this.cbeMotivo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvBajas = new System.Windows.Forms.DataGridView();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(63, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 38);
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
            this.panel1.Size = new System.Drawing.Size(1269, 82);
            this.panel1.TabIndex = 10;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(14, -19);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pictureEdit2.Properties.InitialImageOptions.Image")));
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Properties.ZoomAcceleration = 1333D;
            this.pictureEdit2.Size = new System.Drawing.Size(141, 122);
            this.pictureEdit2.TabIndex = 14;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(1128, -19);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImageOptions.Image")));
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAcceleration = 1333D;
            this.pictureEdit1.Size = new System.Drawing.Size(141, 122);
            this.pictureEdit1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(585, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAJAS";
            // 
            // txtLibro
            // 
            this.txtLibro.AutoRoundedCorners = true;
            this.txtLibro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLibro.DefaultText = "";
            this.txtLibro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLibro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLibro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLibro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLibro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLibro.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.txtLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtLibro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLibro.Location = new System.Drawing.Point(27, 234);
            this.txtLibro.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtLibro.PlaceholderText = "LIBRO";
            this.txtLibro.SelectedText = "";
            this.txtLibro.Size = new System.Drawing.Size(285, 47);
            this.txtLibro.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(23, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "FECHA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.AutoRoundedCorners = true;
            this.dtpFecha.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha.BorderColor = System.Drawing.Color.Transparent;
            this.dtpFecha.Checked = true;
            this.dtpFecha.FillColor = System.Drawing.Color.White;
            this.dtpFecha.FocusedColor = System.Drawing.Color.White;
            this.dtpFecha.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(27, 420);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(285, 43);
            this.dtpFecha.TabIndex = 47;
            this.dtpFecha.Value = new System.DateTime(2026, 5, 7, 9, 57, 53, 274);
            // 
            // FE
            // 
            this.FE.AutoSize = true;
            this.FE.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.FE.ForeColor = System.Drawing.Color.DarkCyan;
            this.FE.Location = new System.Drawing.Point(23, 307);
            this.FE.Name = "FE";
            this.FE.Size = new System.Drawing.Size(93, 22);
            this.FE.TabIndex = 49;
            this.FE.Text = "MOTIVO";
            // 
            // cbeMotivo
            // 
            this.cbeMotivo.AutoRoundedCorners = true;
            this.cbeMotivo.BackColor = System.Drawing.Color.Transparent;
            this.cbeMotivo.BorderColor = System.Drawing.Color.Gainsboro;
            this.cbeMotivo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbeMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbeMotivo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbeMotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbeMotivo.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.cbeMotivo.ForeColor = System.Drawing.Color.Black;
            this.cbeMotivo.ItemHeight = 30;
            this.cbeMotivo.Location = new System.Drawing.Point(27, 332);
            this.cbeMotivo.Name = "cbeMotivo";
            this.cbeMotivo.Size = new System.Drawing.Size(285, 36);
            this.cbeMotivo.TabIndex = 48;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Animated = true;
            this.btnEliminar.AutoRoundedCorners = true;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(40, 510);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(225, 49);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.AutoRoundedCorners = true;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.DefaultText = "";
            this.txtBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.Location = new System.Drawing.Point(366, 110);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBusqueda.PlaceholderText = "BUSQUEDA";
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.Size = new System.Drawing.Size(740, 42);
            this.txtBusqueda.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dgvBajas);
            this.panel4.Location = new System.Drawing.Point(332, 176);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(917, 480);
            this.panel4.TabIndex = 55;
            // 
            // dgvBajas
            // 
            this.dgvBajas.AllowUserToAddRows = false;
            this.dgvBajas.AllowUserToDeleteRows = false;
            this.dgvBajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBajas.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvBajas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLibro,
            this.Usuario,
            this.Libros,
            this.FechSal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBajas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBajas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBajas.EnableHeadersVisualStyles = false;
            this.dgvBajas.Location = new System.Drawing.Point(0, 0);
            this.dgvBajas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBajas.Name = "dgvBajas";
            this.dgvBajas.RowHeadersVisible = false;
            this.dgvBajas.RowHeadersWidth = 62;
            this.dgvBajas.RowTemplate.Height = 28;
            this.dgvBajas.Size = new System.Drawing.Size(913, 476);
            this.dgvBajas.TabIndex = 0;
            // 
            // IdLibro
            // 
            this.IdLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdLibro.HeaderText = "ID";
            this.IdLibro.MinimumWidth = 8;
            this.IdLibro.Name = "IdLibro";
            this.IdLibro.Width = 79;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "LIBRO";
            this.Usuario.MinimumWidth = 8;
            this.Usuario.Name = "Usuario";
            // 
            // Libros
            // 
            this.Libros.HeaderText = "MOTIVO";
            this.Libros.MinimumWidth = 8;
            this.Libros.Name = "Libros";
            // 
            // FechSal
            // 
            this.FechSal.HeaderText = "FECHA ";
            this.FechSal.MinimumWidth = 8;
            this.FechSal.Name = "FechSal";
            // 
            // Bajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1261, 682);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.FE);
            this.Controls.Add(this.cbeMotivo);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bajas";
            this.Text = "Bajas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtLibro;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFecha;
        private System.Windows.Forms.Label FE;
        private Guna.UI2.WinForms.Guna2ComboBox cbeMotivo;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2TextBox txtBusqueda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvBajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libros;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechSal;
    }
}