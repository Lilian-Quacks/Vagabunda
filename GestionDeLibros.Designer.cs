using System.Drawing;
using System.Windows.Forms;

namespace Vagabunda
{
    partial class GestionDeLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeLibros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAutor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEditorial = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbeEstadoFisico = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpFechaPublicacion = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.txtBusquedaDeLibros = new Guna.UI2.WinForms.Guna2TextBox();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureEdit2);
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1656, 82);
            this.panel1.TabIndex = 2;
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
            this.pictureEdit2.Size = new System.Drawing.Size(142, 122);
            this.pictureEdit2.TabIndex = 14;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(1511, -19);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImageOptions.Image")));
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAcceleration = 1333D;
            this.pictureEdit1.Size = new System.Drawing.Size(142, 122);
            this.pictureEdit1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(709, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(56, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "DETALLES";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoRoundedCorners = true;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.Location = new System.Drawing.Point(10, 163);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCodigo.PlaceholderText = "CODIGO";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(291, 54);
            this.txtCodigo.TabIndex = 24;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoRoundedCorners = true;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.DefaultText = "";
            this.txtTitulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTitulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.Location = new System.Drawing.Point(10, 229);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTitulo.PlaceholderText = "TITULO";
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.Size = new System.Drawing.Size(291, 54);
            this.txtTitulo.TabIndex = 25;
            // 
            // txtAutor
            // 
            this.txtAutor.AutoRoundedCorners = true;
            this.txtAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAutor.DefaultText = "";
            this.txtAutor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAutor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAutor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAutor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAutor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAutor.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.txtAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAutor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAutor.Location = new System.Drawing.Point(10, 290);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtAutor.PlaceholderText = "AUTOR";
            this.txtAutor.SelectedText = "";
            this.txtAutor.Size = new System.Drawing.Size(291, 54);
            this.txtAutor.TabIndex = 26;
            // 
            // txtEditorial
            // 
            this.txtEditorial.AutoRoundedCorners = true;
            this.txtEditorial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditorial.DefaultText = "";
            this.txtEditorial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEditorial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEditorial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditorial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditorial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEditorial.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.txtEditorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtEditorial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEditorial.Location = new System.Drawing.Point(10, 356);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtEditorial.PlaceholderText = "EDITORIAL";
            this.txtEditorial.SelectedText = "";
            this.txtEditorial.Size = new System.Drawing.Size(291, 54);
            this.txtEditorial.TabIndex = 27;
            // 
            // cbeEstadoFisico
            // 
            this.cbeEstadoFisico.AutoRoundedCorners = true;
            this.cbeEstadoFisico.BackColor = System.Drawing.Color.Transparent;
            this.cbeEstadoFisico.BorderColor = System.Drawing.Color.Gainsboro;
            this.cbeEstadoFisico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbeEstadoFisico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbeEstadoFisico.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbeEstadoFisico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbeEstadoFisico.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.cbeEstadoFisico.ForeColor = System.Drawing.Color.Black;
            this.cbeEstadoFisico.ItemHeight = 30;
            this.cbeEstadoFisico.Location = new System.Drawing.Point(16, 439);
            this.cbeEstadoFisico.Name = "cbeEstadoFisico";
            this.cbeEstadoFisico.Size = new System.Drawing.Size(285, 36);
            this.cbeEstadoFisico.TabIndex = 28;
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.AutoRoundedCorners = true;
            this.dtpFechaPublicacion.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaPublicacion.BorderColor = System.Drawing.Color.Transparent;
            this.dtpFechaPublicacion.Checked = true;
            this.dtpFechaPublicacion.FillColor = System.Drawing.Color.White;
            this.dtpFechaPublicacion.FocusedColor = System.Drawing.Color.White;
            this.dtpFechaPublicacion.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(16, 522);
            this.dtpFechaPublicacion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaPublicacion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(285, 43);
            this.dtpFechaPublicacion.TabIndex = 29;
            this.dtpFechaPublicacion.Value = new System.DateTime(2026, 5, 7, 9, 57, 53, 274);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dgvLibros);
            this.panel4.Location = new System.Drawing.Point(333, 163);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1276, 480);
            this.panel4.TabIndex = 30;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLibro,
            this.CODIGO,
            this.Direccion,
            this.Autor,
            this.Editorial,
            this.EstFisico,
            this.FechaPublicacion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLibros.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibros.EnableHeadersVisualStyles = false;
            this.dgvLibros.Location = new System.Drawing.Point(0, 0);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.RowHeadersWidth = 62;
            this.dgvLibros.RowTemplate.Height = 28;
            this.dgvLibros.Size = new System.Drawing.Size(1272, 476);
            this.dgvLibros.TabIndex = 0;
            // 
            // txtBusquedaDeLibros
            // 
            this.txtBusquedaDeLibros.AutoRoundedCorners = true;
            this.txtBusquedaDeLibros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaDeLibros.DefaultText = "";
            this.txtBusquedaDeLibros.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusquedaDeLibros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusquedaDeLibros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaDeLibros.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaDeLibros.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaDeLibros.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.txtBusquedaDeLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBusquedaDeLibros.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaDeLibros.Location = new System.Drawing.Point(560, 104);
            this.txtBusquedaDeLibros.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtBusquedaDeLibros.Name = "txtBusquedaDeLibros";
            this.txtBusquedaDeLibros.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBusquedaDeLibros.PlaceholderText = "BUSQUEDA";
            this.txtBusquedaDeLibros.SelectedText = "";
            this.txtBusquedaDeLibros.Size = new System.Drawing.Size(790, 51);
            this.txtBusquedaDeLibros.TabIndex = 30;
            // 
            // IdLibro
            // 
            this.IdLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdLibro.HeaderText = "ID";
            this.IdLibro.MinimumWidth = 8;
            this.IdLibro.Name = "IdLibro";
            this.IdLibro.Width = 79;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.MinimumWidth = 8;
            this.CODIGO.Name = "CODIGO";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "TITULO";
            this.Direccion.MinimumWidth = 8;
            this.Direccion.Name = "Direccion";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "AUTOR";
            this.Autor.MinimumWidth = 8;
            this.Autor.Name = "Autor";
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "EDITORIAL";
            this.Editorial.MinimumWidth = 8;
            this.Editorial.Name = "Editorial";
            // 
            // EstFisico
            // 
            this.EstFisico.HeaderText = "ESTADO FISICO";
            this.EstFisico.MinimumWidth = 8;
            this.EstFisico.Name = "EstFisico";
            // 
            // FechaPublicacion
            // 
            this.FechaPublicacion.HeaderText = "FECHA PUBLICACION";
            this.FechaPublicacion.MinimumWidth = 8;
            this.FechaPublicacion.Name = "FechaPublicacion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoRoundedCorners = true;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(33, 586);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(242, 46);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(12, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "ESTADO FISICO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(12, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "FECHA PUBLICACION";
            // 
            // GestionDeLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1646, 684);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBusquedaDeLibros);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dtpFechaPublicacion);
            this.Controls.Add(this.cbeEstadoFisico);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionDeLibros";
            this.Text = "GestionDeLibros";
            this.Load += new System.EventHandler(this.GestionDeLibros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtAutor;
        private Guna.UI2.WinForms.Guna2TextBox txtEditorial;
        private Guna.UI2.WinForms.Guna2ComboBox cbeEstadoFisico;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaPublicacion;
        private Panel panel4;
        private DataGridView dgvLibros;
        private DataGridViewTextBoxColumn IdLibro;
        private DataGridViewTextBoxColumn CODIGO;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Editorial;
        private DataGridViewTextBoxColumn EstFisico;
        private DataGridViewTextBoxColumn FechaPublicacion;
        private Guna.UI2.WinForms.Guna2TextBox txtBusquedaDeLibros;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Label label3;
        private Label label4;
    }
}