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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cbeEstadoFisico = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBusquedaDeLibros = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEstadoFisico.Properties)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1472, 66);
            this.panel1.TabIndex = 2;
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
            this.pictureEdit1.Location = new System.Drawing.Point(1343, -15);
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
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(630, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBROS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-4, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 49);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(60, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "DETALLES";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.dtpFechaPublicacion);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtEditorial);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.cbeEstadoFisico);
            this.panel3.Controls.Add(this.txtAutor);
            this.panel3.Controls.Add(this.txtTitulo);
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(-2, 89);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 457);
            this.panel3.TabIndex = 4;
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaPublicacion.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(12, 345);
            this.dtpFechaPublicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(268, 32);
            this.dtpFechaPublicacion.TabIndex = 17;
            this.dtpFechaPublicacion.Value = new System.DateTime(2026, 3, 27, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label9.Location = new System.Drawing.Point(7, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "FECHA PUBLICACION:";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtEditorial.Location = new System.Drawing.Point(12, 232);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(271, 32);
            this.txtEditorial.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(7, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "EDITORIAL:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnGuardar.Appearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseBorderColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Appearance.Options.UseForeColor = true;
            this.btnGuardar.Appearance.Options.UseTextOptions = true;
            this.btnGuardar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnGuardar.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.btnGuardar.Location = new System.Drawing.Point(30, 393);
            this.btnGuardar.LookAndFeel.SkinName = "Stardust";
            this.btnGuardar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(212, 38);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbeEstadoFisico
            // 
            this.cbeEstadoFisico.Location = new System.Drawing.Point(12, 290);
            this.cbeEstadoFisico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbeEstadoFisico.Name = "cbeEstadoFisico";
            this.cbeEstadoFisico.Properties.Appearance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.cbeEstadoFisico.Properties.Appearance.Options.UseFont = true;
            this.cbeEstadoFisico.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeEstadoFisico.Size = new System.Drawing.Size(264, 30);
            this.cbeEstadoFisico.TabIndex = 5;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtAutor.Location = new System.Drawing.Point(12, 174);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(271, 32);
            this.txtAutor.TabIndex = 10;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtTitulo.Location = new System.Drawing.Point(12, 118);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(271, 32);
            this.txtTitulo.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtCodigo.Location = new System.Drawing.Point(12, 57);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(271, 32);
            this.txtCodigo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(7, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "ESTADO FISICO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(7, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "AUTOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "TITULO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "CODIGO:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Controls.Add(this.txtBusquedaDeLibros);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.dgvLibros);
            this.panel4.Location = new System.Drawing.Point(260, 61);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1207, 485);
            this.panel4.TabIndex = 5;
            // 
            // txtBusquedaDeLibros
            // 
            this.txtBusquedaDeLibros.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtBusquedaDeLibros.Location = new System.Drawing.Point(373, 22);
            this.txtBusquedaDeLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusquedaDeLibros.Name = "txtBusquedaDeLibros";
            this.txtBusquedaDeLibros.Size = new System.Drawing.Size(514, 32);
            this.txtBusquedaDeLibros.TabIndex = 12;
            this.txtBusquedaDeLibros.TextChanged += new System.EventHandler(this.txtBusquedaDeLibros_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(52, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "BUSQUEDA DE LIBROS:";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLibros.ColumnHeadersHeight = 58;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Codigo,
            this.Titulo,
            this.Autor,
            this.Column1,
            this.EstFisico,
            this.Column3});
            this.dgvLibros.EnableHeadersVisualStyles = false;
            this.dgvLibros.Location = new System.Drawing.Point(58, 62);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.RowHeadersWidth = 62;
            this.dgvLibros.RowTemplate.Height = 28;
            this.dgvLibros.Size = new System.Drawing.Size(1134, 406);
            this.dgvLibros.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "TITULO";
            this.Titulo.MinimumWidth = 8;
            this.Titulo.Name = "Titulo";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "AUTOR";
            this.Autor.MinimumWidth = 8;
            this.Autor.Name = "Autor";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "EDITORIAL";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // EstFisico
            // 
            this.EstFisico.HeaderText = "ESTADO FISICO";
            this.EstFisico.MinimumWidth = 8;
            this.EstFisico.Name = "EstFisico";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FECHA PUBLICACION";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // GestionDeLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1463, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionDeLibros";
            this.Text = "GestionDeLibros";
            this.Load += new System.EventHandler(this.GestionDeLibros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEstadoFisico.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.ComboBoxEdit cbeEstadoFisico;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBusquedaDeLibros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvLibros;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstFisico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}