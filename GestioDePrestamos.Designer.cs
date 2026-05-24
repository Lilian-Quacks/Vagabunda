using System.Drawing;

namespace Vagabunda
{
    partial class GestioDePrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestioDePrestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelq = new System.Windows.Forms.Label();
            this.CS = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbeEstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpFechaLimite = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(78, 94);
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
            this.panel1.Size = new System.Drawing.Size(1420, 66);
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
            this.pictureEdit1.Location = new System.Drawing.Point(1279, -15);
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
            this.label1.Location = new System.Drawing.Point(620, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRESTAMOS";
            // 
            // labelq
            // 
            this.labelq.AutoSize = true;
            this.labelq.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.labelq.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelq.Location = new System.Drawing.Point(41, 242);
            this.labelq.Name = "labelq";
            this.labelq.Size = new System.Drawing.Size(200, 18);
            this.labelq.TabIndex = 41;
            this.labelq.Text = "FECHA DE PRESTAMO";
            // 
            // CS
            // 
            this.CS.AutoSize = true;
            this.CS.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.CS.ForeColor = System.Drawing.Color.DarkCyan;
            this.CS.Location = new System.Drawing.Point(41, 360);
            this.CS.Name = "CS";
            this.CS.Size = new System.Drawing.Size(87, 18);
            this.CS.TabIndex = 40;
            this.CS.Text = "ESTATUS";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.AutoRoundedCorners = true;
            this.dtpFechaSalida.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaSalida.BorderColor = System.Drawing.Color.Transparent;
            this.dtpFechaSalida.Checked = true;
            this.dtpFechaSalida.Enabled = false;
            this.dtpFechaSalida.FillColor = System.Drawing.Color.White;
            this.dtpFechaSalida.FocusedColor = System.Drawing.Color.White;
            this.dtpFechaSalida.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(44, 262);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaSalida.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaSalida.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(253, 34);
            this.dtpFechaSalida.TabIndex = 36;
            this.dtpFechaSalida.Value = new System.DateTime(2026, 5, 7, 9, 57, 53, 274);
            // 
            // cbeEstatus
            // 
            this.cbeEstatus.AutoRoundedCorners = true;
            this.cbeEstatus.BackColor = System.Drawing.Color.Transparent;
            this.cbeEstatus.BorderColor = System.Drawing.Color.Gainsboro;
            this.cbeEstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbeEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbeEstatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbeEstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbeEstatus.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.cbeEstatus.ForeColor = System.Drawing.Color.Black;
            this.cbeEstatus.ItemHeight = 30;
            this.cbeEstatus.Location = new System.Drawing.Point(44, 380);
            this.cbeEstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbeEstatus.Name = "cbeEstatus";
            this.cbeEstatus.Size = new System.Drawing.Size(254, 36);
            this.cbeEstatus.TabIndex = 38;
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
            this.txtLibro.Location = new System.Drawing.Point(39, 196);
            this.txtLibro.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtLibro.PlaceholderText = "LIBRO";
            this.txtLibro.SelectedText = "";
            this.txtLibro.Size = new System.Drawing.Size(259, 43);
            this.txtLibro.TabIndex = 35;
            this.txtLibro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLibro_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoRoundedCorners = true;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Location = new System.Drawing.Point(39, 143);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtUsuario.PlaceholderText = "USUARIO";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(259, 43);
            this.txtUsuario.TabIndex = 34;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(41, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "FECHA LIMITE\r\n";
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
            this.btnGuardar.Location = new System.Drawing.Point(58, 439);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(215, 48);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoRoundedCorners = true;
            this.btnLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiar.FillColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(58, 519);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(215, 48);
            this.btnLimpiar.TabIndex = 40;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dgvPrestamos);
            this.panel4.Location = new System.Drawing.Point(364, 143);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(816, 385);
            this.panel4.TabIndex = 46;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AllowUserToResizeColumns = false;
            this.dgvPrestamos.AllowUserToResizeRows = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestamos.ColumnHeadersHeight = 58;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLibro,
            this.Usuario,
            this.Libros,
            this.FechSal,
            this.FechLimite,
            this.EstFisico});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamos.EnableHeadersVisualStyles = false;
            this.dgvPrestamos.Location = new System.Drawing.Point(0, 0);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.RowHeadersWidth = 62;
            this.dgvPrestamos.RowTemplate.Height = 28;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(812, 381);
            this.dgvPrestamos.TabIndex = 0;
            this.dgvPrestamos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellDoubleClick);
            // 
            // IdLibro
            // 
            this.IdLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdLibro.HeaderText = "ID";
            this.IdLibro.MinimumWidth = 8;
            this.IdLibro.Name = "IdLibro";
            this.IdLibro.ReadOnly = true;
            this.IdLibro.Width = 56;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "USUARIO";
            this.Usuario.MinimumWidth = 8;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Libros
            // 
            this.Libros.HeaderText = "LIBROS";
            this.Libros.MinimumWidth = 8;
            this.Libros.Name = "Libros";
            this.Libros.ReadOnly = true;
            // 
            // FechSal
            // 
            this.FechSal.HeaderText = "FECHA DEL PRESTAMO";
            this.FechSal.MinimumWidth = 8;
            this.FechSal.Name = "FechSal";
            this.FechSal.ReadOnly = true;
            // 
            // FechLimite
            // 
            this.FechLimite.HeaderText = "FECHA LIMITE";
            this.FechLimite.MinimumWidth = 8;
            this.FechLimite.Name = "FechLimite";
            this.FechLimite.ReadOnly = true;
            // 
            // EstFisico
            // 
            this.EstFisico.HeaderText = "ESTATUS";
            this.EstFisico.MinimumWidth = 8;
            this.EstFisico.Name = "EstFisico";
            this.EstFisico.ReadOnly = true;
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
            this.txtBusqueda.Location = new System.Drawing.Point(364, 94);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBusqueda.PlaceholderText = "BUSQUEDA";
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.Size = new System.Drawing.Size(816, 41);
            this.txtBusqueda.TabIndex = 41;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.AutoRoundedCorners = true;
            this.dtpFechaLimite.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaLimite.BorderColor = System.Drawing.Color.Transparent;
            this.dtpFechaLimite.Checked = true;
            this.dtpFechaLimite.Enabled = false;
            this.dtpFechaLimite.FillColor = System.Drawing.Color.White;
            this.dtpFechaLimite.FocusedColor = System.Drawing.Color.White;
            this.dtpFechaLimite.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLimite.Location = new System.Drawing.Point(44, 323);
            this.dtpFechaLimite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaLimite.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaLimite.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(253, 34);
            this.dtpFechaLimite.TabIndex = 37;
            this.dtpFechaLimite.Value = new System.DateTime(2026, 5, 7, 9, 57, 53, 274);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(-4, 703);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1434, 874);
            this.panel2.TabIndex = 15;
            // 
            // GestioDePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1402, 804);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaLimite);
            this.Controls.Add(this.labelq);
            this.Controls.Add(this.CS);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.cbeEstatus);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestioDePrestamos";
            this.Text = "GestioDePrestamos";
            this.Load += new System.EventHandler(this.GestioDePrestamos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelq;
        private System.Windows.Forms.Label CS;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaSalida;
        private Guna.UI2.WinForms.Guna2ComboBox cbeEstatus;
        private Guna.UI2.WinForms.Guna2TextBox txtLibro;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private Guna.UI2.WinForms.Guna2TextBox txtBusqueda;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libros;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstFisico;
    }
}