﻿namespace RegistroDetalles.UI.Registro
{
    partial class rGrupos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rGrupos));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label comentariosLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label visitaIdLabel;
            System.Windows.Forms.Label label3;
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.PersonacomboBox = new System.Windows.Forms.ComboBox();
            this.detalleDataGridView = new System.Windows.Forms.DataGridView();
            this.comentariosTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CargotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            comentariosLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            visitaIdLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(63, 16);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.IdnumericUpDown.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CargotextBox);
            this.groupBox1.Controls.Add(this.Removerbutton);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.PersonacomboBox);
            this.groupBox1.Controls.Add(this.detalleDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(17, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(410, 191);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personas en el grupo";
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = ((System.Drawing.Image)(resources.GetObject("Removerbutton.Image")));
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(14, 160);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(114, 23);
            this.Removerbutton.TabIndex = 28;
            this.Removerbutton.Text = "- Remover Fila";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(257, 20);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 26;
            label2.Text = "Cargo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 20);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 13);
            label1.TabIndex = 24;
            label1.Text = "Persona:";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.ForeColor = System.Drawing.Color.Blue;
            this.Agregarbutton.Location = new System.Drawing.Point(368, 17);
            this.Agregarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(32, 19);
            this.Agregarbutton.TabIndex = 25;
            this.Agregarbutton.Text = "+";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            // 
            // PersonacomboBox
            // 
            this.PersonacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonacomboBox.FormattingEnabled = true;
            this.PersonacomboBox.Location = new System.Drawing.Point(59, 16);
            this.PersonacomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PersonacomboBox.Name = "PersonacomboBox";
            this.PersonacomboBox.Size = new System.Drawing.Size(194, 21);
            this.PersonacomboBox.TabIndex = 23;
            // 
            // detalleDataGridView
            // 
            this.detalleDataGridView.AllowUserToAddRows = false;
            this.detalleDataGridView.AllowUserToDeleteRows = false;
            this.detalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleDataGridView.Location = new System.Drawing.Point(16, 43);
            this.detalleDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.detalleDataGridView.Name = "detalleDataGridView";
            this.detalleDataGridView.ReadOnly = true;
            this.detalleDataGridView.RowTemplate.Height = 24;
            this.detalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detalleDataGridView.Size = new System.Drawing.Size(383, 111);
            this.detalleDataGridView.TabIndex = 22;
            // 
            // comentariosLabel
            // 
            comentariosLabel.AutoSize = true;
            comentariosLabel.Location = new System.Drawing.Point(15, 273);
            comentariosLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            comentariosLabel.Name = "comentariosLabel";
            comentariosLabel.Size = new System.Drawing.Size(68, 13);
            comentariosLabel.TabIndex = 34;
            comentariosLabel.Text = "Comentarios:";
            // 
            // comentariosTextBox
            // 
            this.comentariosTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comentariosTextBox.Location = new System.Drawing.Point(17, 289);
            this.comentariosTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.comentariosTextBox.MaxLength = 100;
            this.comentariosTextBox.Multiline = true;
            this.comentariosTextBox.Name = "comentariosTextBox";
            this.comentariosTextBox.Size = new System.Drawing.Size(411, 32);
            this.comentariosTextBox.TabIndex = 36;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(233, 18);
            fechaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 33;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(281, 15);
            this.fechaDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.fechaDateTimePicker.TabIndex = 35;
            // 
            // visitaIdLabel
            // 
            visitaIdLabel.AutoSize = true;
            visitaIdLabel.Location = new System.Drawing.Point(15, 18);
            visitaIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            visitaIdLabel.Name = "visitaIdLabel";
            visitaIdLabel.Size = new System.Drawing.Size(51, 13);
            visitaIdLabel.TabIndex = 32;
            visitaIdLabel.Text = "Grupo Id:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(143, 13);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(62, 23);
            this.Buscarbutton.TabIndex = 31;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(287, 358);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(114, 47);
            this.Eliminarbutton.TabIndex = 30;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(159, 358);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(114, 47);
            this.Guardarbutton.TabIndex = 29;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(31, 358);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(114, 47);
            this.NuevoButton.TabIndex = 28;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // CargotextBox
            // 
            this.CargotextBox.Location = new System.Drawing.Point(299, 16);
            this.CargotextBox.Name = "CargotextBox";
            this.CargotextBox.Size = new System.Drawing.Size(64, 20);
            this.CargotextBox.TabIndex = 29;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(114, 42);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(142, 20);
            this.NombretextBox.TabIndex = 40;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 45);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 13);
            label3.TabIndex = 39;
            label3.Text = "Nombre del grupo:";
            // 
            // rGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 419);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(comentariosLabel);
            this.Controls.Add(this.comentariosTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(visitaIdLabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.NuevoButton);
            this.Name = "rGrupos";
            this.Text = "rGrupos";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ComboBox PersonacomboBox;
        private System.Windows.Forms.DataGridView detalleDataGridView;
        private System.Windows.Forms.TextBox comentariosTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox CargotextBox;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.TextBox NombretextBox;
    }
}